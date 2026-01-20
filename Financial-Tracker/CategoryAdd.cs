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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace ExpenseTracker
{
    public partial class CategoryAdd : Form
    {
        private CategoryMain catMain;

        private Dashboard da;
        private TransactionMain transMain;
        private ProfileMain proMain;

        public CategoryAdd()
        {
            InitializeComponent();
        }

        // 

        OleDbConnection conn;

        void connect2Access()
        {
            string conStr = "Provider = Microsoft.Jet.OleDb.4.0;"
                + @"Data Source = D:\02_Exchange\OneDrive\Proiecte\Financial-tracker\financial_tracker_db.mdb";
            conn = new OleDbConnection(conStr);
            conn.Open();
        }

        private void radioIn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIn.Checked)
            {
                radioIn.BackColor = Color.FromArgb(22, 163, 74);
                radioEx.BackColor = Color.FromArgb(24, 24, 27);
            }
            else
            {
                radioIn.BackColor = Color.FromArgb(24, 24, 27);
                radioEx.BackColor = Color.FromArgb(22, 163, 74);
            }
        }

        private void radioEx_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEx.Checked)
            {
                radioIn.BackColor = Color.FromArgb(24, 24, 27);
                radioEx.BackColor = Color.FromArgb(22, 163, 74);
            }
            else
            {
                radioIn.BackColor = Color.FromArgb(22, 163, 74);
                radioEx.BackColor = Color.FromArgb(24, 24, 27);
            }
        }

        string newCatName, newCatIcon;
        int newCatType;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCatName.Texts) || string.IsNullOrEmpty(txtCatIcon.Texts))
            {
                MessageBox.Show("Please enter all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtCatName.Texts))
                {
                    txtCatName.Focus();
                }
                else
                {
                    txtCatIcon.Focus();
                }
            }
            else
            {
                connect2Access();

                if (radioIn.Checked)
                {
                    newCatType = 1;
                }
                else if (radioEx.Checked)
                {
                    newCatType = 2;
                }

                newCatName = txtCatName.Texts;
                newCatIcon = txtCatIcon.Texts;

                string sql = "INSERT INTO Category(category_name, category_icon, type_id) " +
                    "VALUES(@name, @icon, @type)";
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", newCatName);
                cmd.Parameters.AddWithValue("@icon", newCatIcon);
                cmd.Parameters.AddWithValue("@type", newCatType);

                int afftectedRows = cmd.ExecuteNonQuery();
                if (afftectedRows == -1)
                {
                    MessageBox.Show("Something Happen!" + Environment.NewLine + "Can not add new data.");
                }

                MessageBox.Show("New category has been created.", "Create a new category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCatName.Texts = "";
                txtCatIcon.Texts = "";

                conn.Close();
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
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

        private void CategoryAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
