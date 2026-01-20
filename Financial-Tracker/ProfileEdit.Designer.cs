namespace ExpenseTracker
{
    partial class ProfileEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileEdit));
            this.panelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.iconTrans = new System.Windows.Forms.PictureBox();
            this.iconCat = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowPass = new ExpenseTracker.UI.UI_toggleButton();
            this.labelShowPass = new System.Windows.Forms.Label();
            this.txtGoal = new ExpenseTracker.UI.UI_textbox();
            this.txtPassword = new ExpenseTracker.UI.UI_textbox();
            this.txtUsername = new ExpenseTracker.UI.UI_textbox();
            this.txtName = new ExpenseTracker.UI.UI_textbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new ExpenseTracker.UI.UI_button();
            this.btnSubmit = new ExpenseTracker.UI.UI_button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelMenu.ColumnCount = 3;
            this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.Controls.Add(this.iconPicture, 1, 7);
            this.panelMenu.Controls.Add(this.iconTrans, 1, 5);
            this.panelMenu.Controls.Add(this.iconCat, 1, 4);
            this.panelMenu.Controls.Add(this.iconHome, 1, 3);
            this.panelMenu.Controls.Add(this.logoImg, 1, 1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.RowCount = 9;
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.Size = new System.Drawing.Size(100, 553);
            this.panelMenu.TabIndex = 5;
            // 
            // iconPicture
            // 
            this.iconPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.iconPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPicture.Image = global::ExpenseTracker.Properties.Resources.user_active;
            this.iconPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconPicture.InitialImage")));
            this.iconPicture.Location = new System.Drawing.Point(23, 463);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(54, 66);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicture.TabIndex = 5;
            this.iconPicture.TabStop = false;
            this.iconPicture.Click += new System.EventHandler(this.iconPicture_Click);
            // 
            // iconTrans
            // 
            this.iconTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.iconTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconTrans.Image = global::ExpenseTracker.Properties.Resources.transaction;
            this.iconTrans.Location = new System.Drawing.Point(23, 319);
            this.iconTrans.Name = "iconTrans";
            this.iconTrans.Size = new System.Drawing.Size(54, 66);
            this.iconTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconTrans.TabIndex = 4;
            this.iconTrans.TabStop = false;
            this.iconTrans.Click += new System.EventHandler(this.iconTrans_Click);
            // 
            // iconCat
            // 
            this.iconCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.iconCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconCat.Image = global::ExpenseTracker.Properties.Resources.category;
            this.iconCat.Location = new System.Drawing.Point(23, 247);
            this.iconCat.Name = "iconCat";
            this.iconCat.Size = new System.Drawing.Size(54, 66);
            this.iconCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCat.TabIndex = 3;
            this.iconCat.TabStop = false;
            this.iconCat.Click += new System.EventHandler(this.iconCat_Click);
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.iconHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconHome.Image = global::ExpenseTracker.Properties.Resources.home;
            this.iconHome.Location = new System.Drawing.Point(23, 175);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(54, 66);
            this.iconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconHome.TabIndex = 2;
            this.iconHome.TabStop = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // logoImg
            // 
            this.logoImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoImg.Image = global::ExpenseTracker.Properties.Resources.applogo;
            this.logoImg.Location = new System.Drawing.Point(23, 23);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(54, 74);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImg.TabIndex = 1;
            this.logoImg.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.15302F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.830603F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43169F));
            this.tableLayoutPanel1.Controls.Add(this.labelCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 553);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCategory, 2);
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(131, 70);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(416, 68);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Edit profile";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtGoal, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtUsername, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(553, 209);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07463F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.92537F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07463F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.92537F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07463F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.92537F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07463F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.92537F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 268);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnShowPass);
            this.flowLayoutPanel1.Controls.Add(this.labelShowPass);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(176, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(167, 21);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPass.AutoSize = true;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.Location = new System.Drawing.Point(137, 3);
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
            this.labelShowPass.Location = new System.Drawing.Point(30, 3);
            this.labelShowPass.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelShowPass.Name = "labelShowPass";
            this.labelShowPass.Size = new System.Drawing.Size(107, 17);
            this.labelShowPass.TabIndex = 5;
            this.labelShowPass.Text = "Show Password";
            this.labelShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGoal
            // 
            this.txtGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtGoal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtGoal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtGoal.BorderRadius = 3;
            this.txtGoal.BorderSize = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.txtGoal, 2);
            this.txtGoal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtGoal.Location = new System.Drawing.Point(3, 229);
            this.txtGoal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGoal.Multiline = false;
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtGoal.PasswordChar = false;
            this.txtGoal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGoal.PlaceholderText = "";
            this.txtGoal.Size = new System.Drawing.Size(340, 31);
            this.txtGoal.TabIndex = 17;
            this.txtGoal.Texts = "";
            this.txtGoal.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtPassword.BorderRadius = 3;
            this.txtPassword.BorderSize = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.txtPassword, 2);
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtPassword.Location = new System.Drawing.Point(3, 163);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(340, 31);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtUsername.BorderRadius = 3;
            this.txtUsername.BorderSize = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.txtUsername, 2);
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtUsername.Location = new System.Drawing.Point(3, 97);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(340, 31);
            this.txtUsername.TabIndex = 15;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtName.BorderRadius = 3;
            this.txtName.BorderSize = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.txtName, 2);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtName.Location = new System.Drawing.Point(3, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(340, 31);
            this.txtName.TabIndex = 14;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.label4.Location = new System.Drawing.Point(3, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Your Goal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ExpenseTracker.Properties.Resources.user_profile;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(131, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(553, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 62);
            this.panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnBack.BorderRadius = 3;
            this.btnBack.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 62);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnSubmit.BorderRadius = 3;
            this.btnSubmit.BorderSize = 0;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(168, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(175, 62);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ProfileEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 550);
            this.Name = "ProfileEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Tracker - Edit your profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileEdit_FormClosing);
            this.Load += new System.EventHandler(this.ProfileEdit_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMenu;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.PictureBox iconTrans;
        private System.Windows.Forms.PictureBox iconCat;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UI.UI_textbox txtGoal;
        private UI.UI_textbox txtPassword;
        private UI.UI_textbox txtUsername;
        private UI.UI_textbox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private UI.UI_button btnBack;
        private UI.UI_button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UI.UI_toggleButton btnShowPass;
        private System.Windows.Forms.Label labelShowPass;
    }
}