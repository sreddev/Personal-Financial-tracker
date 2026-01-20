namespace ExpenseTracker
{
    partial class TransactionMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionMain));
            this.dgvTrans = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.btnDelete = new ExpenseTracker.UI.UI_button();
            this.btnUpdate = new ExpenseTracker.UI.UI_button();
            this.btnNewTrans = new ExpenseTracker.UI.UI_button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numTransAmount = new ExpenseTracker.UI.UI_numericUpDown();
            this.comboTransCat = new ExpenseTracker.UI.UI_comboBox();
            this.txtTransTitle = new ExpenseTracker.UI.UI_textbox();
            this.dateTrans = new ExpenseTracker.UI.UI_DateTimePicker();
            this.panelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.iconTrans = new System.Windows.Forms.PictureBox();
            this.iconCat = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.logoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrans)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelIncome.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransAmount)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrans
            // 
            this.dgvTrans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvTrans, 3);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrans.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(22)))));
            this.dgvTrans.Location = new System.Drawing.Point(131, 213);
            this.dgvTrans.Name = "dgvTrans";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrans.RowHeadersWidth = 51;
            this.dgvTrans.RowTemplate.Height = 24;
            this.dgvTrans.Size = new System.Drawing.Size(768, 222);
            this.dgvTrans.TabIndex = 5;
            this.dgvTrans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrans_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.15301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.830603F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43169F));
            this.tableLayoutPanel1.Controls.Add(this.panelIncome, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNewTrans, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvTrans, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77877F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77877F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 553);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panelIncome
            // 
            this.panelIncome.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panelIncome, 3);
            this.panelIncome.Controls.Add(this.btnDelete);
            this.panelIncome.Controls.Add(this.btnUpdate);
            this.panelIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIncome.Location = new System.Drawing.Point(131, 175);
            this.panelIncome.Name = "panelIncome";
            this.panelIncome.Size = new System.Drawing.Size(768, 32);
            this.panelIncome.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.BorderRadius = 3;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Location = new System.Drawing.Point(698, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnUpdate.BorderRadius = 3;
            this.btnUpdate.BorderSize = 2;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnUpdate.Location = new System.Drawing.Point(628, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewTrans
            // 
            this.btnNewTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnNewTrans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnNewTrans.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnNewTrans.BorderRadius = 3;
            this.btnNewTrans.BorderSize = 0;
            this.btnNewTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTrans.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewTrans.FlatAppearance.BorderSize = 0;
            this.btnNewTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNewTrans.ForeColor = System.Drawing.Color.White;
            this.btnNewTrans.Location = new System.Drawing.Point(624, 61);
            this.btnNewTrans.Name = "btnNewTrans";
            this.btnNewTrans.Size = new System.Drawing.Size(275, 51);
            this.btnNewTrans.TabIndex = 2;
            this.btnNewTrans.Text = "+ New Transaction";
            this.btnNewTrans.TextColor = System.Drawing.Color.White;
            this.btnNewTrans.UseVisualStyleBackColor = false;
            this.btnNewTrans.Click += new System.EventHandler(this.btnNewTrans_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCategory, 2);
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(131, 58);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(416, 57);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Transaction";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.numTransAmount, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboTransCat, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTransTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTrans, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(131, 441);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(768, 48);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // numTransAmount
            // 
            this.numTransAmount.AutoSize = true;
            this.numTransAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.numTransAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.numTransAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTransAmount.ButtonHighlightColor = System.Drawing.Color.Empty;
            this.numTransAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numTransAmount.DecimalPlaces = 2;
            this.numTransAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTransAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTransAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.numTransAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTransAmount.Location = new System.Drawing.Point(591, 8);
            this.numTransAmount.Margin = new System.Windows.Forms.Padding(15, 8, 3, 3);
            this.numTransAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTransAmount.Name = "numTransAmount";
            this.numTransAmount.Size = new System.Drawing.Size(174, 22);
            this.numTransAmount.TabIndex = 5;
            this.numTransAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTransAmount.ThousandsSeparator = true;
            // 
            // comboTransCat
            // 
            this.comboTransCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.comboTransCat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.comboTransCat.BorderSize = 1;
            this.comboTransCat.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboTransCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboTransCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboTransCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.comboTransCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.comboTransCat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.comboTransCat.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            this.comboTransCat.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.comboTransCat.Location = new System.Drawing.Point(387, 6);
            this.comboTransCat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 10);
            this.comboTransCat.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboTransCat.Name = "comboTransCat";
            this.comboTransCat.Padding = new System.Windows.Forms.Padding(1);
            this.comboTransCat.Size = new System.Drawing.Size(200, 32);
            this.comboTransCat.TabIndex = 4;
            this.comboTransCat.Texts = "";
            // 
            // txtTransTitle
            // 
            this.txtTransTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.txtTransTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.txtTransTitle.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.txtTransTitle.BorderRadius = 3;
            this.txtTransTitle.BorderSize = 1;
            this.txtTransTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTransTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtTransTitle.Location = new System.Drawing.Point(195, 4);
            this.txtTransTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTransTitle.Multiline = false;
            this.txtTransTitle.Name = "txtTransTitle";
            this.txtTransTitle.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.txtTransTitle.PasswordChar = false;
            this.txtTransTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTransTitle.PlaceholderText = "";
            this.txtTransTitle.Size = new System.Drawing.Size(186, 25);
            this.txtTransTitle.TabIndex = 3;
            this.txtTransTitle.Texts = "";
            this.txtTransTitle.UnderlinedStyle = false;
            // 
            // dateTrans
            // 
            this.dateTrans.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.dateTrans.BorderSize = 1;
            this.dateTrans.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTrans.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTrans.Location = new System.Drawing.Point(3, 3);
            this.dateTrans.MinimumSize = new System.Drawing.Size(0, 35);
            this.dateTrans.Name = "dateTrans";
            this.dateTrans.Size = new System.Drawing.Size(186, 35);
            this.dateTrans.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.dateTrans.TabIndex = 2;
            this.dateTrans.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
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
            this.panelMenu.TabIndex = 4;
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
            this.iconTrans.Image = global::ExpenseTracker.Properties.Resources.transaction_active;
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
            // TransactionMain
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
            this.Name = "TransactionMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Tracker - Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionMain_FormClosing);
            this.Load += new System.EventHandler(this.TransactionMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrans)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelIncome.ResumeLayout(false);
            this.panelIncome.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransAmount)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UI.UI_button btnNewTrans;
        private System.Windows.Forms.DataGridView dgvTrans;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TableLayoutPanel panelMenu;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.PictureBox iconTrans;
        private System.Windows.Forms.PictureBox iconCat;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Panel panelIncome;
        private UI.UI_button btnDelete;
        private UI.UI_button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UI.UI_DateTimePicker dateTrans;
        private UI.UI_textbox txtTransTitle;
        private UI.UI_comboBox comboTransCat;
        private UI.UI_numericUpDown numTransAmount;
    }
}