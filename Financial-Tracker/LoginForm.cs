using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExpenseTracker
{
    public partial class LoginForm : Form
    {
        private Dashboard da;

        public LoginForm()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Texts) || string.IsNullOrEmpty(txtPassword.Texts))
            {
                MessageBox.Show("Please enter all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtUsername.Texts))
                {
                    txtUsername.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
            else
            {
                connect2Access();
                string sql = "SELECT user_id FROM Users WHERE user_username = @username AND user_password = @password";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Texts);
                cmd.Parameters.AddWithValue("@password", txtPassword.Texts);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data, "userid");
                if (data.Tables["userid"].Rows.Count > 0)
                {
                    int userId = Convert.ToInt32(data.Tables["userid"].Rows[0]["user_id"]);
                    string log = "INSERT INTO Login (user_id) VALUES (@userID)";
                    OleDbCommand logcmd = new OleDbCommand(log, conn);
                    logcmd.Parameters.AddWithValue("@userID", userId);
                    
                    logcmd.ExecuteNonQuery();
                    
                    conn.Close();

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
                else
                {
                    MessageBox.Show("Incorrect username or password." + Environment.NewLine + "Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }

                conn.Close();
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

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
            signUp = null;
            this.Show();
            connect2Access();
        }

        private void logoImg_Click(object sender, EventArgs e)
        {

        }
    }
}
