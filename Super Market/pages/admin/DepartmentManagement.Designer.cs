namespace Super_Market.pages.admin
{
    partial class DepartmentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentManagement));
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateDepartmentNameInput = new System.Windows.Forms.TextBox();
            this.updateDepartmentNameLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.addDepartmentNameInput = new System.Windows.Forms.TextBox();
            this.addDepartmentIdInput = new System.Windows.Forms.TextBox();
            this.addDepartmentNameLabel = new System.Windows.Forms.Label();
            this.addDepartmentIdLabel = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.addPage = new System.Windows.Forms.TabPage();
            this.addProductCategoryLabel = new System.Windows.Forms.Label();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_Market_DataSet1 = new Super_Market.Super_Market_DataSet();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.updateCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.updateDepartmentIdInput = new System.Windows.Forms.TextBox();
            this.updateDepartmentIdLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteDepartmentIdInput = new System.Windows.Forms.TextBox();
            this.deleteDepartmentIdLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuBtn = new System.Windows.Forms.Button();
            this.DepartmentManagementTitle = new System.Windows.Forms.Label();
            this.cATEGORYTableAdapter1 = new Super_Market.Super_Market_DataSetTableAdapters.CATEGORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.addPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_Market_DataSet1)).BeginInit();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.deletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            // updateDepartmentNameInput
            // 
            this.updateDepartmentNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateDepartmentNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateDepartmentNameInput.Enabled = false;
            this.updateDepartmentNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDepartmentNameInput.Location = new System.Drawing.Point(58, 241);
            this.updateDepartmentNameInput.Name = "updateDepartmentNameInput";
            this.updateDepartmentNameInput.Size = new System.Drawing.Size(442, 30);
            this.updateDepartmentNameInput.TabIndex = 9;
            // 
            // updateDepartmentNameLabel
            // 
            this.updateDepartmentNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateDepartmentNameLabel.AutoSize = true;
            this.updateDepartmentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDepartmentNameLabel.Location = new System.Drawing.Point(53, 209);
            this.updateDepartmentNameLabel.Name = "updateDepartmentNameLabel";
            this.updateDepartmentNameLabel.Size = new System.Drawing.Size(231, 29);
            this.updateDepartmentNameLabel.TabIndex = 8;
            this.updateDepartmentNameLabel.Text = "Department Name:";
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(58, 421);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(442, 61);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update Department";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(566, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 612);
            this.dataGridView1.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(57, 426);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(442, 61);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Department";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addDepartmentNameInput
            // 
            this.addDepartmentNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addDepartmentNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addDepartmentNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentNameInput.Location = new System.Drawing.Point(57, 230);
            this.addDepartmentNameInput.Name = "addDepartmentNameInput";
            this.addDepartmentNameInput.Size = new System.Drawing.Size(442, 30);
            this.addDepartmentNameInput.TabIndex = 4;
            // 
            // addDepartmentIdInput
            // 
            this.addDepartmentIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addDepartmentIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addDepartmentIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentIdInput.Location = new System.Drawing.Point(57, 140);
            this.addDepartmentIdInput.Name = "addDepartmentIdInput";
            this.addDepartmentIdInput.Size = new System.Drawing.Size(442, 30);
            this.addDepartmentIdInput.TabIndex = 3;
            // 
            // addDepartmentNameLabel
            // 
            this.addDepartmentNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addDepartmentNameLabel.AutoSize = true;
            this.addDepartmentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentNameLabel.Location = new System.Drawing.Point(52, 198);
            this.addDepartmentNameLabel.Name = "addDepartmentNameLabel";
            this.addDepartmentNameLabel.Size = new System.Drawing.Size(231, 29);
            this.addDepartmentNameLabel.TabIndex = 2;
            this.addDepartmentNameLabel.Text = "Department Name:";
            // 
            // addDepartmentIdLabel
            // 
            this.addDepartmentIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addDepartmentIdLabel.AutoSize = true;
            this.addDepartmentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentIdLabel.Location = new System.Drawing.Point(52, 108);
            this.addDepartmentIdLabel.Name = "addDepartmentIdLabel";
            this.addDepartmentIdLabel.Size = new System.Drawing.Size(187, 29);
            this.addDepartmentIdLabel.TabIndex = 1;
            this.addDepartmentIdLabel.Text = "Department ID:";
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.addPage);
            this.TabControl.Controls.Add(this.updatePage);
            this.TabControl.Controls.Add(this.deletePage);
            this.TabControl.Location = new System.Drawing.Point(13, 73);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1456, 650);
            this.TabControl.TabIndex = 24;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.addProductCategoryLabel);
            this.addPage.Controls.Add(this.addCategoryComboBox);
            this.addPage.Controls.Add(this.addBtn);
            this.addPage.Controls.Add(this.addDepartmentNameInput);
            this.addPage.Controls.Add(this.addDepartmentIdInput);
            this.addPage.Controls.Add(this.addDepartmentNameLabel);
            this.addPage.Controls.Add(this.addDepartmentIdLabel);
            this.addPage.Controls.Add(this.dataGridView1);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(1448, 621);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Add Department";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // addProductCategoryLabel
            // 
            this.addProductCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProductCategoryLabel.AutoSize = true;
            this.addProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductCategoryLabel.Location = new System.Drawing.Point(52, 287);
            this.addProductCategoryLabel.Name = "addProductCategoryLabel";
            this.addProductCategoryLabel.Size = new System.Drawing.Size(201, 29);
            this.addProductCategoryLabel.TabIndex = 26;
            this.addProductCategoryLabel.Text = "Category Name:";
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addCategoryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addCategoryComboBox.DataSource = this.cATEGORYBindingSource;
            this.addCategoryComboBox.DisplayMember = "NAME";
            this.addCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryComboBox.FormattingEnabled = true;
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
            // updatePage
            // 
            this.updatePage.Controls.Add(this.label1);
            this.updatePage.Controls.Add(this.updateCategorycomboBox);
            this.updatePage.Controls.Add(this.searchBtn);
            this.updatePage.Controls.Add(this.updateDepartmentNameInput);
            this.updatePage.Controls.Add(this.updateDepartmentNameLabel);
            this.updatePage.Controls.Add(this.updateBtn);
            this.updatePage.Controls.Add(this.updateDepartmentIdInput);
            this.updatePage.Controls.Add(this.updateDepartmentIdLabel);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1448, 621);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Department";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Category Name:";
            // 
            // updateCategorycomboBox
            // 
            this.updateCategorycomboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateCategorycomboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateCategorycomboBox.DataSource = this.cATEGORYBindingSource;
            this.updateCategorycomboBox.DisplayMember = "NAME";
            this.updateCategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateCategorycomboBox.Enabled = false;
            this.updateCategorycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategorycomboBox.FormattingEnabled = true;
            this.updateCategorycomboBox.Location = new System.Drawing.Point(58, 324);
            this.updateCategorycomboBox.MaxDropDownItems = 5;
            this.updateCategorycomboBox.Name = "updateCategorycomboBox";
            this.updateCategorycomboBox.Size = new System.Drawing.Size(440, 33);
            this.updateCategorycomboBox.TabIndex = 27;
            this.updateCategorycomboBox.ValueMember = "CID";
            // 
            // updateDepartmentIdInput
            // 
            this.updateDepartmentIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateDepartmentIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateDepartmentIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDepartmentIdInput.Location = new System.Drawing.Point(58, 147);
            this.updateDepartmentIdInput.Name = "updateDepartmentIdInput";
            this.updateDepartmentIdInput.Size = new System.Drawing.Size(305, 30);
            this.updateDepartmentIdInput.TabIndex = 5;
            // 
            // updateDepartmentIdLabel
            // 
            this.updateDepartmentIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateDepartmentIdLabel.AutoSize = true;
            this.updateDepartmentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDepartmentIdLabel.Location = new System.Drawing.Point(53, 115);
            this.updateDepartmentIdLabel.Name = "updateDepartmentIdLabel";
            this.updateDepartmentIdLabel.Size = new System.Drawing.Size(187, 29);
            this.updateDepartmentIdLabel.TabIndex = 4;
            this.updateDepartmentIdLabel.Text = "Department ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(566, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(876, 612);
            this.dataGridView2.TabIndex = 0;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Controls.Add(this.deleteDepartmentIdInput);
            this.deletePage.Controls.Add(this.deleteDepartmentIdLabel);
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1448, 621);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Department";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(55, 336);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(440, 61);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete Department";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deleteDepartmentIdInput
            // 
            this.deleteDepartmentIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteDepartmentIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteDepartmentIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDepartmentIdInput.Location = new System.Drawing.Point(53, 223);
            this.deleteDepartmentIdInput.Name = "deleteDepartmentIdInput";
            this.deleteDepartmentIdInput.Size = new System.Drawing.Size(442, 30);
            this.deleteDepartmentIdInput.TabIndex = 5;
            // 
            // deleteDepartmentIdLabel
            // 
            this.deleteDepartmentIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteDepartmentIdLabel.AutoSize = true;
            this.deleteDepartmentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDepartmentIdLabel.Location = new System.Drawing.Point(48, 191);
            this.deleteDepartmentIdLabel.Name = "deleteDepartmentIdLabel";
            this.deleteDepartmentIdLabel.Size = new System.Drawing.Size(187, 29);
            this.deleteDepartmentIdLabel.TabIndex = 4;
            this.deleteDepartmentIdLabel.Text = "Department ID:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(566, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(876, 612);
            this.dataGridView3.TabIndex = 0;
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(13, 729);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1452, 54);
            this.menuBtn.TabIndex = 25;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // DepartmentManagementTitle
            // 
            this.DepartmentManagementTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DepartmentManagementTitle.AutoSize = true;
            this.DepartmentManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentManagementTitle.Location = new System.Drawing.Point(478, 19);
            this.DepartmentManagementTitle.Name = "DepartmentManagementTitle";
            this.DepartmentManagementTitle.Size = new System.Drawing.Size(531, 51);
            this.DepartmentManagementTitle.TabIndex = 23;
            this.DepartmentManagementTitle.Text = "Department Management";
            this.DepartmentManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cATEGORYTableAdapter1
            // 
            this.cATEGORYTableAdapter1.ClearBeforeFill = true;
            // 
            // DepartmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.DepartmentManagementTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "DepartmentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.Load += new System.EventHandler(this.DepartmentManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_Market_DataSet1)).EndInit();
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

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox updateDepartmentNameInput;
        private System.Windows.Forms.Label updateDepartmentNameLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addDepartmentNameInput;
        private System.Windows.Forms.TextBox addDepartmentIdInput;
        private System.Windows.Forms.Label addDepartmentNameLabel;
        private System.Windows.Forms.Label addDepartmentIdLabel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.TextBox updateDepartmentIdInput;
        private System.Windows.Forms.Label updateDepartmentIdLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox deleteDepartmentIdInput;
        private System.Windows.Forms.Label deleteDepartmentIdLabel;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label DepartmentManagementTitle;
        private System.Windows.Forms.Label addProductCategoryLabel;
        private System.Windows.Forms.ComboBox addCategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox updateCategorycomboBox;
        private Super_Market_DataSet super_Market_DataSet1;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private Super_Market_DataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter1;
    }
}