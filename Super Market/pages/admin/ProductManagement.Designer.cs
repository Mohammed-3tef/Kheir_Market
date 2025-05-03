namespace Super_Market.pages
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.menuBtn = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.addPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_MarketDataSet = new Super_Market.Super_MarketDataSet();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.refreshBtn2 = new System.Windows.Forms.Button();
            this.updateProductIdInput = new System.Windows.Forms.TextBox();
            this.updateProductIdLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshBtn3 = new System.Windows.Forms.Button();
            this.deleteProductIdInput = new System.Windows.Forms.TextBox();
            this.deleteProductIdLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductManagementTitle = new System.Windows.Forms.Label();
            this.productTableAdapter = new Super_Market.Super_MarketDataSetTableAdapters.ProductTableAdapter();
            this.addBtn = new System.Windows.Forms.Button();
            this.refreshBtn1 = new System.Windows.Forms.Button();
            this.addProductIdInput = new System.Windows.Forms.TextBox();
            this.addProductIdLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.addPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet)).BeginInit();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.deletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(14, 671);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1452, 54);
            this.menuBtn.TabIndex = 19;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.addPage);
            this.TabControl.Controls.Add(this.updatePage);
            this.TabControl.Controls.Add(this.deletePage);
            this.TabControl.Location = new System.Drawing.Point(14, 81);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1456, 584);
            this.TabControl.TabIndex = 18;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.addBtn);
            this.addPage.Controls.Add(this.refreshBtn1);
            this.addPage.Controls.Add(this.addProductIdInput);
            this.addPage.Controls.Add(this.addProductIdLabel);
            this.addPage.Controls.Add(this.dataGridView1);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(1448, 555);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Add Product";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(566, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
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
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "Stock_Quantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "Stock_Quantity";
            this.stockQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            this.stockQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.super_MarketDataSet;
            // 
            // super_MarketDataSet
            // 
            this.super_MarketDataSet.DataSetName = "Super_MarketDataSet";
            this.super_MarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.searchBtn);
            this.updatePage.Controls.Add(this.updateBtn);
            this.updatePage.Controls.Add(this.refreshBtn2);
            this.updatePage.Controls.Add(this.updateProductIdInput);
            this.updatePage.Controls.Add(this.updateProductIdLabel);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1448, 555);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Product";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(363, 79);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(131, 39);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(277, 419);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(217, 61);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Update Product";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // refreshBtn2
            // 
            this.refreshBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn2.Location = new System.Drawing.Point(54, 419);
            this.refreshBtn2.Name = "refreshBtn2";
            this.refreshBtn2.Size = new System.Drawing.Size(217, 61);
            this.refreshBtn2.TabIndex = 14;
            this.refreshBtn2.Text = "Refresh Table";
            this.refreshBtn2.UseVisualStyleBackColor = true;
            this.refreshBtn2.Click += new System.EventHandler(this.refreshBtn2_Click);
            // 
            // updateProductIdInput
            // 
            this.updateProductIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateProductIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductIdInput.Location = new System.Drawing.Point(54, 84);
            this.updateProductIdInput.Name = "updateProductIdInput";
            this.updateProductIdInput.Size = new System.Drawing.Size(303, 30);
            this.updateProductIdInput.TabIndex = 13;
            this.updateProductIdInput.TextChanged += new System.EventHandler(this.updateProductIdInput_TextChanged);
            // 
            // updateProductIdLabel
            // 
            this.updateProductIdLabel.AutoSize = true;
            this.updateProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductIdLabel.Location = new System.Drawing.Point(49, 52);
            this.updateProductIdLabel.Name = "updateProductIdLabel";
            this.updateProductIdLabel.Size = new System.Drawing.Size(142, 29);
            this.updateProductIdLabel.TabIndex = 12;
            this.updateProductIdLabel.Text = "Product ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.categoryIDDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.stockQuantityDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.productBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(566, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(876, 549);
            this.dataGridView2.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            this.productIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn1.Width = 125;
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
            // categoryIDDataGridViewTextBoxColumn1
            // 
            this.categoryIDDataGridViewTextBoxColumn1.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn1.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn1.Name = "categoryIDDataGridViewTextBoxColumn1";
            this.categoryIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stockQuantityDataGridViewTextBoxColumn1
            // 
            this.stockQuantityDataGridViewTextBoxColumn1.DataPropertyName = "Stock_Quantity";
            this.stockQuantityDataGridViewTextBoxColumn1.HeaderText = "Stock_Quantity";
            this.stockQuantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockQuantityDataGridViewTextBoxColumn1.Name = "stockQuantityDataGridViewTextBoxColumn1";
            this.stockQuantityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stockQuantityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Controls.Add(this.refreshBtn3);
            this.deletePage.Controls.Add(this.deleteProductIdInput);
            this.deletePage.Controls.Add(this.deleteProductIdLabel);
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1448, 555);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Product";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(281, 287);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(217, 61);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete Product";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn3
            // 
            this.refreshBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn3.Location = new System.Drawing.Point(58, 287);
            this.refreshBtn3.Name = "refreshBtn3";
            this.refreshBtn3.Size = new System.Drawing.Size(217, 61);
            this.refreshBtn3.TabIndex = 10;
            this.refreshBtn3.Text = "Refresh Table";
            this.refreshBtn3.UseVisualStyleBackColor = true;
            this.refreshBtn3.Click += new System.EventHandler(this.refreshBtn3_Click);
            // 
            // deleteProductIdInput
            // 
            this.deleteProductIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteProductIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductIdInput.Location = new System.Drawing.Point(58, 94);
            this.deleteProductIdInput.Name = "deleteProductIdInput";
            this.deleteProductIdInput.Size = new System.Drawing.Size(442, 30);
            this.deleteProductIdInput.TabIndex = 9;
            this.deleteProductIdInput.TextChanged += new System.EventHandler(this.deleteProductIdInput_TextChanged);
            // 
            // deleteProductIdLabel
            // 
            this.deleteProductIdLabel.AutoSize = true;
            this.deleteProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductIdLabel.Location = new System.Drawing.Point(53, 62);
            this.deleteProductIdLabel.Name = "deleteProductIdLabel";
            this.deleteProductIdLabel.Size = new System.Drawing.Size(142, 29);
            this.deleteProductIdLabel.TabIndex = 8;
            this.deleteProductIdLabel.Text = "Product ID:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.categoryIDDataGridViewTextBoxColumn2,
            this.priceDataGridViewTextBoxColumn2,
            this.stockQuantityDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.productBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(566, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(876, 549);
            this.dataGridView3.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn2
            // 
            this.productIDDataGridViewTextBoxColumn2.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn2.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn2.Name = "productIDDataGridViewTextBoxColumn2";
            this.productIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn2.Width = 125;
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
            // categoryIDDataGridViewTextBoxColumn2
            // 
            this.categoryIDDataGridViewTextBoxColumn2.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn2.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.categoryIDDataGridViewTextBoxColumn2.Name = "categoryIDDataGridViewTextBoxColumn2";
            this.categoryIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn2.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn2.Width = 125;
            // 
            // stockQuantityDataGridViewTextBoxColumn2
            // 
            this.stockQuantityDataGridViewTextBoxColumn2.DataPropertyName = "Stock_Quantity";
            this.stockQuantityDataGridViewTextBoxColumn2.HeaderText = "Stock_Quantity";
            this.stockQuantityDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.stockQuantityDataGridViewTextBoxColumn2.Name = "stockQuantityDataGridViewTextBoxColumn2";
            this.stockQuantityDataGridViewTextBoxColumn2.ReadOnly = true;
            this.stockQuantityDataGridViewTextBoxColumn2.Width = 125;
            // 
            // ProductManagementTitle
            // 
            this.ProductManagementTitle.AutoSize = true;
            this.ProductManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductManagementTitle.Location = new System.Drawing.Point(479, 27);
            this.ProductManagementTitle.Name = "ProductManagementTitle";
            this.ProductManagementTitle.Size = new System.Drawing.Size(452, 51);
            this.ProductManagementTitle.TabIndex = 17;
            this.ProductManagementTitle.Text = "Product Management";
            this.ProductManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(280, 413);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(217, 61);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // refreshBtn1
            // 
            this.refreshBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn1.Location = new System.Drawing.Point(57, 413);
            this.refreshBtn1.Name = "refreshBtn1";
            this.refreshBtn1.Size = new System.Drawing.Size(217, 61);
            this.refreshBtn1.TabIndex = 19;
            this.refreshBtn1.Text = "Refresh Table";
            this.refreshBtn1.UseVisualStyleBackColor = true;
            this.refreshBtn1.Click += new System.EventHandler(this.refreshBtn1_Click);
            // 
            // addProductIdInput
            // 
            this.addProductIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductIdInput.Location = new System.Drawing.Point(57, 78);
            this.addProductIdInput.Name = "addProductIdInput";
            this.addProductIdInput.Size = new System.Drawing.Size(440, 30);
            this.addProductIdInput.TabIndex = 18;
            this.addProductIdInput.TextChanged += new System.EventHandler(this.addProductIdInput_TextChanged);
            // 
            // addProductIdLabel
            // 
            this.addProductIdLabel.AutoSize = true;
            this.addProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductIdLabel.Location = new System.Drawing.Point(52, 46);
            this.addProductIdLabel.Name = "addProductIdLabel";
            this.addProductIdLabel.Size = new System.Drawing.Size(142, 29);
            this.addProductIdLabel.TabIndex = 17;
            this.addProductIdLabel.Text = "Product ID:";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ProductManagementTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.TabControl.ResumeLayout(false);
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet)).EndInit();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.Label ProductManagementTitle;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Super_MarketDataSet super_MarketDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Super_MarketDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button refreshBtn3;
        private System.Windows.Forms.TextBox deleteProductIdInput;
        private System.Windows.Forms.Label deleteProductIdLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button refreshBtn2;
        private System.Windows.Forms.TextBox updateProductIdInput;
        private System.Windows.Forms.Label updateProductIdLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button refreshBtn1;
        private System.Windows.Forms.TextBox addProductIdInput;
        private System.Windows.Forms.Label addProductIdLabel;
    }
}