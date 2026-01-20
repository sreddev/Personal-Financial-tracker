namespace ExpenseTracker
{
    partial class CategoryMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryMain));
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.iconTrans = new System.Windows.Forms.PictureBox();
            this.iconCat = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEXIcon = new ExpenseTracker.UI.UI_textbox();
            this.txtEXName = new ExpenseTracker.UI.UI_textbox();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.btnInDelete = new ExpenseTracker.UI.UI_button();
            this.btnInEdit = new ExpenseTracker.UI.UI_button();
            this.labelIncome = new System.Windows.Forms.Label();
            this.panelExpense = new System.Windows.Forms.Panel();
            this.btnExDelete = new ExpenseTracker.UI.UI_button();
            this.btnExEdit = new ExpenseTracker.UI.UI_button();
            this.labelExpense = new System.Windows.Forms.Label();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.btnNewCat = new ExpenseTracker.UI.UI_button();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtINIcon = new ExpenseTracker.UI.UI_textbox();
            this.txtINName = new ExpenseTracker.UI.UI_textbox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelIncome.SuspendLayout();
            this.panelExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPicture
            // 
            this.iconPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.iconPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPicture.Image = global::ExpenseTracker.Properties.Resources.user;
            this.iconPicture.InitialImage = null;
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
            this.iconCat.Image = global::ExpenseTracker.Properties.Resources.category_active;
            this.iconCat.Location = new System.Drawing.Point(23, 247);
            this.iconCat.Name = "iconCat";
            this.iconCat.Size = new System.Drawing.Size(54, 66);
            this.iconCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCat.TabIndex = 3;
            this.iconCat.TabStop = false;
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
            this.panelMenu.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCategory, 2);
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(131, 59);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(416, 57);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.15301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.830603F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43169F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.panelIncome, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelExpense, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvExpense, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNewCat, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvIncome, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77905F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77989F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 553);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.txtEXIcon, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtEXName, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(553, 445);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(346, 43);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // txtEXIcon
            // 
            this.txtEXIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtEXIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtEXIcon.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtEXIcon.BorderRadius = 3;
            this.txtEXIcon.BorderSize = 1;
            this.txtEXIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEXIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtEXIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtEXIcon.Location = new System.Drawing.Point(3, 4);
            this.txtEXIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEXIcon.Multiline = false;
            this.txtEXIcon.Name = "txtEXIcon";
            this.txtEXIcon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEXIcon.PasswordChar = false;
            this.txtEXIcon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEXIcon.PlaceholderText = "";
            this.txtEXIcon.Size = new System.Drawing.Size(132, 35);
            this.txtEXIcon.TabIndex = 3;
            this.txtEXIcon.Texts = "";
            this.txtEXIcon.UnderlinedStyle = false;
            // 
            // txtEXName
            // 
            this.txtEXName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtEXName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtEXName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtEXName.BorderRadius = 3;
            this.txtEXName.BorderSize = 1;
            this.txtEXName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEXName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEXName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtEXName.Location = new System.Drawing.Point(141, 4);
            this.txtEXName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEXName.Multiline = false;
            this.txtEXName.Name = "txtEXName";
            this.txtEXName.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.txtEXName.PasswordChar = false;
            this.txtEXName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEXName.PlaceholderText = "";
            this.txtEXName.Size = new System.Drawing.Size(202, 26);
            this.txtEXName.TabIndex = 2;
            this.txtEXName.Texts = "";
            this.txtEXName.UnderlinedStyle = false;
            // 
            // panelIncome
            // 
            this.panelIncome.AutoSize = true;
            this.panelIncome.Controls.Add(this.btnInDelete);
            this.panelIncome.Controls.Add(this.btnInEdit);
            this.panelIncome.Controls.Add(this.labelIncome);
            this.panelIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIncome.Location = new System.Drawing.Point(131, 176);
            this.panelIncome.Name = "panelIncome";
            this.panelIncome.Size = new System.Drawing.Size(346, 32);
            this.panelIncome.TabIndex = 9;
            // 
            // btnInDelete
            // 
            this.btnInDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDelete.AutoSize = true;
            this.btnInDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnInDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnInDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnInDelete.BorderRadius = 3;
            this.btnInDelete.BorderSize = 2;
            this.btnInDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInDelete.FlatAppearance.BorderSize = 0;
            this.btnInDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnInDelete.Location = new System.Drawing.Point(276, 2);
            this.btnInDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnInDelete.Name = "btnInDelete";
            this.btnInDelete.Size = new System.Drawing.Size(70, 30);
            this.btnInDelete.TabIndex = 6;
            this.btnInDelete.Text = "DELETE";
            this.btnInDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnInDelete.UseVisualStyleBackColor = false;
            this.btnInDelete.Click += new System.EventHandler(this.btnInDelete_Click);
            // 
            // btnInEdit
            // 
            this.btnInEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInEdit.AutoSize = true;
            this.btnInEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnInEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnInEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnInEdit.BorderRadius = 3;
            this.btnInEdit.BorderSize = 2;
            this.btnInEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInEdit.FlatAppearance.BorderSize = 0;
            this.btnInEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnInEdit.Location = new System.Drawing.Point(206, 2);
            this.btnInEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnInEdit.Name = "btnInEdit";
            this.btnInEdit.Size = new System.Drawing.Size(70, 30);
            this.btnInEdit.TabIndex = 5;
            this.btnInEdit.Text = "UPDATE";
            this.btnInEdit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnInEdit.UseVisualStyleBackColor = false;
            this.btnInEdit.Click += new System.EventHandler(this.btnInEdit_Click);
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelIncome.Location = new System.Drawing.Point(4, 5);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(73, 22);
            this.labelIncome.TabIndex = 4;
            this.labelIncome.Text = "Income";
            this.labelIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelExpense
            // 
            this.panelExpense.AutoSize = true;
            this.panelExpense.Controls.Add(this.btnExDelete);
            this.panelExpense.Controls.Add(this.btnExEdit);
            this.panelExpense.Controls.Add(this.labelExpense);
            this.panelExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExpense.Location = new System.Drawing.Point(553, 176);
            this.panelExpense.Name = "panelExpense";
            this.panelExpense.Size = new System.Drawing.Size(346, 32);
            this.panelExpense.TabIndex = 10;
            // 
            // btnExDelete
            // 
            this.btnExDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExDelete.AutoSize = true;
            this.btnExDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnExDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnExDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExDelete.BorderRadius = 3;
            this.btnExDelete.BorderSize = 2;
            this.btnExDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExDelete.FlatAppearance.BorderSize = 0;
            this.btnExDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExDelete.Location = new System.Drawing.Point(276, 2);
            this.btnExDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnExDelete.Name = "btnExDelete";
            this.btnExDelete.Size = new System.Drawing.Size(70, 30);
            this.btnExDelete.TabIndex = 6;
            this.btnExDelete.Text = "DELETE";
            this.btnExDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExDelete.UseVisualStyleBackColor = false;
            this.btnExDelete.Click += new System.EventHandler(this.btnExDelete_Click);
            // 
            // btnExEdit
            // 
            this.btnExEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExEdit.AutoSize = true;
            this.btnExEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnExEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnExEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnExEdit.BorderRadius = 3;
            this.btnExEdit.BorderSize = 2;
            this.btnExEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExEdit.FlatAppearance.BorderSize = 0;
            this.btnExEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnExEdit.Location = new System.Drawing.Point(206, 2);
            this.btnExEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExEdit.Name = "btnExEdit";
            this.btnExEdit.Size = new System.Drawing.Size(70, 30);
            this.btnExEdit.TabIndex = 5;
            this.btnExEdit.Text = "UPDATE";
            this.btnExEdit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnExEdit.UseVisualStyleBackColor = false;
            this.btnExEdit.Click += new System.EventHandler(this.btnExEdit_Click);
            // 
            // labelExpense
            // 
            this.labelExpense.AutoSize = true;
            this.labelExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelExpense.Location = new System.Drawing.Point(4, 5);
            this.labelExpense.Name = "labelExpense";
            this.labelExpense.Size = new System.Drawing.Size(87, 22);
            this.labelExpense.TabIndex = 4;
            this.labelExpense.Text = "Expense";
            this.labelExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvExpense
            // 
            this.dgvExpense.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpense.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpense.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.dgvExpense.Location = new System.Drawing.Point(553, 214);
            this.dgvExpense.Name = "dgvExpense";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpense.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpense.RowHeadersWidth = 51;
            this.dgvExpense.RowTemplate.Height = 24;
            this.dgvExpense.Size = new System.Drawing.Size(346, 225);
            this.dgvExpense.TabIndex = 6;
            this.dgvExpense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellClick);
            // 
            // btnNewCat
            // 
            this.btnNewCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnNewCat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnNewCat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnNewCat.BorderRadius = 1;
            this.btnNewCat.BorderSize = 0;
            this.btnNewCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewCat.FlatAppearance.BorderSize = 0;
            this.btnNewCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNewCat.ForeColor = System.Drawing.Color.White;
            this.btnNewCat.Location = new System.Drawing.Point(624, 62);
            this.btnNewCat.Name = "btnNewCat";
            this.btnNewCat.Size = new System.Drawing.Size(275, 51);
            this.btnNewCat.TabIndex = 2;
            this.btnNewCat.Text = "+ New Category";
            this.btnNewCat.TextColor = System.Drawing.Color.White;
            this.btnNewCat.UseVisualStyleBackColor = false;
            this.btnNewCat.Click += new System.EventHandler(this.btnNewCat_Click);
            // 
            // dgvIncome
            // 
            this.dgvIncome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncome.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.dgvIncome.Location = new System.Drawing.Point(131, 214);
            this.dgvIncome.Name = "dgvIncome";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncome.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIncome.RowHeadersWidth = 51;
            this.dgvIncome.RowTemplate.Height = 24;
            this.dgvIncome.Size = new System.Drawing.Size(346, 225);
            this.dgvIncome.TabIndex = 5;
            this.dgvIncome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncome_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.txtINIcon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtINName, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(131, 445);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 43);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // txtINIcon
            // 
            this.txtINIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtINIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtINIcon.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtINIcon.BorderRadius = 3;
            this.txtINIcon.BorderSize = 1;
            this.txtINIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtINIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtINIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtINIcon.Location = new System.Drawing.Point(3, 4);
            this.txtINIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtINIcon.Multiline = false;
            this.txtINIcon.Name = "txtINIcon";
            this.txtINIcon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtINIcon.PasswordChar = false;
            this.txtINIcon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtINIcon.PlaceholderText = "";
            this.txtINIcon.Size = new System.Drawing.Size(132, 35);
            this.txtINIcon.TabIndex = 3;
            this.txtINIcon.Texts = "";
            this.txtINIcon.UnderlinedStyle = false;
            // 
            // txtINName
            // 
            this.txtINName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtINName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtINName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtINName.BorderRadius = 3;
            this.txtINName.BorderSize = 1;
            this.txtINName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtINName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtINName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtINName.Location = new System.Drawing.Point(141, 4);
            this.txtINName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtINName.Multiline = false;
            this.txtINName.Name = "txtINName";
            this.txtINName.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.txtINName.PasswordChar = false;
            this.txtINName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtINName.PlaceholderText = "";
            this.txtINName.Size = new System.Drawing.Size(202, 26);
            this.txtINName.TabIndex = 2;
            this.txtINName.Texts = "";
            this.txtINName.UnderlinedStyle = false;
            // 
            // CategoryMain
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
            this.Name = "CategoryMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Tracker - Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryMain_FormClosing);
            this.Load += new System.EventHandler(this.CategoryMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelIncome.ResumeLayout(false);
            this.panelIncome.PerformLayout();
            this.panelExpense.ResumeLayout(false);
            this.panelExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.PictureBox iconTrans;
        private System.Windows.Forms.PictureBox iconCat;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.TableLayoutPanel panelMenu;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UI.UI_button btnNewCat;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.Panel panelIncome;
        private UI.UI_button btnInDelete;
        private UI.UI_button btnInEdit;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Panel panelExpense;
        private UI.UI_button btnExDelete;
        private UI.UI_button btnExEdit;
        private System.Windows.Forms.Label labelExpense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private UI.UI_textbox txtEXIcon;
        private UI.UI_textbox txtEXName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UI.UI_textbox txtINIcon;
        private UI.UI_textbox txtINName;
    }
}