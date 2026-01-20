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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
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

        private bool checkUsername(string username)
        {
            connect2Access();
            string sql = "SELECT COUNT(*) FROM Users WHERE user_username = @username";
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            connect2Access();

            if (string.IsNullOrEmpty(txtName.Texts) || string.IsNullOrEmpty(txtUsername.Texts) || 
                string.IsNullOrEmpty(txtPassword.Texts) || string.IsNullOrEmpty(txtConfirm.Texts))
            {
                MessageBox.Show("Please enter all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkUsername(txtUsername.Texts))
            {
                MessageBox.Show("Username already exists." + Environment.NewLine + "Please choose a different one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Texts != txtConfirm.Texts)
            {
                MessageBox.Show("Passwords must be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            string sql = "INSERT INTO Users(user_name, user_username, user_password) " + "VALUES(@name, @username, @password)";
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("name", txtName.Texts);
                cmd.Parameters.AddWithValue("username", txtUsername.Texts);
                cmd.Parameters.AddWithValue("password", txtPassword.Texts);
                int afftectedRows = cmd.ExecuteNonQuery();
                if (afftectedRows == -1)
                {
                    MessageBox.Show("Something Happen!" + Environment.NewLine + "Can not add new data.");
                }
            }

            conn.Close();

            MessageBox.Show("Your account has been created.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }

        private void btnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPass.Checked)
            {
                txtPassword.PasswordChar = false;
                txtConfirm.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
                txtConfirm.PasswordChar = true;
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoZone_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
