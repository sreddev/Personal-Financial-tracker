using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpenseTracker
{
    public partial class TransactionMain : Form
    {
        private TransactionAdd transAdd;

        private Dashboard da;
        private CategoryMain catMain;
        private ProfileMain proMain;

        public TransactionMain()
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

        private int currentCatID (string catName)
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

        private void showData()
        {
            connect2Access();

            string sql = "SELECT Transactions.transaction_date AS [Date], " +
                "Transactions.transaction_title AS [Title], " +
                "Category.category_name AS [Category], " +
                "Transactions.transaction_amount AS [Amount] " +
                "FROM Transactions INNER JOIN Category " +
                "ON Transactions.category_id = Category.category_id " +
                "WHERE Transactions.user_id = @userid";

            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", currentUserID());
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            DataSet data = new DataSet();
            adapter.Fill(data, "transaction");
            dgvTrans.DataSource = data.Tables["transaction"];

            dgvTrans.Sort(dgvTrans.Columns[0], ListSortDirection.Descending);
            dgvTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string catsql = "SELECT category_name FROM Category";
            OleDbCommand catcmd = new OleDbCommand(catsql, conn);
            OleDbDataAdapter catadapter = new OleDbDataAdapter(catcmd);
            DataSet catdataset = new DataSet();
            catadapter.Fill(catdataset, "transCat");
            DataTable catdata = catdataset.Tables["transCat"];

            foreach (DataRow row in catdata.Rows)
            {
                comboTransCat.Items.Add(row["category_name"].ToString());
            }
        }

        private void TransactionMain_Load(object sender, EventArgs e)
        {
            showData();
        }

        string transTitle, transCategory;
        decimal transAmount;
        DateTime transDate;

        private void dgvTrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrans.CurrentRow != null)
            {
                transDate = Convert.ToDateTime(dgvTrans.CurrentRow.Cells["Date"].Value);
                transTitle = dgvTrans.CurrentRow.Cells["Title"].Value.ToString();
                transCategory = dgvTrans.CurrentRow.Cells["Category"].Value.ToString();
                transAmount = Convert.ToDecimal(dgvTrans.CurrentRow.Cells["Amount"].Value);

                dateTrans.Value = transDate;
                txtTransTitle.Texts = transTitle;
                comboTransCat.SelectedItem = transCategory;
                numTransAmount.Value = transAmount;
            }
        }

        string newTitle, newCat;
        decimal newAmount;
        DateTime newDate;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTrans.CurrentRow != null)
            {
                newDate = dateTrans.Value.Date;
                newTitle = txtTransTitle.Texts;
                newCat = comboTransCat.SelectedItem.ToString();
                newAmount = numTransAmount.Value;

                connect2Access();

                string sql = "UPDATE Transactions " +
                             "SET transaction_title = @newtitle, transaction_date = @newdate, " +
                             "category_id = @newcat, transaction_amount = @newamount " +
                             "WHERE transaction_title = @ctitle";
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.Parameters.AddWithValue("@newtitle", newTitle);
                cmd.Parameters.AddWithValue("@newdate", newDate);
                cmd.Parameters.AddWithValue("@newcat", currentCatID(newCat));
                cmd.Parameters.AddWithValue("@newamount", newAmount);

                cmd.Parameters.AddWithValue("@ctitle", transTitle);

                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows == -1)
                {
                    MessageBox.Show("Something Happened!" + Environment.NewLine + "Cannot update data.");
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Please select a transaction to update.");
            }

            showData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTrans.CurrentRow != null)
            {
                connect2Access();

                string sql = "DELETE FROM Transactions " +
                             "WHERE transaction_title = @ctitle";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ctitle", dgvTrans.CurrentRow.Cells["Title"].Value.ToString());

                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows == -1)
                {
                    MessageBox.Show("Something Happened!" + Environment.NewLine + "Cannot delete data.");
                }

                conn.Close();
                showData();
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }

        private void btnNewTrans_Click(object sender, EventArgs e)
        {
            if (transAdd == null || transAdd.IsDisposed)
            {
                transAdd = new TransactionAdd();
                transAdd.Show();
                this.Hide();
            }
            else if (!transAdd.Visible)
            {
                transAdd.Show();
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

        private void TransactionMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
