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
            this.addProductCompanyLabel = new System.Windows.Forms.Label();
            this.addCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.addProductDepartmentLabel = new System.Windows.Forms.Label();
            this.addDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.addProductPriceInput = new System.Windows.Forms.NumericUpDown();
            this.addProductPriceLabel = new System.Windows.Forms.Label();
            this.addProductQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.addProductQuantityLabel = new System.Windows.Forms.Label();
            this.addProductCategoryLabel = new System.Windows.Forms.Label();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.addProductNameInput = new System.Windows.Forms.TextBox();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.refreshBtn1 = new System.Windows.Forms.Button();
            this.addProductIdInput = new System.Windows.Forms.TextBox();
            this.addProductIdLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.updateCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.updateProductPriceInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.updateProductQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.updateProductNameInput = new System.Windows.Forms.TextBox();
            this.updateProductNameLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.refreshBtn2 = new System.Windows.Forms.Button();
            this.updateProductIdInput = new System.Windows.Forms.TextBox();
            this.updateProductIdLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshBtn3 = new System.Windows.Forms.Button();
            this.deleteProductIdInput = new System.Windows.Forms.TextBox();
            this.deleteProductIdLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ProductManagementTitle = new System.Windows.Forms.Label();
            this.super_Market_DataSet = new Super_Market.Super_Market_DataSet();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYTableAdapter = new Super_Market.Super_Market_DataSetTableAdapters.CATEGORYTableAdapter();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTTableAdapter = new Super_Market.Super_Market_DataSetTableAdapters.DEPARTMENTTableAdapter();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYTableAdapter = new Super_Market.Super_Market_DataSetTableAdapters.COMPANYTableAdapter();
            this.TabControl.SuspendLayout();
            this.addPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addProductPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateProductPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProductQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.deletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_Market_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(14, 777);
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
            this.TabControl.Size = new System.Drawing.Size(1456, 688);
            this.TabControl.TabIndex = 18;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.addProductCompanyLabel);
            this.addPage.Controls.Add(this.addCompanyComboBox);
            this.addPage.Controls.Add(this.addProductDepartmentLabel);
            this.addPage.Controls.Add(this.addDepartmentComboBox);
            this.addPage.Controls.Add(this.addProductPriceInput);
            this.addPage.Controls.Add(this.addProductPriceLabel);
            this.addPage.Controls.Add(this.addProductQuantityInput);
            this.addPage.Controls.Add(this.addProductQuantityLabel);
            this.addPage.Controls.Add(this.addProductCategoryLabel);
            this.addPage.Controls.Add(this.addCategoryComboBox);
            this.addPage.Controls.Add(this.addProductNameInput);
            this.addPage.Controls.Add(this.addProductNameLabel);
            this.addPage.Controls.Add(this.addBtn);
            this.addPage.Controls.Add(this.refreshBtn1);
            this.addPage.Controls.Add(this.addProductIdInput);
            this.addPage.Controls.Add(this.addProductIdLabel);
            this.addPage.Controls.Add(this.dataGridView1);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(1448, 659);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Add Product";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // addProductCompanyLabel
            // 
            this.addProductCompanyLabel.AutoSize = true;
            this.addProductCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductCompanyLabel.Location = new System.Drawing.Point(47, 356);
            this.addProductCompanyLabel.Name = "addProductCompanyLabel";
            this.addProductCompanyLabel.Size = new System.Drawing.Size(226, 29);
            this.addProductCompanyLabel.TabIndex = 32;
            this.addProductCompanyLabel.Text = "Product Company:";
            // 
            // addCompanyComboBox
            // 
            this.addCompanyComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addCompanyComboBox.DataSource = this.cOMPANYBindingSource;
            this.addCompanyComboBox.DisplayMember = "NAME";
            this.addCompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCompanyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompanyComboBox.FormattingEnabled = true;
            this.addCompanyComboBox.Location = new System.Drawing.Point(52, 388);
            this.addCompanyComboBox.MaxDropDownItems = 5;
            this.addCompanyComboBox.Name = "addCompanyComboBox";
            this.addCompanyComboBox.Size = new System.Drawing.Size(440, 33);
            this.addCompanyComboBox.TabIndex = 31;
            this.addCompanyComboBox.ValueMember = "COMPID";
            // 
            // addProductDepartmentLabel
            // 
            this.addProductDepartmentLabel.AutoSize = true;
            this.addProductDepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductDepartmentLabel.Location = new System.Drawing.Point(47, 279);
            this.addProductDepartmentLabel.Name = "addProductDepartmentLabel";
            this.addProductDepartmentLabel.Size = new System.Drawing.Size(252, 29);
            this.addProductDepartmentLabel.TabIndex = 30;
            this.addProductDepartmentLabel.Text = "Product Department:";
            // 
            // addDepartmentComboBox
            // 
            this.addDepartmentComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addDepartmentComboBox.DataSource = this.dEPARTMENTBindingSource;
            this.addDepartmentComboBox.DisplayMember = "NAME";
            this.addDepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addDepartmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentComboBox.FormattingEnabled = true;
            this.addDepartmentComboBox.Location = new System.Drawing.Point(52, 311);
            this.addDepartmentComboBox.MaxDropDownItems = 5;
            this.addDepartmentComboBox.Name = "addDepartmentComboBox";
            this.addDepartmentComboBox.Size = new System.Drawing.Size(440, 33);
            this.addDepartmentComboBox.TabIndex = 29;
            this.addDepartmentComboBox.ValueMember = "DID";
            // 
            // addProductPriceInput
            // 
            this.addProductPriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPriceInput.Location = new System.Drawing.Point(280, 466);
            this.addProductPriceInput.Name = "addProductPriceInput";
            this.addProductPriceInput.Size = new System.Drawing.Size(212, 30);
            this.addProductPriceInput.TabIndex = 28;
            // 
            // addProductPriceLabel
            // 
            this.addProductPriceLabel.AutoSize = true;
            this.addProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPriceLabel.Location = new System.Drawing.Point(275, 434);
            this.addProductPriceLabel.Name = "addProductPriceLabel";
            this.addProductPriceLabel.Size = new System.Drawing.Size(178, 29);
            this.addProductPriceLabel.TabIndex = 27;
            this.addProductPriceLabel.Text = "Product Price:";
            // 
            // addProductQuantityInput
            // 
            this.addProductQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductQuantityInput.Location = new System.Drawing.Point(52, 466);
            this.addProductQuantityInput.Name = "addProductQuantityInput";
            this.addProductQuantityInput.Size = new System.Drawing.Size(217, 30);
            this.addProductQuantityInput.TabIndex = 26;
            // 
            // addProductQuantityLabel
            // 
            this.addProductQuantityLabel.AutoSize = true;
            this.addProductQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductQuantityLabel.Location = new System.Drawing.Point(47, 434);
            this.addProductQuantityLabel.Name = "addProductQuantityLabel";
            this.addProductQuantityLabel.Size = new System.Drawing.Size(212, 29);
            this.addProductQuantityLabel.TabIndex = 25;
            this.addProductQuantityLabel.Text = "Product Quantity:";
            // 
            // addProductCategoryLabel
            // 
            this.addProductCategoryLabel.AutoSize = true;
            this.addProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductCategoryLabel.Location = new System.Drawing.Point(47, 197);
            this.addProductCategoryLabel.Name = "addProductCategoryLabel";
            this.addProductCategoryLabel.Size = new System.Drawing.Size(222, 29);
            this.addProductCategoryLabel.TabIndex = 24;
            this.addProductCategoryLabel.Text = "Product Category:";
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addCategoryComboBox.DataSource = this.cATEGORYBindingSource;
            this.addCategoryComboBox.DisplayMember = "NAME";
            this.addCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryComboBox.FormattingEnabled = true;
            this.addCategoryComboBox.Location = new System.Drawing.Point(52, 229);
            this.addCategoryComboBox.MaxDropDownItems = 5;
            this.addCategoryComboBox.Name = "addCategoryComboBox";
            this.addCategoryComboBox.Size = new System.Drawing.Size(440, 33);
            this.addCategoryComboBox.TabIndex = 23;
            this.addCategoryComboBox.ValueMember = "CID";
            // 
            // addProductNameInput
            // 
            this.addProductNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameInput.Location = new System.Drawing.Point(52, 154);
            this.addProductNameInput.Name = "addProductNameInput";
            this.addProductNameInput.Size = new System.Drawing.Size(440, 30);
            this.addProductNameInput.TabIndex = 22;
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameLabel.Location = new System.Drawing.Point(47, 122);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(186, 29);
            this.addProductNameLabel.TabIndex = 21;
            this.addProductNameLabel.Text = "Product Name:";
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(275, 536);
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
            this.refreshBtn1.Location = new System.Drawing.Point(52, 536);
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
            this.addProductIdInput.Location = new System.Drawing.Point(52, 80);
            this.addProductIdInput.Name = "addProductIdInput";
            this.addProductIdInput.Size = new System.Drawing.Size(440, 30);
            this.addProductIdInput.TabIndex = 18;
            // 
            // addProductIdLabel
            // 
            this.addProductIdLabel.AutoSize = true;
            this.addProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductIdLabel.Location = new System.Drawing.Point(47, 48);
            this.addProductIdLabel.Name = "addProductIdLabel";
            this.addProductIdLabel.Size = new System.Drawing.Size(142, 29);
            this.addProductIdLabel.TabIndex = 17;
            this.addProductIdLabel.Text = "Product ID:";
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
            this.dataGridView1.Size = new System.Drawing.Size(876, 650);
            this.dataGridView1.TabIndex = 0;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.label1);
            this.updatePage.Controls.Add(this.updateCompanyComboBox);
            this.updatePage.Controls.Add(this.label2);
            this.updatePage.Controls.Add(this.updateDepartmentComboBox);
            this.updatePage.Controls.Add(this.updateProductPriceInput);
            this.updatePage.Controls.Add(this.label3);
            this.updatePage.Controls.Add(this.updateProductQuantityInput);
            this.updatePage.Controls.Add(this.label4);
            this.updatePage.Controls.Add(this.label5);
            this.updatePage.Controls.Add(this.updateCategoryComboBox);
            this.updatePage.Controls.Add(this.updateProductNameInput);
            this.updatePage.Controls.Add(this.updateProductNameLabel);
            this.updatePage.Controls.Add(this.searchBtn);
            this.updatePage.Controls.Add(this.updateBtn);
            this.updatePage.Controls.Add(this.refreshBtn2);
            this.updatePage.Controls.Add(this.updateProductIdInput);
            this.updatePage.Controls.Add(this.updateProductIdLabel);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1448, 659);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Product";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Product Company:";
            // 
            // updateCompanyComboBox
            // 
            this.updateCompanyComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateCompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateCompanyComboBox.Enabled = false;
            this.updateCompanyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCompanyComboBox.FormattingEnabled = true;
            this.updateCompanyComboBox.Location = new System.Drawing.Point(54, 398);
            this.updateCompanyComboBox.MaxDropDownItems = 5;
            this.updateCompanyComboBox.Name = "updateCompanyComboBox";
            this.updateCompanyComboBox.Size = new System.Drawing.Size(440, 33);
            this.updateCompanyComboBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Product Department:";
            // 
            // updateDepartmentComboBox
            // 
            this.updateDepartmentComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateDepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateDepartmentComboBox.Enabled = false;
            this.updateDepartmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDepartmentComboBox.FormattingEnabled = true;
            this.updateDepartmentComboBox.Location = new System.Drawing.Point(54, 319);
            this.updateDepartmentComboBox.MaxDropDownItems = 5;
            this.updateDepartmentComboBox.Name = "updateDepartmentComboBox";
            this.updateDepartmentComboBox.Size = new System.Drawing.Size(440, 33);
            this.updateDepartmentComboBox.TabIndex = 41;
            // 
            // updateProductPriceInput
            // 
            this.updateProductPriceInput.Enabled = false;
            this.updateProductPriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductPriceInput.Location = new System.Drawing.Point(282, 476);
            this.updateProductPriceInput.Name = "updateProductPriceInput";
            this.updateProductPriceInput.Size = new System.Drawing.Size(212, 30);
            this.updateProductPriceInput.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Product Price:";
            // 
            // updateProductQuantityInput
            // 
            this.updateProductQuantityInput.Enabled = false;
            this.updateProductQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductQuantityInput.Location = new System.Drawing.Point(54, 476);
            this.updateProductQuantityInput.Name = "updateProductQuantityInput";
            this.updateProductQuantityInput.Size = new System.Drawing.Size(217, 30);
            this.updateProductQuantityInput.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Product Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Product Category:";
            // 
            // updateCategoryComboBox
            // 
            this.updateCategoryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateCategoryComboBox.Enabled = false;
            this.updateCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryComboBox.FormattingEnabled = true;
            this.updateCategoryComboBox.Location = new System.Drawing.Point(54, 239);
            this.updateCategoryComboBox.MaxDropDownItems = 5;
            this.updateCategoryComboBox.Name = "updateCategoryComboBox";
            this.updateCategoryComboBox.Size = new System.Drawing.Size(440, 33);
            this.updateCategoryComboBox.TabIndex = 35;
            // 
            // updateProductNameInput
            // 
            this.updateProductNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateProductNameInput.Enabled = false;
            this.updateProductNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductNameInput.Location = new System.Drawing.Point(54, 164);
            this.updateProductNameInput.Name = "updateProductNameInput";
            this.updateProductNameInput.Size = new System.Drawing.Size(440, 30);
            this.updateProductNameInput.TabIndex = 34;
            // 
            // updateProductNameLabel
            // 
            this.updateProductNameLabel.AutoSize = true;
            this.updateProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductNameLabel.Location = new System.Drawing.Point(49, 132);
            this.updateProductNameLabel.Name = "updateProductNameLabel";
            this.updateProductNameLabel.Size = new System.Drawing.Size(186, 29);
            this.updateProductNameLabel.TabIndex = 33;
            this.updateProductNameLabel.Text = "Product Name:";
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
            this.updateBtn.Location = new System.Drawing.Point(277, 541);
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
            this.refreshBtn2.Location = new System.Drawing.Point(54, 541);
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(566, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(876, 650);
            this.dataGridView2.TabIndex = 0;
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
            this.deletePage.Size = new System.Drawing.Size(1448, 659);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Product";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(285, 383);
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
            this.refreshBtn3.Location = new System.Drawing.Point(62, 383);
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
            this.deleteProductIdInput.Location = new System.Drawing.Point(62, 222);
            this.deleteProductIdInput.Name = "deleteProductIdInput";
            this.deleteProductIdInput.Size = new System.Drawing.Size(442, 30);
            this.deleteProductIdInput.TabIndex = 9;
            // 
            // deleteProductIdLabel
            // 
            this.deleteProductIdLabel.AutoSize = true;
            this.deleteProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductIdLabel.Location = new System.Drawing.Point(57, 190);
            this.deleteProductIdLabel.Name = "deleteProductIdLabel";
            this.deleteProductIdLabel.Size = new System.Drawing.Size(142, 29);
            this.deleteProductIdLabel.TabIndex = 8;
            this.deleteProductIdLabel.Text = "Product ID:";
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
            this.dataGridView3.Size = new System.Drawing.Size(876, 650);
            this.dataGridView3.TabIndex = 0;
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
            // super_Market_DataSet
            // 
            this.super_Market_DataSet.DataSetName = "Super_Market_DataSet";
            this.super_Market_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.super_Market_DataSet;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // dEPARTMENTBindingSource
            // 
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.super_Market_DataSet;
            // 
            // dEPARTMENTTableAdapter
            // 
            this.dEPARTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.super_Market_DataSet;
            // 
            // cOMPANYTableAdapter
            // 
            this.cOMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ProductManagementTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.TabControl.ResumeLayout(false);
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addProductPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateProductPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateProductQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_Market_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
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
        private System.Windows.Forms.TextBox addProductNameInput;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.ComboBox addCategoryComboBox;
        private System.Windows.Forms.Label addProductCategoryLabel;
        private System.Windows.Forms.NumericUpDown addProductQuantityInput;
        private System.Windows.Forms.Label addProductQuantityLabel;
        private System.Windows.Forms.Label addProductPriceLabel;
        private System.Windows.Forms.NumericUpDown addProductPriceInput;
        private System.Windows.Forms.Label addProductDepartmentLabel;
        private System.Windows.Forms.ComboBox addDepartmentComboBox;
        private System.Windows.Forms.Label addProductCompanyLabel;
        private System.Windows.Forms.ComboBox addCompanyComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox updateCompanyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox updateDepartmentComboBox;
        private System.Windows.Forms.NumericUpDown updateProductPriceInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updateProductQuantityInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox updateCategoryComboBox;
        private System.Windows.Forms.TextBox updateProductNameInput;
        private System.Windows.Forms.Label updateProductNameLabel;
        private Super_Market_DataSet super_Market_DataSet;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private Super_Market_DataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private Super_Market_DataSetTableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private Super_Market_DataSetTableAdapters.COMPANYTableAdapter cOMPANYTableAdapter;
    }
}