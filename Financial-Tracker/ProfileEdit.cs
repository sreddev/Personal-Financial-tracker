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
using System.Xml.Linq;

namespace ExpenseTracker
{
    public partial class ProfileEdit : Form
    {
        private ProfileMain proMain;

        private Dashboard da;
        private CategoryMain catMain;
        private TransactionMain transMain;

        public ProfileEdit()
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

        private bool checkUsername(string username, int userId)
        {
            connect2Access();
            string sql = "SELECT COUNT(*) FROM Users WHERE user_username = @username AND user_id <> @userId";
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@userId", userId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
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
        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            showData();
        }

        string newName, newUsername, newPassword, newGoal;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            newName = txtName.Texts;
            newUsername = txtUsername.Texts;
            newPassword = txtPassword.Texts;
            newGoal = txtGoal.Texts;

            connect2Access();

            if (string.IsNullOrEmpty(txtName.Texts) || string.IsNullOrEmpty(txtUsername.Texts) ||
                string.IsNullOrEmpty(txtPassword.Texts) || string.IsNullOrEmpty(txtGoal.Texts))
            {
                MessageBox.Show("Please enter all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkUsername(newUsername, currentUserID()))
            {
                MessageBox.Show("Username already exists." + Environment.NewLine + "Please choose a different one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            string sql = "UPDATE Users " +
                "SET user_name = @newname, user_username = @newusername, user_password = @newpass, user_goal = @newgoal " +
                "WHERE user_id = @userid";
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            cmd.Parameters.AddWithValue("@newname", newName);
            cmd.Parameters.AddWithValue("@newusername", newUsername);
            cmd.Parameters.AddWithValue("@newpass", newPassword);
            cmd.Parameters.AddWithValue("@newgoal", newGoal);
            cmd.Parameters.AddWithValue("@userid", currentUserID());

            int afftectedRows = cmd.ExecuteNonQuery();
            if (afftectedRows == -1)
            {
                MessageBox.Show("Something Happen!" + Environment.NewLine + "Can not add new data.");
            }
            MessageBox.Show("Your profile has been Updated.", "Edit your profile", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void ProfileEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
