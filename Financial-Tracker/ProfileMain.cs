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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpenseTracker
{
    public partial class ProfileMain : Form
    {
        private ProfileEdit proEdit;
        private LoginForm logIn;

        private Dashboard da;
        private CategoryMain catMain;
        private TransactionMain transMain;
        
        public ProfileMain()
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

        private void showData()
        {
            connect2Access();

            string sql = "SELECT * FROM Users WHERE user_id = @userID";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", currentUserID());

            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Texts = reader["user_name"].ToString();
                txtUsername.Texts = reader["user_username"].ToString();
                txtPassword.Texts = reader["user_password"].ToString();
                txtGoal.Texts = reader["user_goal"].ToString();
            }

            conn.Close();
        }

        private void ProfileMain_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (proEdit == null || proEdit.IsDisposed)
            {
                proEdit = new ProfileEdit();
                proEdit.Show();
                this.Hide();
            }
            else if (!proEdit.Visible)
            {
                proEdit.Show();
                this.Hide();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (logIn == null || logIn.IsDisposed)
            {
                logIn = new LoginForm();
                logIn.Show();
                this.Hide();
            }
            else if (!logIn.Visible)
            {
                logIn.Show();
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

        private void ProfileMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPass.Checked)
            {
                txtPassword.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
            }
        }
    }
}
