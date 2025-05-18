namespace Super_Market.pages.admin
{
    partial class CompanyManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyManagement));
            this.menuBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteCompanyIdInput = new System.Windows.Forms.TextBox();
            this.deleteCompanyIdLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.updateCompanyCategoryLabel = new System.Windows.Forms.Label();
            this.updateCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.updateCompanyIdInput = new System.Windows.Forms.TextBox();
            this.updateCompanyIdLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.updateCountryLabel = new System.Windows.Forms.Label();
            this.updateCountryComboBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateCompanyNameInput = new System.Windows.Forms.TextBox();
            this.updateCompanyNameLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.CompanyManagementTitle = new System.Windows.Forms.Label();
            this.addCompanyCategoryLabel = new System.Windows.Forms.Label();
            this.addPage = new System.Windows.Forms.TabPage();
            this.addCountryLabel = new System.Windows.Forms.Label();
            this.addCountryComboBox = new System.Windows.Forms.ComboBox();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_Market_DataSet1 = new Super_Market.Super_Market_DataSet();
            this.addBtn = new System.Windows.Forms.Button();
            this.addCompanyNameInput = new System.Windows.Forms.TextBox();
            this.addCompanyIdInput = new System.Windows.Forms.TextBox();
            this.addCompanyNameLabel = new System.Windows.Forms.Label();
            this.addCompanyIdLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.cATEGORYTableAdapter1 = new Super_Market.Super_Market_DataSetTableAdapters.CATEGORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.deletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.updatePage.SuspendLayout();
            this.addPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_Market_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(13, 729);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1452, 54);
            this.menuBtn.TabIndex = 28;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(53, 336);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(442, 61);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete Company";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deleteCompanyIdInput
            // 
            this.deleteCompanyIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteCompanyIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCompanyIdInput.Location = new System.Drawing.Point(53, 229);
            this.deleteCompanyIdInput.Name = "deleteCompanyIdInput";
            this.deleteCompanyIdInput.Size = new System.Drawing.Size(442, 30);
            this.deleteCompanyIdInput.TabIndex = 5;
            // 
            // deleteCompanyIdLabel
            // 
            this.deleteCompanyIdLabel.AutoSize = true;
            this.deleteCompanyIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCompanyIdLabel.Location = new System.Drawing.Point(48, 197);
            this.deleteCompanyIdLabel.Name = "deleteCompanyIdLabel";
            this.deleteCompanyIdLabel.Size = new System.Drawing.Size(161, 29);
            this.deleteCompanyIdLabel.TabIndex = 4;
            this.deleteCompanyIdLabel.Text = "Company ID:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(566, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(876, 612);
            this.dataGridView3.TabIndex = 0;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Controls.Add(this.deleteCompanyIdInput);
            this.deletePage.Controls.Add(this.deleteCompanyIdLabel);
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1448, 621);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Company";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // updateCompanyCategoryLabel
            // 
            this.updateCompanyCategoryLabel.AutoSize = true;
            this.updateCompanyCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCompanyCategoryLabel.Location = new System.Drawing.Point(53, 292);
            this.updateCompanyCategoryLabel.Name = "updateCompanyCategoryLabel";
            this.updateCompanyCategoryLabel.Size = new System.Drawing.Size(201, 29);
            this.updateCompanyCategoryLabel.TabIndex = 28;
            this.updateCompanyCategoryLabel.Text = "Category Name:";
            // 
            // updateCategorycomboBox
            // 
            this.updateCategorycomboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateCategorycomboBox.DataSource = this.cATEGORYBindingSource;
            this.updateCategorycomboBox.DisplayMember = "NAME";
            this.updateCategorycomboBox.DropDownHeight = 200;
            this.updateCategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateCategorycomboBox.Enabled = false;
            this.updateCategorycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategorycomboBox.FormattingEnabled = true;
            this.updateCategorycomboBox.IntegralHeight = false;
            this.updateCategorycomboBox.Location = new System.Drawing.Point(58, 324);
            this.updateCategorycomboBox.MaxDropDownItems = 5;
            this.updateCategorycomboBox.Name = "updateCategorycomboBox";
            this.updateCategorycomboBox.Size = new System.Drawing.Size(440, 33);
            this.updateCategorycomboBox.TabIndex = 27;
            this.updateCategorycomboBox.ValueMember = "CID";
            // 
            // updateCompanyIdInput
            // 
            this.updateCompanyIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateCompanyIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCompanyIdInput.Location = new System.Drawing.Point(58, 147);
            this.updateCompanyIdInput.Name = "updateCompanyIdInput";
            this.updateCompanyIdInput.Size = new System.Drawing.Size(305, 30);
            this.updateCompanyIdInput.TabIndex = 5;
            // 
            // updateCompanyIdLabel
            // 
            this.updateCompanyIdLabel.AutoSize = true;
            this.updateCompanyIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCompanyIdLabel.Location = new System.Drawing.Point(53, 115);
            this.updateCompanyIdLabel.Name = "updateCompanyIdLabel";
            this.updateCompanyIdLabel.Size = new System.Drawing.Size(161, 29);
            this.updateCompanyIdLabel.TabIndex = 4;
            this.updateCompanyIdLabel.Text = "Company ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(566, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(876, 612);
            this.dataGridView2.TabIndex = 0;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.updateCountryLabel);
            this.updatePage.Controls.Add(this.updateCountryComboBox);
            this.updatePage.Controls.Add(this.updateCompanyCategoryLabel);
            this.updatePage.Controls.Add(this.updateCategorycomboBox);
            this.updatePage.Controls.Add(this.searchBtn);
            this.updatePage.Controls.Add(this.updateCompanyNameInput);
            this.updatePage.Controls.Add(this.updateCompanyNameLabel);
            this.updatePage.Controls.Add(this.updateBtn);
            this.updatePage.Controls.Add(this.updateCompanyIdInput);
            this.updatePage.Controls.Add(this.updateCompanyIdLabel);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1448, 621);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Company";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // updateCountryLabel
            // 
            this.updateCountryLabel.AutoSize = true;
            this.updateCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCountryLabel.Location = new System.Drawing.Point(53, 373);
            this.updateCountryLabel.Name = "updateCountryLabel";
            this.updateCountryLabel.Size = new System.Drawing.Size(185, 29);
            this.updateCountryLabel.TabIndex = 30;
            this.updateCountryLabel.Text = "Country Name:";
            // 
            // updateCountryComboBox
            // 
            this.updateCountryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateCountryComboBox.DropDownHeight = 200;
            this.updateCountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateCountryComboBox.Enabled = false;
            this.updateCountryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCountryComboBox.FormattingEnabled = true;
            this.updateCountryComboBox.IntegralHeight = false;
            this.updateCountryComboBox.Location = new System.Drawing.Point(58, 405);
            this.updateCountryComboBox.MaxDropDownItems = 5;
            this.updateCountryComboBox.Name = "updateCountryComboBox";
            this.updateCountryComboBox.Size = new System.Drawing.Size(440, 33);
            this.updateCountryComboBox.TabIndex = 29;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(369, 142);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(131, 39);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateCompanyNameInput
            // 
            this.updateCompanyNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateCompanyNameInput.Enabled = false;
            this.updateCompanyNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCompanyNameInput.Location = new System.Drawing.Point(58, 241);
            this.updateCompanyNameInput.Name = "updateCompanyNameInput";
            this.updateCompanyNameInput.Size = new System.Drawing.Size(442, 30);
            this.updateCompanyNameInput.TabIndex = 9;
            // 
            // updateCompanyNameLabel
            // 
            this.updateCompanyNameLabel.AutoSize = true;
            this.updateCompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCompanyNameLabel.Location = new System.Drawing.Point(53, 209);
            this.updateCompanyNameLabel.Name = "updateCompanyNameLabel";
            this.updateCompanyNameLabel.Size = new System.Drawing.Size(205, 29);
            this.updateCompanyNameLabel.TabIndex = 8;
            this.updateCompanyNameLabel.Text = "Company Name:";
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(58, 482);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(442, 61);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update Company";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // CompanyManagementTitle
            // 
            this.CompanyManagementTitle.AutoSize = true;
            this.CompanyManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyManagementTitle.Location = new System.Drawing.Point(478, 19);
            this.CompanyManagementTitle.Name = "CompanyManagementTitle";
            this.CompanyManagementTitle.Size = new System.Drawing.Size(488, 51);
            this.CompanyManagementTitle.TabIndex = 26;
            this.CompanyManagementTitle.Text = "Company Management";
            this.CompanyManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCompanyCategoryLabel
            // 
            this.addCompanyCategoryLabel.AutoSize = true;
            this.addCompanyCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompanyCategoryLabel.Location = new System.Drawing.Point(52, 287);
            this.addCompanyCategoryLabel.Name = "addCompanyCategoryLabel";
            this.addCompanyCategoryLabel.Size = new System.Drawing.Size(201, 29);
            this.addCompanyCategoryLabel.TabIndex = 26;
            this.addCompanyCategoryLabel.Text = "Category Name:";
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.addCountryLabel);
            this.addPage.Controls.Add(this.addCountryComboBox);
            this.addPage.Controls.Add(this.addCompanyCategoryLabel);
            this.addPage.Controls.Add(this.addCategoryComboBox);
            this.addPage.Controls.Add(this.addBtn);
            this.addPage.Controls.Add(this.addCompanyNameInput);
            this.addPage.Controls.Add(this.addCompanyIdInput);
            this.addPage.Controls.Add(this.addCompanyNameLabel);
            this.addPage.Controls.Add(this.addCompanyIdLabel);
            this.addPage.Controls.Add(this.dataGridView1);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(1448, 621);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Add Company";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // addCountryLabel
            // 
            this.addCountryLabel.AutoSize = true;
            this.addCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCountryLabel.Location = new System.Drawing.Point(52, 378);
            this.addCountryLabel.Name = "addCountryLabel";
            this.addCountryLabel.Size = new System.Drawing.Size(185, 29);
            this.addCountryLabel.TabIndex = 28;
            this.addCountryLabel.Text = "Country Name:";
            // 
            // addCountryComboBox
            // 
            this.addCountryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addCountryComboBox.DropDownHeight = 200;
            this.addCountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCountryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCountryComboBox.FormattingEnabled = true;
            this.addCountryComboBox.IntegralHeight = false;
            this.addCountryComboBox.Location = new System.Drawing.Point(57, 410);
            this.addCountryComboBox.MaxDropDownItems = 5;
            this.addCountryComboBox.Name = "addCountryComboBox";
            this.addCountryComboBox.Size = new System.Drawing.Size(442, 33);
            this.addCountryComboBox.Sorted = true;
            this.addCountryComboBox.TabIndex = 27;
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addCategoryComboBox.DataSource = this.cATEGORYBindingSource;
            this.addCategoryComboBox.DisplayMember = "NAME";
            this.addCategoryComboBox.DropDownHeight = 200;
            this.addCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryComboBox.FormattingEnabled = true;
            this.addCategoryComboBox.IntegralHeight = false;
            this.addCategoryComboBox.Location = new System.Drawing.Point(57, 319);
            this.addCategoryComboBox.MaxDropDownItems = 5;
            this.addCategoryComboBox.Name = "addCategoryComboBox";
            this.addCategoryComboBox.Size = new System.Drawing.Size(440, 33);
            this.addCategoryComboBox.TabIndex = 25;
            this.addCategoryComboBox.ValueMember = "CID";
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.super_Market_DataSet1;
            // 
            // super_Market_DataSet1
            // 
            this.super_Market_DataSet1.DataSetName = "Super_Market_DataSet";
            this.super_Market_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(57, 475);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(442, 61);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Company";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addCompanyNameInput
            // 
            this.addCompanyNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCompanyNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompanyNameInput.Location = new System.Drawing.Point(57, 230);
            this.addCompanyNameInput.Name = "addCompanyNameInput";
            this.addCompanyNameInput.Size = new System.Drawing.Size(442, 30);
            this.addCompanyNameInput.TabIndex = 4;
            // 
            // addCompanyIdInput
            // 
            this.addCompanyIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCompanyIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompanyIdInput.Location = new System.Drawing.Point(57, 140);
            this.addCompanyIdInput.Name = "addCompanyIdInput";
            this.addCompanyIdInput.Size = new System.Drawing.Size(442, 30);
            this.addCompanyIdInput.TabIndex = 3;
            // 
            // addCompanyNameLabel
            // 
            this.addCompanyNameLabel.AutoSize = true;
            this.addCompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompanyNameLabel.Location = new System.Drawing.Point(52, 198);
            this.addCompanyNameLabel.Name = "addCompanyNameLabel";
            this.addCompanyNameLabel.Size = new System.Drawing.Size(205, 29);
            this.addCompanyNameLabel.TabIndex = 2;
            this.addCompanyNameLabel.Text = "Company Name:";
            // 
            // addCompanyIdLabel
            // 
            this.addCompanyIdLabel.AutoSize = true;
            this.addCompanyIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompanyIdLabel.Location = new System.Drawing.Point(52, 108);
            this.addCompanyIdLabel.Name = "addCompanyIdLabel";
            this.addCompanyIdLabel.Size = new System.Drawing.Size(161, 29);
            this.addCompanyIdLabel.TabIndex = 1;
            this.addCompanyIdLabel.Text = "Company ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(566, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 612);
            this.dataGridView1.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.addPage);
            this.TabControl.Controls.Add(this.updatePage);
            this.TabControl.Controls.Add(this.deletePage);
            this.TabControl.Location = new System.Drawing.Point(13, 73);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1456, 650);
            this.TabControl.TabIndex = 27;
            // 
            // cATEGORYTableAdapter1
            // 
            this.cATEGORYTableAdapter1.ClearBeforeFill = true;
            // 
            // CompanyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.CompanyManagementTitle);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "CompanyManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.Load += new System.EventHandler(this.CompanyManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_Market_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox deleteCompanyIdInput;
        private System.Windows.Forms.Label deleteCompanyIdLabel;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Label updateCompanyCategoryLabel;
        private System.Windows.Forms.ComboBox updateCategorycomboBox;
        private System.Windows.Forms.TextBox updateCompanyIdInput;
        private System.Windows.Forms.Label updateCompanyIdLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox updateCompanyNameInput;
        private System.Windows.Forms.Label updateCompanyNameLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label CompanyManagementTitle;
        private System.Windows.Forms.Label addCompanyCategoryLabel;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.ComboBox addCategoryComboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addCompanyNameInput;
        private System.Windows.Forms.TextBox addCompanyIdInput;
        private System.Windows.Forms.Label addCompanyNameLabel;
        private System.Windows.Forms.Label addCompanyIdLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Label addCountryLabel;
        private System.Windows.Forms.ComboBox addCountryComboBox;
        private System.Windows.Forms.Label updateCountryLabel;
        private System.Windows.Forms.ComboBox updateCountryComboBox;
        private Super_Market_DataSet super_Market_DataSet1;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private Super_Market_DataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter1;
    }
}