namespace ExpenseTracker
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logoZone = new System.Windows.Forms.TableLayoutPanel();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.loginZone = new System.Windows.Forms.TableLayoutPanel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.txtPassword = new ExpenseTracker.UI.UI_textbox();
            this.txtUsername = new ExpenseTracker.UI.UI_textbox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowPass = new ExpenseTracker.UI.UI_toggleButton();
            this.labelShowPass = new System.Windows.Forms.Label();
            this.btnLogin = new ExpenseTracker.UI.UI_button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.logoZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.loginZone.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // logoZone
            // 
            this.logoZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.logoZone.ColumnCount = 3;
            this.logoZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.Controls.Add(this.logoImg, 1, 1);
            this.logoZone.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoZone.Location = new System.Drawing.Point(0, 0);
            this.logoZone.Name = "logoZone";
            this.logoZone.RowCount = 3;
            this.logoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.logoZone.Size = new System.Drawing.Size(300, 400);
            this.logoZone.TabIndex = 0;
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
            this.logoImg.Click += new System.EventHandler(this.logoImg_Click);
            // 
            // loginZone
            // 
            this.loginZone.ColumnCount = 3;
            this.loginZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.loginZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.loginZone.Controls.Add(this.loginLabel, 1, 1);
            this.loginZone.Controls.Add(this.txtPassword, 1, 4);
            this.loginZone.Controls.Add(this.txtUsername, 1, 3);
            this.loginZone.Controls.Add(this.flowLayoutPanel1, 1, 5);
            this.loginZone.Controls.Add(this.btnLogin, 1, 7);
            this.loginZone.Controls.Add(this.flowLayoutPanel2, 1, 8);
            this.loginZone.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.loginZone.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginZone.Location = new System.Drawing.Point(300, 0);
            this.loginZone.Name = "loginZone";
            this.loginZone.RowCount = 10;
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.loginZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.loginZone.Size = new System.Drawing.Size(300, 400);
            this.loginZone.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.loginLabel.Location = new System.Drawing.Point(53, 50);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(194, 50);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "LOGIN";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
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
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnShowPass);
            this.flowLayoutPanel1.Controls.Add(this.labelShowPass);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 204);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 23);
            this.flowLayoutPanel1.TabIndex = 4;
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
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnLogin.BorderRadius = 3;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(53, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(194, 44);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.labelSignUp);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(53, 312);
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
            this.label1.Text = "Don\'t have an account?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSignUp
            // 
            this.labelSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.labelSignUp.Location = new System.Drawing.Point(3, 17);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(188, 17);
            this.labelSignUp.TabIndex = 7;
            this.labelSignUp.Text = "Sign Up";
            this.labelSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginZone.SetColumnSpan(this.flowLayoutPanel3, 3);
            this.flowLayoutPanel3.Controls.Add(this.btnClose);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(294, 44);
            this.flowLayoutPanel3.TabIndex = 11;
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
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.loginZone);
            this.Controls.Add(this.logoZone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Tracker - Login";
            this.logoZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.loginZone.ResumeLayout(false);
            this.loginZone.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel logoZone;
        private System.Windows.Forms.TableLayoutPanel loginZone;
        private System.Windows.Forms.Label loginLabel;
        private UI.UI_textbox txtUsername;
        private UI.UI_textbox txtPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UI.UI_toggleButton btnShowPass;
        private System.Windows.Forms.Label labelShowPass;
        private UI.UI_button btnLogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox logoImg;
    }
}

