using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpenseTracker
{
    public partial class Dashboard : Form
    {
        private CategoryMain catMain;
        private TransactionMain transMain;
        private ProfileMain proMain;
        public Dashboard()
        {
            InitializeComponent();
        }

        // 6401941 

        OleDbConnection conn;

        void connect2Access()
        {
            string conStr = "Provider = Microsoft.Jet.OleDb.4.0;"
                + @"Data Source = D:\02_Exchange\OneDrive\Proiecte\Financial-tracker\financial_tracker_db.mdb";
            conn = new OleDbConnection(conStr);
            conn.Open();
        }

        private int currentUserID()
        {
            int userid = 0;

            connect2Access();
            string sql = "SELECT TOP 1 user_id " +
                "FROM Login " +
                "ORDER BY login_id DESC";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                userid = Convert.ToInt32(result);
            }

            conn.Close();

            return userid;
        }

        private string currentUser()
        {
            string us_name = "";

            connect2Access();
            string sql = "SELECT user_name FROM Users " +
                "INNER JOIN Login " +
                "ON Users.user_id = Login.user_id " +
                "WHERE Users.user_id = @userID";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", currentUserID());

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                us_name = result.ToString();
            }

            conn.Close();

            return us_name;
        }

        private int sumIncome()
        {
            int sumIn = 0;

            connect2Access();

            string sql = "SELECT SUM(Transactions.transaction_amount) " +
                "FROM Transactions " +
                "INNER JOIN Category " +
                "ON Transactions.category_id = Category.category_id " +
                "WHERE Category.type_id = 1 AND Transactions.user_id = @userID";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", currentUserID());

            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                sumIn = Convert.ToInt32(result);
            }

            conn.Close();

            return sumIn;
        }

        private int sumExpense()
        {
            int sumEx = 0;

            connect2Access();

            string sql = "SELECT SUM(Transactions.transaction_amount) " +
                "FROM Transactions " +
                "INNER JOIN Category " +
                "ON Transactions.category_id = Category.category_id " +
                "WHERE Category.type_id = 2 AND Transactions.user_id = @userID";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", currentUserID());

            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                sumEx = Convert.ToInt32(result);
            }

            conn.Close();

            return sumEx;
        }

        private Dictionary<string, int> categoryAmount()
        {
            Dictionary<string, int> catAmount = new Dictionary<string, int>();

            connect2Access();

            string sql = "SELECT Category.category_name, SUM(Transactions.transaction_amount) AS total_amount " +
                         "FROM Transactions " +
                         "INNER JOIN Category ON Transactions.category_id = Category.category_id " +
                         "WHERE Category.type_id = 2 AND Transactions.user_id = @userID " +
                         "GROUP BY Category.category_name";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", currentUserID());

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string categoryName = reader["category_name"].ToString();
                int totalAmount = Convert.ToInt32(reader["total_amount"]);

                catAmount.Add(categoryName, totalAmount);
            }

            conn.Close();

            return catAmount;
        }

        private void createDonut(Dictionary<string, int> data)
        {
            chartDonut.Series["Series1"].Points.Clear();

            foreach (var entry in data)
            {
                chartDonut.Series["Series1"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        public Dictionary<DateTime, int> GetTransactionData(int typeId)
        {
            Dictionary<DateTime, int> transactionData = new Dictionary<DateTime, int>();

            connect2Access();

            string sql = "SELECT transaction_date, SUM(transaction_amount) AS total_amount FROM Transactions " +
                         "INNER JOIN Category ON Transactions.category_id = Category.category_id " +
                         "WHERE Category.type_id = @typeId AND transaction_date >= @startDate AND Transactions.user_id = @userID " +
                         "GROUP BY transaction_date";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@typeId", typeId);
            cmd.Parameters.AddWithValue("@startDate", DateTime.Today.AddDays(-7).Date);
            cmd.Parameters.AddWithValue("@userID", currentUserID());

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime transactionDate = reader.GetDateTime(0).Date;
                int totalAmount = Convert.ToInt32(reader["total_amount"]);

                transactionData[transactionDate] = totalAmount;
            }

            return transactionData;
        }


        private void createSpline()
        {
            Dictionary<DateTime, int> incomeData = GetTransactionData(1);
            Dictionary<DateTime, int> expenseData = GetTransactionData(2);

            Series incomeSeries = new Series("Income");
            Series expenseSeries = new Series("Expense");

            incomeSeries.ChartType = SeriesChartType.Spline;
            expenseSeries.ChartType = SeriesChartType.Spline;

            foreach (var entry in incomeData)
            {
                incomeSeries.Points.AddXY(entry.Key, entry.Value);
            }

            foreach (var entry in expenseData)
            {
                expenseSeries.Points.AddXY(entry.Key, entry.Value);
            }

            chartInvsEx.Series.Clear(); // Clear existing series
            chartInvsEx.Series.Add(incomeSeries);
            chartInvsEx.Series.Add(expenseSeries);

            chartInvsEx.ChartAreas[0].AxisX.Minimum = DateTime.Today.AddDays(-7).ToOADate();
            chartInvsEx.ChartAreas[0].AxisX.Maximum = DateTime.Today.ToOADate();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            connect2Access();
            int sumBalance = sumIncome() - sumExpense();

            labelWelcome.Text = "Hello " + currentUser() + "!";
            labelIncome.Text = sumIncome().ToString();
            labelExpense.Text = sumExpense().ToString();
            labelBalance.Text = sumBalance.ToString();

            Dictionary<string, int> data = categoryAmount();
            createDonut(data);
            createSpline();
        }

        private void iconCat_Click(object sender, EventArgs e)
        {
            if (catMain == null || catMain.IsDisposed)
            {
                catMain = new CategoryMain();
                catMain.Show();
                this.Hide();
            }
            else if (!catMain.Visible)
            {
                catMain.Show();
                this.Hide();
            }
        }

        private void iconTrans_Click(object sender, EventArgs e)
        {
            if (transMain == null || transMain.IsDisposed)
            {
                transMain = new TransactionMain();
                transMain.Show();
                this.Hide();
            }
            else if (!transMain.Visible)
            {
                transMain.Show();
                this.Hide();
            }
        }

        private void iconPicture_Click(object sender, EventArgs e)
        {
            if (proMain == null || proMain.IsDisposed)
            {
                proMain = new ProfileMain();
                proMain.Show();
                this.Hide();
            }
            else if (!proMain.Visible)
            {
                proMain.Show();
                this.Hide();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelIncome_Click(object sender, EventArgs e)
        {

        }
    }
}
