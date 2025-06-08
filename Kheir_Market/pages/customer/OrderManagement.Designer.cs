namespace Kheir_Market.pages.customer
{
    partial class OrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteOrderIdInput = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.OrderManagementTitle = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.updateQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.updateQuantityLabel = new System.Windows.Forms.Label();
            this.updateOrderIdLabel = new System.Windows.Forms.Label();
            this.updateOrderIdInput = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addPage = new System.Windows.Forms.TabPage();
            this.toInput = new System.Windows.Forms.NumericUpDown();
            this.fromInput = new System.Windows.Forms.NumericUpDown();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addProductDepartmentLabel = new System.Windows.Forms.Label();
            this.addDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Kheir_Market_DataSet = new Kheir_Market.Kheir_Market_DataSet();
            this.addQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.addProductQuantityLabel = new System.Windows.Forms.Label();
            this.addProductComboBox = new System.Windows.Forms.ComboBox();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.menuBtn = new System.Windows.Forms.Button();
            this.dEPARTMENTTableAdapter = new Kheir_Market.Kheir_Market_DataSetTableAdapters.DEPARTMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.deletePage.SuspendLayout();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kheir_Market_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityInput)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(617, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(825, 612);
            this.dataGridView3.TabIndex = 0;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.label1);
            this.deletePage.Controls.Add(this.deleteOrderIdInput);
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1448, 621);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Order";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Order ID:";
            // 
            // deleteOrderIdInput
            // 
            this.deleteOrderIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteOrderIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteOrderIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderIdInput.Location = new System.Drawing.Point(81, 222);
            this.deleteOrderIdInput.Name = "deleteOrderIdInput";
            this.deleteOrderIdInput.Size = new System.Drawing.Size(440, 30);
            this.deleteOrderIdInput.TabIndex = 43;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(81, 323);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(440, 61);
            this.deleteBtn.TabIndex = 44;
            this.deleteBtn.Text = "Delete Order";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // OrderManagementTitle
            // 
            this.OrderManagementTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderManagementTitle.AutoSize = true;
            this.OrderManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderManagementTitle.Location = new System.Drawing.Point(540, 27);
            this.OrderManagementTitle.Name = "OrderManagementTitle";
            this.OrderManagementTitle.Size = new System.Drawing.Size(410, 51);
            this.OrderManagementTitle.TabIndex = 20;
            this.OrderManagementTitle.Text = "Order Management";
            this.OrderManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.updateQuantityInput);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Controls.Add(this.updateQuantityLabel);
            this.updatePage.Controls.Add(this.updateOrderIdLabel);
            this.updatePage.Controls.Add(this.updateOrderIdInput);
            this.updatePage.Controls.Add(this.updateBtn);
            this.updatePage.Controls.Add(this.searchBtn);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1448, 621);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Order";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // updateQuantityInput
            // 
            this.updateQuantityInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateQuantityInput.Enabled = false;
            this.updateQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuantityInput.Location = new System.Drawing.Point(77, 294);
            this.updateQuantityInput.Name = "updateQuantityInput";
            this.updateQuantityInput.Size = new System.Drawing.Size(440, 30);
            this.updateQuantityInput.TabIndex = 46;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(617, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(825, 612);
            this.dataGridView2.TabIndex = 0;
            // 
            // updateQuantityLabel
            // 
            this.updateQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateQuantityLabel.AutoSize = true;
            this.updateQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuantityLabel.Location = new System.Drawing.Point(72, 262);
            this.updateQuantityLabel.Name = "updateQuantityLabel";
            this.updateQuantityLabel.Size = new System.Drawing.Size(212, 29);
            this.updateQuantityLabel.TabIndex = 45;
            this.updateQuantityLabel.Text = "Product Quantity:";
            // 
            // updateOrderIdLabel
            // 
            this.updateOrderIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateOrderIdLabel.AutoSize = true;
            this.updateOrderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOrderIdLabel.Location = new System.Drawing.Point(72, 182);
            this.updateOrderIdLabel.Name = "updateOrderIdLabel";
            this.updateOrderIdLabel.Size = new System.Drawing.Size(120, 29);
            this.updateOrderIdLabel.TabIndex = 39;
            this.updateOrderIdLabel.Text = "Order ID:";
            // 
            // updateOrderIdInput
            // 
            this.updateOrderIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateOrderIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateOrderIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOrderIdInput.Location = new System.Drawing.Point(77, 214);
            this.updateOrderIdInput.Name = "updateOrderIdInput";
            this.updateOrderIdInput.Size = new System.Drawing.Size(303, 30);
            this.updateOrderIdInput.TabIndex = 40;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(77, 370);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(440, 61);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update Order";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(386, 209);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(131, 39);
            this.searchBtn.TabIndex = 42;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(617, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 612);
            this.dataGridView1.TabIndex = 0;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.toInput);
            this.addPage.Controls.Add(this.fromInput);
            this.addPage.Controls.Add(this.fromLabel);
            this.addPage.Controls.Add(this.toLabel);
            this.addPage.Controls.Add(this.priceLabel);
            this.addPage.Controls.Add(this.addProductDepartmentLabel);
            this.addPage.Controls.Add(this.addDepartmentComboBox);
            this.addPage.Controls.Add(this.addQuantityInput);
            this.addPage.Controls.Add(this.addProductQuantityLabel);
            this.addPage.Controls.Add(this.addProductComboBox);
            this.addPage.Controls.Add(this.addProductNameLabel);
            this.addPage.Controls.Add(this.addBtn);
            this.addPage.Controls.Add(this.dataGridView1);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(1448, 621);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Add Order";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // toInput
            // 
            this.toInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toInput.Location = new System.Drawing.Point(359, 216);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(158, 30);
            this.toInput.TabIndex = 47;
            this.toInput.ValueChanged += new System.EventHandler(this.toInput_ValueChanged);
            // 
            // fromInput
            // 
            this.fromInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromInput.Location = new System.Drawing.Point(137, 214);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(158, 30);
            this.fromInput.TabIndex = 46;
            this.fromInput.ValueChanged += new System.EventHandler(this.fromInput_ValueChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(50, 211);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(81, 29);
            this.fromLabel.TabIndex = 45;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(301, 215);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(52, 29);
            this.toLabel.TabIndex = 44;
            this.toLabel.Text = "To:";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(50, 182);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(245, 29);
            this.priceLabel.TabIndex = 43;
            this.priceLabel.Text = "Select Price Range:";
            // 
            // addProductDepartmentLabel
            // 
            this.addProductDepartmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProductDepartmentLabel.AutoSize = true;
            this.addProductDepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductDepartmentLabel.Location = new System.Drawing.Point(50, 85);
            this.addProductDepartmentLabel.Name = "addProductDepartmentLabel";
            this.addProductDepartmentLabel.Size = new System.Drawing.Size(252, 29);
            this.addProductDepartmentLabel.TabIndex = 40;
            this.addProductDepartmentLabel.Text = "Product Department:";
            // 
            // addDepartmentComboBox
            // 
            this.addDepartmentComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addDepartmentComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addDepartmentComboBox.DataSource = this.dEPARTMENTBindingSource;
            this.addDepartmentComboBox.DisplayMember = "NAME";
            this.addDepartmentComboBox.DropDownHeight = 200;
            this.addDepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addDepartmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentComboBox.FormattingEnabled = true;
            this.addDepartmentComboBox.IntegralHeight = false;
            this.addDepartmentComboBox.Location = new System.Drawing.Point(55, 117);
            this.addDepartmentComboBox.MaxDropDownItems = 5;
            this.addDepartmentComboBox.Name = "addDepartmentComboBox";
            this.addDepartmentComboBox.Size = new System.Drawing.Size(462, 33);
            this.addDepartmentComboBox.TabIndex = 39;
            this.addDepartmentComboBox.ValueMember = "DID";
            this.addDepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.addDepartmentComboBox_SelectedIndexChanged);
            // 
            // dEPARTMENTBindingSource
            // 
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.Kheir_Market_DataSet;
            // 
            // Kheir_Market_DataSet
            // 
            this.Kheir_Market_DataSet.DataSetName = "Kheir_Market_DataSet";
            this.Kheir_Market_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addQuantityInput
            // 
            this.addQuantityInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addQuantityInput.Enabled = false;
            this.addQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantityInput.Location = new System.Drawing.Point(55, 394);
            this.addQuantityInput.Name = "addQuantityInput";
            this.addQuantityInput.Size = new System.Drawing.Size(462, 30);
            this.addQuantityInput.TabIndex = 38;
            // 
            // addProductQuantityLabel
            // 
            this.addProductQuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProductQuantityLabel.AutoSize = true;
            this.addProductQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductQuantityLabel.Location = new System.Drawing.Point(50, 362);
            this.addProductQuantityLabel.Name = "addProductQuantityLabel";
            this.addProductQuantityLabel.Size = new System.Drawing.Size(212, 29);
            this.addProductQuantityLabel.TabIndex = 37;
            this.addProductQuantityLabel.Text = "Product Quantity:";
            // 
            // addProductComboBox
            // 
            this.addProductComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProductComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProductComboBox.DisplayMember = "NAME";
            this.addProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addProductComboBox.Enabled = false;
            this.addProductComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductComboBox.FormattingEnabled = true;
            this.addProductComboBox.Location = new System.Drawing.Point(55, 302);
            this.addProductComboBox.MaxDropDownItems = 5;
            this.addProductComboBox.Name = "addProductComboBox";
            this.addProductComboBox.Size = new System.Drawing.Size(462, 33);
            this.addProductComboBox.TabIndex = 36;
            this.addProductComboBox.ValueMember = "PID";
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameLabel.Location = new System.Drawing.Point(50, 270);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(186, 29);
            this.addProductNameLabel.TabIndex = 35;
            this.addProductNameLabel.Text = "Product Name:";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(55, 464);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(462, 61);
            this.addBtn.TabIndex = 34;
            this.addBtn.Text = "Add Order";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.addPage);
            this.TabControl.Controls.Add(this.updatePage);
            this.TabControl.Controls.Add(this.deletePage);
            this.TabControl.Location = new System.Drawing.Point(13, 81);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1456, 650);
            this.TabControl.TabIndex = 21;
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(17, 737);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1452, 54);
            this.menuBtn.TabIndex = 22;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // dEPARTMENTTableAdapter
            // 
            this.dEPARTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.OrderManagementTitle);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kheir Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kheir_Market_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityInput)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Label OrderManagementTitle;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label addProductDepartmentLabel;
        private System.Windows.Forms.ComboBox addDepartmentComboBox;
        private System.Windows.Forms.NumericUpDown addQuantityInput;
        private System.Windows.Forms.Label addProductQuantityLabel;
        private System.Windows.Forms.ComboBox addProductComboBox;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown toInput;
        private System.Windows.Forms.NumericUpDown fromInput;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private Kheir_Market_DataSet Kheir_Market_DataSet;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private Kheir_Market_DataSetTableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
        private System.Windows.Forms.NumericUpDown updateQuantityInput;
        private System.Windows.Forms.Label updateQuantityLabel;
        private System.Windows.Forms.Label updateOrderIdLabel;
        private System.Windows.Forms.TextBox updateOrderIdInput;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteOrderIdInput;
        private System.Windows.Forms.Button deleteBtn;
    }
}