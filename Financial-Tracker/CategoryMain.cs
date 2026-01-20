using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class CategoryMain : Form
    {
        private CategoryAdd categoryAddForm;

        private Dashboard da;
        private TransactionMain transMain;
        private ProfileMain proMain;

        public CategoryMain()
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

        private void showData()
        {
            connect2Access();

            string insql = "SELECT category_icon AS Icon, category_name AS [Category Name] " +
                "FROM Category WHERE type_id = 1";

            OleDbCommand incmd = new OleDbCommand(insql, conn);
            OleDbDataAdapter inadapter = new OleDbDataAdapter(incmd);
            DataSet indata = new DataSet();
            inadapter.Fill(indata, "cat");
            dgvIncome.DataSource = indata.Tables["cat"];

            dgvIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtINIcon.Texts = dgvIncome.Rows[0].Cells["Icon"].Value.ToString();
            txtINName.Texts = dgvIncome.Rows[0].Cells["Category Name"].Value.ToString();

            string exsql = "SELECT category_icon AS Icon, category_name AS [Category Name] " +
                "FROM Category WHERE type_id = 2";

            OleDbCommand excmd = new OleDbCommand(exsql, conn);
            OleDbDataAdapter exadapter = new OleDbDataAdapter(excmd);
            DataSet exdata = new DataSet();
            exadapter.Fill(exdata, "cat");
            dgvExpense.DataSource = exdata.Tables["cat"];

            dgvExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtEXIcon.Texts = dgvExpense.Rows[0].Cells["Icon"].Value.ToString();
            txtEXName.Texts = dgvExpense.Rows[0].Cells["Category Name"].Value.ToString();
        }

        private void CategoryMain_Load(object sender, EventArgs e)
        {
            showData();
        }

        string InIcon, InName;
        string ExIcon, ExName;

        private void dgvIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIncome.CurrentRow != null)
            {
                InIcon = dgvIncome.CurrentRow.Cells["Icon"].Value.ToString();
                InName = dgvIncome.CurrentRow.Cells["Category Name"].Value.ToString();

                txtINIcon.Texts = InIcon;
                txtINName.Texts = InName;
            }
        }

        private void dgvExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExpense.CurrentRow != null)
            {
                ExIcon = dgvExpense.CurrentRow.Cells["Icon"].Value.ToString();
                ExName = dgvExpense.CurrentRow.Cells["Category Name"].Value.ToString();

                txtEXIcon.Texts = ExIcon;
                txtEXName.Texts = ExName;
            }
        }

        private void btnInEdit_Click(object sender, EventArgs e)
        {
            if (dgvIncome.CurrentRow != null)
            {
                connect2Access();

                string sql = "UPDATE Category " +
                    "SET category_name = @newname, category_icon = @newicon " +
                    "WHERE category_name = @cname";
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.Parameters.AddWithValue("@newname", txtINName.Texts);
                cmd.Parameters.AddWithValue("@newicon", txtINIcon.Texts);
                cmd.Parameters.AddWithValue("@cname", InName);

                int afftectedRows = cmd.ExecuteNonQuery();
                if (afftectedRows == -1)
                {
                    MessageBox.Show("Something Happen!" + Environment.NewLine + "Can not add new data.");
                }

                conn.Close();
                showData();
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }

        private void btnExEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow != null)
            {
                connect2Access();

                string sql = "UPDATE Category " +
                    "SET category_name = @newname, category_icon = @newicon " +
                    "WHERE category_name = @cname";
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.Parameters.AddWithValue("@newname", txtEXName.Texts);
                cmd.Parameters.AddWithValue("@newicon", txtEXIcon.Texts);
                cmd.Parameters.AddWithValue("@cname", ExName);

                int afftectedRows = cmd.ExecuteNonQuery();
                if (afftectedRows == -1)
                {
                    MessageBox.Show("Something Happen!" + Environment.NewLine + "Can not add new data.");
                }

                conn.Close();
                showData();
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }
        private void btnInDelete_Click(object sender, EventArgs e)
        {
            if (dgvIncome.CurrentRow != null)
            {
                connect2Access();

                string sql = "DELETE FROM Category " +
                    "WHERE category_name = @cname";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cname", InName);

                int afftectedRows = cmd.ExecuteNonQuery();
                if (afftectedRows == -1)
                {
                    MessageBox.Show("Something Happen!" + Environment.NewLine + "Can not add new data.");
                }

                conn.Close();
                showData();
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }
        private void btnExDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow != null)
            {
                connect2Access();

                string sql = "DELETE FROM Category " +
                    "WHERE category_name = @cname";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cname", ExName);

                int afftectedRows = cmd.ExecuteNonQuery();
                if (afftectedRows == -1)
                {
                    MessageBox.Show("Something Happen!" + Environment.NewLine + "Can not add new data.");
                }

                conn.Close();
                showData();
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            if (categoryAddForm == null || categoryAddForm.IsDisposed)
            {
                categoryAddForm = new CategoryAdd();
                categoryAddForm.Show();
                this.Hide();
            }
            else if (!categoryAddForm.Visible)
            {
                categoryAddForm.Show();
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

        private void CategoryMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
