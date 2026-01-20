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

namespace ExpenseTracker
{
    public partial class TransactionAdd : Form
    {
        private TransactionMain transMain;

        private Dashboard da;
        private CategoryMain catMain;
        private ProfileMain proMain;

        public TransactionAdd()
        {
            InitializeComponent();
        }

        // 6401941 เมธาวี เจริญตั้งศิริกุล

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

        private int currentCatID(string catName)
        {
            int categoryId = 0;

            connect2Access();

            string sql = "SELECT category_id " +
                "FROM Category " +
                "WHERE category_name = @categoryName";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categoryName", catName);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                categoryId = Convert.ToInt32(result);
            }

            conn.Close();

            return categoryId;
        }

        private void TransactionAdd_Load(object sender, EventArgs e)
        {
            connect2Access();

            string catsql = "SELECT category_name FROM Category";
            OleDbCommand catcmd = new OleDbCommand(catsql, conn);
            OleDbDataAdapter catadapter = new OleDbDataAdapter(catcmd);
            DataSet catdataset = new DataSet();
            catadapter.Fill(catdataset, "transCat");
            DataTable catdata = catdataset.Tables["transCat"];

            foreach (DataRow row in catdata.Rows)
            {
                comboNewCat.Items.Add(row["category_name"].ToString());
            }

            dateNewTrans.Value = DateTime.Now;
        }

        string newTransTitle, newTransCat;
        decimal newTransAmount;
        DateTime newTransDate;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewTrans.Texts))
            {
                MessageBox.Show("Please enter all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewTrans.Focus();
            }
            else
            {
                connect2Access();

                newTransDate = dateNewTrans.Value.Date;
                newTransTitle = txtNewTrans.Texts;
                newTransCat = comboNewCat.SelectedItem.ToString();
                newTransAmount = numNewAmount.Value;

                string sql = "INSERT INTO Transactions(user_id, transaction_title, transaction_date, category_id, transaction_amount) " +
                    "VALUES(@userid, @title, @date, @catid, @amount)";
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.Parameters.AddWithValue("@userid", currentUserID());
                cmd.Parameters.AddWithValue("@title", newTransTitle);
                cmd.Parameters.AddWithValue("@date", newTransDate);
                cmd.Parameters.AddWithValue("@catid", currentCatID(newTransCat));
                cmd.Parameters.AddWithValue("@amount", newTransAmount);

                int afftectedRows = cmd.ExecuteNonQuery();
                if (afftectedRows == -1)
                {
                    MessageBox.Show("Something Happen!" + Environment.NewLine + "Can not add new data.");
                }

                MessageBox.Show("New transaction has been created.", "Create a new transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dateNewTrans.Value = DateTime.Now;
                txtNewTrans.Texts = "";
                comboNewCat.SelectedIndex = 0;
                numNewAmount.Value = 0;

                conn.Close();
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
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

        private void iconHome_Click(object sender, EventArgs e)
        {
            if (da == null || da.IsDisposed)
            {
                da = new Dashboard();
                da.Show();
                this.Hide();
            }
            else if (!da.Visible)
            {
                da.Show();
                this.Hide();
            }
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

        private void TransactionAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
