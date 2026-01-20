namespace ExpenseTracker
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUpZone = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowPass = new ExpenseTracker.UI.UI_toggleButton();
            this.labelShowPass = new System.Windows.Forms.Label();
            this.txtPassword = new ExpenseTracker.UI.UI_textbox();
            this.txtConfirm = new ExpenseTracker.UI.UI_textbox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.txtUsername = new ExpenseTracker.UI.UI_textbox();
            this.txtName = new ExpenseTracker.UI.UI_textbox();
            this.btnSignUp = new ExpenseTracker.UI.UI_button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.logoZone = new System.Windows.Forms.TableLayoutPanel();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.SignUpZone.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.logoZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpZone
            // 
            this.SignUpZone.ColumnCount = 3;
            this.SignUpZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SignUpZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SignUpZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SignUpZone.Controls.Add(this.flowLayoutPanel1, 1, 7);
            this.SignUpZone.Controls.Add(this.txtPassword, 1, 5);
            this.SignUpZone.Controls.Add(this.txtConfirm, 1, 6);
            this.SignUpZone.Controls.Add(this.SignUpLabel, 1, 1);
            this.SignUpZone.Controls.Add(this.txtUsername, 1, 4);
            this.SignUpZone.Controls.Add(this.txtName, 1, 3);
            this.SignUpZone.Controls.Add(this.btnSignUp, 1, 9);
            this.SignUpZone.Controls.Add(this.flowLayoutPanel2, 1, 10);
            this.SignUpZone.Dock = System.Windows.Forms.DockStyle.Left;
            this.SignUpZone.Location = new System.Drawing.Point(0, 0);
            this.SignUpZone.Name = "SignUpZone";
            this.SignUpZone.RowCount = 12;
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SignUpZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.SignUpZone.Size = new System.Drawing.Size(300, 400);
            this.SignUpZone.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnShowPass);
            this.flowLayoutPanel1.Controls.Add(this.labelShowPass);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 240);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 23);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPass.AutoSize = true;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.Location = new System.Drawing.Point(164, 3);
            this.btnShowPass.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnShowPass.MinimumSize = new System.Drawing.Size(30, 15);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.OffBackColor = System.Drawing.Color.Gray;
            this.btnShowPass.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnShowPass.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnShowPass.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.btnShowPass.Size = new System.Drawing.Size(30, 15);
            this.btnShowPass.TabIndex = 4;
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.CheckedChanged += new System.EventHandler(this.btnShowPass_CheckedChanged);
            // 
            // labelShowPass
            // 
            this.labelShowPass.ForeColor = System.Drawing.Color.Gray;
            this.labelShowPass.Location = new System.Drawing.Point(57, 3);
            this.labelShowPass.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelShowPass.Name = "labelShowPass";
            this.labelShowPass.Size = new System.Drawing.Size(107, 17);
            this.labelShowPass.TabIndex = 5;
            this.labelShowPass.Text = "Show Password";
            this.labelShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtPassword.Location = new System.Drawing.Point(53, 169);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(194, 28);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtConfirm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtConfirm.BorderRadius = 15;
            this.txtConfirm.BorderSize = 1;
            this.txtConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtConfirm.Location = new System.Drawing.Point(53, 205);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirm.Multiline = false;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtConfirm.PasswordChar = true;
            this.txtConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirm.PlaceholderText = "Confirm Password";
            this.txtConfirm.Size = new System.Drawing.Size(194, 28);
            this.txtConfirm.TabIndex = 11;
            this.txtConfirm.Texts = "";
            this.txtConfirm.UnderlinedStyle = false;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.SignUpLabel.Location = new System.Drawing.Point(53, 40);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(194, 50);
            this.SignUpLabel.TabIndex = 10;
            this.SignUpLabel.Text = "SIGN UP";
            this.SignUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtUsername.Location = new System.Drawing.Point(53, 133);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(194, 28);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtName.BorderRadius = 15;
            this.txtName.BorderSize = 1;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtName.Location = new System.Drawing.Point(53, 97);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "Your Name";
            this.txtName.Size = new System.Drawing.Size(194, 28);
            this.txtName.TabIndex = 2;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnSignUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnSignUp.BorderRadius = 3;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(53, 272);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(194, 44);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.labelLogin);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(53, 322);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(194, 34);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Already have an account?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.labelLogin.Location = new System.Drawing.Point(3, 17);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(188, 17);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // logoZone
            // 
            this.logoZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.logoZone.ColumnCount = 3;
            this.logoZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.Controls.Add(this.logoImg, 1, 1);
            this.logoZone.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.logoZone.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoZone.Location = new System.Drawing.Point(300, 0);
            this.logoZone.Name = "logoZone";
            this.logoZone.RowCount = 3;
            this.logoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.Size = new System.Drawing.Size(300, 400);
            this.logoZone.TabIndex = 3;
            this.logoZone.Paint += new System.Windows.Forms.PaintEventHandler(this.logoZone_Paint);
            // 
            // logoImg
            // 
            this.logoImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoImg.Image = global::ExpenseTracker.Properties.Resources.applogo;
            this.logoImg.Location = new System.Drawing.Point(102, 136);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(93, 127);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.logoZone.SetColumnSpan(this.flowLayoutPanel3, 3);
            this.flowLayoutPanel3.Controls.Add(this.btnClose);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(294, 127);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ExpenseTracker.Properties.Resources.icon_close;
            this.btnClose.Location = new System.Drawing.Point(271, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.logoZone);
            this.Controls.Add(this.SignUpZone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Tracker - Sign Up";
            this.SignUpZone.ResumeLayout(false);
            this.SignUpZone.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.logoZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel SignUpZone;
        private System.Windows.Forms.Label SignUpLabel;
        private UI.UI_textbox txtUsername;
        private UI.UI_textbox txtName;
        private UI.UI_button btnSignUp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TableLayoutPanel logoZone;
        private System.Windows.Forms.PictureBox logoImg;
        private UI.UI_textbox txtPassword;
        private UI.UI_textbox txtConfirm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UI.UI_toggleButton btnShowPass;
        private System.Windows.Forms.Label labelShowPass;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox btnClose;
    }
}