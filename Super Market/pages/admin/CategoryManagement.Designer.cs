namespace Super_Market.pages
{
    partial class CategoryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagement));
            this.productTableAdapter = new Super_Market.Super_MarketDataSetTableAdapters.ProductTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_MarketDataSet = new Super_Market.Super_MarketDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deletePage = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshBtn3 = new System.Windows.Forms.Button();
            this.deleteCategoryIdInput = new System.Windows.Forms.TextBox();
            this.deleteCategoryIdLabel = new System.Windows.Forms.Label();
            this.CategoryManagementTitle = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateCategoryNameInput = new System.Windows.Forms.TextBox();
            this.updateCategoryNameLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.refreshBtn2 = new System.Windows.Forms.Button();
            this.updateCategoryIdInput = new System.Windows.Forms.TextBox();
            this.updateCategoryIdLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPage = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.refreshBtn1 = new System.Windows.Forms.Button();
            this.addCategoryNameInput = new System.Windows.Forms.TextBox();
            this.addCategoryIdInput = new System.Windows.Forms.TextBox();
            this.addCategoryNameLabel = new System.Windows.Forms.Label();
            this.addCategoryIdLabel = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.menuBtn = new System.Windows.Forms.Button();
            this.categoryTableAdapter = new Super_Market.Super_MarketDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.deletePage.SuspendLayout();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.categoryBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(566, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(876, 549);
            this.dataGridView3.TabIndex = 0;
            // 
            // categoryIDDataGridViewTextBoxColumn2
            // 
            this.categoryIDDataGridViewTextBoxColumn2.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn2.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn2.Name = "categoryIDDataGridViewTextBoxColumn2";
            this.categoryIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Width = 125;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.super_MarketDataSet;
            // 
            // super_MarketDataSet
            // 
            this.super_MarketDataSet.DataSetName = "Super_MarketDataSet";
            this.super_MarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.super_MarketDataSet;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Controls.Add(this.refreshBtn3);
            this.deletePage.Controls.Add(this.deleteCategoryIdInput);
            this.deletePage.Controls.Add(this.deleteCategoryIdLabel);
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1448, 555);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Category";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(275, 289);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(217, 61);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete Category";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn3
            // 
            this.refreshBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn3.Location = new System.Drawing.Point(52, 289);
            this.refreshBtn3.Name = "refreshBtn3";
            this.refreshBtn3.Size = new System.Drawing.Size(217, 61);
            this.refreshBtn3.TabIndex = 6;
            this.refreshBtn3.Text = "Refresh Table";
            this.refreshBtn3.UseVisualStyleBackColor = true;
            this.refreshBtn3.Click += new System.EventHandler(this.refreshBtn3_Click);
            // 
            // deleteCategoryIdInput
            // 
            this.deleteCategoryIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteCategoryIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryIdInput.Location = new System.Drawing.Point(52, 96);
            this.deleteCategoryIdInput.Name = "deleteCategoryIdInput";
            this.deleteCategoryIdInput.Size = new System.Drawing.Size(442, 30);
            this.deleteCategoryIdInput.TabIndex = 5;
            this.deleteCategoryIdInput.TextChanged += new System.EventHandler(this.deleteCategoryIdInput_TextChanged);
            // 
            // deleteCategoryIdLabel
            // 
            this.deleteCategoryIdLabel.AutoSize = true;
            this.deleteCategoryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryIdLabel.Location = new System.Drawing.Point(47, 64);
            this.deleteCategoryIdLabel.Name = "deleteCategoryIdLabel";
            this.deleteCategoryIdLabel.Size = new System.Drawing.Size(157, 29);
            this.deleteCategoryIdLabel.TabIndex = 4;
            this.deleteCategoryIdLabel.Text = "Category ID:";
            // 
            // CategoryManagementTitle
            // 
            this.CategoryManagementTitle.AutoSize = true;
            this.CategoryManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryManagementTitle.Location = new System.Drawing.Point(478, 27);
            this.CategoryManagementTitle.Name = "CategoryManagementTitle";
            this.CategoryManagementTitle.Size = new System.Drawing.Size(479, 51);
            this.CategoryManagementTitle.TabIndex = 20;
            this.CategoryManagementTitle.Text = "Category Management";
            this.CategoryManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.searchBtn);
            this.updatePage.Controls.Add(this.updateCategoryNameInput);
            this.updatePage.Controls.Add(this.updateCategoryNameLabel);
            this.updatePage.Controls.Add(this.updateBtn);
            this.updatePage.Controls.Add(this.refreshBtn2);
            this.updatePage.Controls.Add(this.updateCategoryIdInput);
            this.updatePage.Controls.Add(this.updateCategoryIdLabel);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1448, 555);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Category";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(369, 92);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(131, 39);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateCategoryNameInput
            // 
            this.updateCategoryNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateCategoryNameInput.Enabled = false;
            this.updateCategoryNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryNameInput.Location = new System.Drawing.Point(58, 226);
            this.updateCategoryNameInput.Name = "updateCategoryNameInput";
            this.updateCategoryNameInput.Size = new System.Drawing.Size(442, 30);
            this.updateCategoryNameInput.TabIndex = 9;
            this.updateCategoryNameInput.TextChanged += new System.EventHandler(this.updateCategoryNameInput_TextChanged);
            // 
            // updateCategoryNameLabel
            // 
            this.updateCategoryNameLabel.AutoSize = true;
            this.updateCategoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryNameLabel.Location = new System.Drawing.Point(53, 194);
            this.updateCategoryNameLabel.Name = "updateCategoryNameLabel";
            this.updateCategoryNameLabel.Size = new System.Drawing.Size(201, 29);
            this.updateCategoryNameLabel.TabIndex = 8;
            this.updateCategoryNameLabel.Text = "Category Name:";
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(283, 338);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(217, 61);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update Category";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // refreshBtn2
            // 
            this.refreshBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn2.Location = new System.Drawing.Point(58, 338);
            this.refreshBtn2.Name = "refreshBtn2";
            this.refreshBtn2.Size = new System.Drawing.Size(217, 61);
            this.refreshBtn2.TabIndex = 6;
            this.refreshBtn2.Text = "Refresh Table";
            this.refreshBtn2.UseVisualStyleBackColor = true;
            this.refreshBtn2.Click += new System.EventHandler(this.refreshBtn2_Click);
            // 
            // updateCategoryIdInput
            // 
            this.updateCategoryIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateCategoryIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryIdInput.Location = new System.Drawing.Point(58, 97);
            this.updateCategoryIdInput.Name = "updateCategoryIdInput";
            this.updateCategoryIdInput.Size = new System.Drawing.Size(305, 30);
            this.updateCategoryIdInput.TabIndex = 5;
            this.updateCategoryIdInput.TextChanged += new System.EventHandler(this.updateCategoryIdInput_TextChanged);
            // 
            // updateCategoryIdLabel
            // 
            this.updateCategoryIdLabel.AutoSize = true;
            this.updateCategoryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryIdLabel.Location = new System.Drawing.Point(53, 65);
            this.updateCategoryIdLabel.Name = "updateCategoryIdLabel";
            this.updateCategoryIdLabel.Size = new System.Drawing.Size(157, 29);
            this.updateCategoryIdLabel.TabIndex = 4;
            this.updateCategoryIdLabel.Text = "Category ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.categoryBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(566, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(876, 549);
            this.dataGridView2.TabIndex = 0;
            // 
            // categoryIDDataGridViewTextBoxColumn1
            // 
            this.categoryIDDataGridViewTextBoxColumn1.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn1.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn1.Name = "categoryIDDataGridViewTextBoxColumn1";
            this.categoryIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(566, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.addBtn);
            this.addPage.Controls.Add(this.refreshBtn1);
            this.addPage.Controls.Add(this.addCategoryNameInput);
            this.addPage.Controls.Add(this.addCategoryIdInput);
            this.addPage.Controls.Add(this.addCategoryNameLabel);
            this.addPage.Controls.Add(this.addCategoryIdLabel);
            this.addPage.Controls.Add(this.dataGridView1);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(1448, 555);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Add Category";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(280, 336);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(217, 61);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Category";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // refreshBtn1
            // 
            this.refreshBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn1.Location = new System.Drawing.Point(55, 336);
            this.refreshBtn1.Name = "refreshBtn1";
            this.refreshBtn1.Size = new System.Drawing.Size(219, 61);
            this.refreshBtn1.TabIndex = 5;
            this.refreshBtn1.Text = "Refresh Table";
            this.refreshBtn1.UseVisualStyleBackColor = true;
            this.refreshBtn1.Click += new System.EventHandler(this.refreshBtn1_Click);
            // 
            // addCategoryNameInput
            // 
            this.addCategoryNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCategoryNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryNameInput.Location = new System.Drawing.Point(55, 216);
            this.addCategoryNameInput.Name = "addCategoryNameInput";
            this.addCategoryNameInput.Size = new System.Drawing.Size(442, 30);
            this.addCategoryNameInput.TabIndex = 4;
            this.addCategoryNameInput.TextChanged += new System.EventHandler(this.addCategoryNameInput_TextChanged);
            // 
            // addCategoryIdInput
            // 
            this.addCategoryIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCategoryIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryIdInput.Location = new System.Drawing.Point(55, 94);
            this.addCategoryIdInput.Name = "addCategoryIdInput";
            this.addCategoryIdInput.Size = new System.Drawing.Size(442, 30);
            this.addCategoryIdInput.TabIndex = 3;
            this.addCategoryIdInput.TextChanged += new System.EventHandler(this.addCategoryIdInput_TextChanged);
            // 
            // addCategoryNameLabel
            // 
            this.addCategoryNameLabel.AutoSize = true;
            this.addCategoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryNameLabel.Location = new System.Drawing.Point(50, 184);
            this.addCategoryNameLabel.Name = "addCategoryNameLabel";
            this.addCategoryNameLabel.Size = new System.Drawing.Size(201, 29);
            this.addCategoryNameLabel.TabIndex = 2;
            this.addCategoryNameLabel.Text = "Category Name:";
            // 
            // addCategoryIdLabel
            // 
            this.addCategoryIdLabel.AutoSize = true;
            this.addCategoryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryIdLabel.Location = new System.Drawing.Point(50, 62);
            this.addCategoryIdLabel.Name = "addCategoryIdLabel";
            this.addCategoryIdLabel.Size = new System.Drawing.Size(157, 29);
            this.addCategoryIdLabel.TabIndex = 1;
            this.addCategoryIdLabel.Text = "Category ID:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.addPage);
            this.TabControl.Controls.Add(this.updatePage);
            this.TabControl.Controls.Add(this.deletePage);
            this.TabControl.Location = new System.Drawing.Point(13, 81);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1456, 584);
            this.TabControl.TabIndex = 21;
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(13, 671);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1452, 54);
            this.menuBtn.TabIndex = 22;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.CategoryManagementTitle);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Super_MarketDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Super_MarketDataSet super_MarketDataSet;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Label CategoryManagementTitle;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Super_MarketDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Label addCategoryNameLabel;
        private System.Windows.Forms.Label addCategoryIdLabel;
        private System.Windows.Forms.TextBox addCategoryNameInput;
        private System.Windows.Forms.TextBox addCategoryIdInput;
        private System.Windows.Forms.TextBox deleteCategoryIdInput;
        private System.Windows.Forms.Label deleteCategoryIdLabel;
        private System.Windows.Forms.TextBox updateCategoryIdInput;
        private System.Windows.Forms.Label updateCategoryIdLabel;
        private System.Windows.Forms.Button refreshBtn3;
        private System.Windows.Forms.Button refreshBtn2;
        private System.Windows.Forms.Button refreshBtn1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox updateCategoryNameInput;
        private System.Windows.Forms.Label updateCategoryNameLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}