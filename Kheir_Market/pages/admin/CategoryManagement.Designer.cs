namespace Kheir_Market.pages
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Kheir_Market_DataSet = new Kheir_Market.Kheir_Market_DataSet();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteCategoryIdInput = new System.Windows.Forms.TextBox();
            this.deleteCategoryIdLabel = new System.Windows.Forms.Label();
            this.CategoryManagementTitle = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateCategoryNameInput = new System.Windows.Forms.TextBox();
            this.updateCategoryNameLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.updateCategoryIdInput = new System.Windows.Forms.TextBox();
            this.updateCategoryIdLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPage = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.addCategoryNameInput = new System.Windows.Forms.TextBox();
            this.addCategoryIdInput = new System.Windows.Forms.TextBox();
            this.addCategoryNameLabel = new System.Windows.Forms.Label();
            this.addCategoryIdLabel = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.menuBtn = new System.Windows.Forms.Button();
            this.cATEGORYTableAdapter = new Kheir_Market.Kheir_Market_DataSetTableAdapters.CATEGORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kheir_Market_DataSet)).BeginInit();
            this.deletePage.SuspendLayout();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addPage.SuspendLayout();
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
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.DataSource = this.cATEGORYBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(566, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(876, 612);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.Kheir_Market_DataSet;
            // 
            // Kheir_Market_DataSet
            // 
            this.Kheir_Market_DataSet.DataSetName = "Kheir_Market_DataSet";
            this.Kheir_Market_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Controls.Add(this.deleteCategoryIdInput);
            this.deletePage.Controls.Add(this.deleteCategoryIdLabel);
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1448, 621);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Category";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(55, 332);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(440, 61);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete Category";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deleteCategoryIdInput
            // 
            this.deleteCategoryIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteCategoryIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteCategoryIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryIdInput.Location = new System.Drawing.Point(53, 227);
            this.deleteCategoryIdInput.Name = "deleteCategoryIdInput";
            this.deleteCategoryIdInput.Size = new System.Drawing.Size(442, 30);
            this.deleteCategoryIdInput.TabIndex = 5;
            // 
            // deleteCategoryIdLabel
            // 
            this.deleteCategoryIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteCategoryIdLabel.AutoSize = true;
            this.deleteCategoryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryIdLabel.Location = new System.Drawing.Point(48, 195);
            this.deleteCategoryIdLabel.Name = "deleteCategoryIdLabel";
            this.deleteCategoryIdLabel.Size = new System.Drawing.Size(157, 29);
            this.deleteCategoryIdLabel.TabIndex = 4;
            this.deleteCategoryIdLabel.Text = "Category ID:";
            // 
            // CategoryManagementTitle
            // 
            this.CategoryManagementTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.updatePage.Controls.Add(this.updateCategoryIdInput);
            this.updatePage.Controls.Add(this.updateCategoryIdLabel);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1448, 621);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Category";
            this.updatePage.UseVisualStyleBackColor = true;
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
            // updateCategoryNameInput
            // 
            this.updateCategoryNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateCategoryNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateCategoryNameInput.Enabled = false;
            this.updateCategoryNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryNameInput.Location = new System.Drawing.Point(58, 276);
            this.updateCategoryNameInput.Name = "updateCategoryNameInput";
            this.updateCategoryNameInput.Size = new System.Drawing.Size(442, 30);
            this.updateCategoryNameInput.TabIndex = 9;
            // 
            // updateCategoryNameLabel
            // 
            this.updateCategoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateCategoryNameLabel.AutoSize = true;
            this.updateCategoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryNameLabel.Location = new System.Drawing.Point(53, 244);
            this.updateCategoryNameLabel.Name = "updateCategoryNameLabel";
            this.updateCategoryNameLabel.Size = new System.Drawing.Size(201, 29);
            this.updateCategoryNameLabel.TabIndex = 8;
            this.updateCategoryNameLabel.Text = "Category Name:";
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(58, 388);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(442, 61);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update Category";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // updateCategoryIdInput
            // 
            this.updateCategoryIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateCategoryIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateCategoryIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryIdInput.Location = new System.Drawing.Point(58, 147);
            this.updateCategoryIdInput.Name = "updateCategoryIdInput";
            this.updateCategoryIdInput.Size = new System.Drawing.Size(305, 30);
            this.updateCategoryIdInput.TabIndex = 5;
            // 
            // updateCategoryIdLabel
            // 
            this.updateCategoryIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateCategoryIdLabel.AutoSize = true;
            this.updateCategoryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryIdLabel.Location = new System.Drawing.Point(53, 115);
            this.updateCategoryIdLabel.Name = "updateCategoryIdLabel";
            this.updateCategoryIdLabel.Size = new System.Drawing.Size(157, 29);
            this.updateCategoryIdLabel.TabIndex = 4;
            this.updateCategoryIdLabel.Text = "Category ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.cATEGORYBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(566, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(876, 612);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.cATEGORYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(566, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 612);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.addBtn);
            this.addPage.Controls.Add(this.addCategoryNameInput);
            this.addPage.Controls.Add(this.addCategoryIdInput);
            this.addPage.Controls.Add(this.addCategoryNameLabel);
            this.addPage.Controls.Add(this.addCategoryIdLabel);
            this.addPage.Controls.Add(this.dataGridView1);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(1448, 621);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Add Category";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(57, 382);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(442, 61);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Category";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addCategoryNameInput
            // 
            this.addCategoryNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addCategoryNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCategoryNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryNameInput.Location = new System.Drawing.Point(57, 262);
            this.addCategoryNameInput.Name = "addCategoryNameInput";
            this.addCategoryNameInput.Size = new System.Drawing.Size(442, 30);
            this.addCategoryNameInput.TabIndex = 4;
            // 
            // addCategoryIdInput
            // 
            this.addCategoryIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addCategoryIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCategoryIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryIdInput.Location = new System.Drawing.Point(57, 140);
            this.addCategoryIdInput.Name = "addCategoryIdInput";
            this.addCategoryIdInput.Size = new System.Drawing.Size(442, 30);
            this.addCategoryIdInput.TabIndex = 3;
            // 
            // addCategoryNameLabel
            // 
            this.addCategoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addCategoryNameLabel.AutoSize = true;
            this.addCategoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryNameLabel.Location = new System.Drawing.Point(52, 230);
            this.addCategoryNameLabel.Name = "addCategoryNameLabel";
            this.addCategoryNameLabel.Size = new System.Drawing.Size(201, 29);
            this.addCategoryNameLabel.TabIndex = 2;
            this.addCategoryNameLabel.Text = "Category Name:";
            // 
            // addCategoryIdLabel
            // 
            this.addCategoryIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addCategoryIdLabel.AutoSize = true;
            this.addCategoryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryIdLabel.Location = new System.Drawing.Point(52, 108);
            this.addCategoryIdLabel.Name = "addCategoryIdLabel";
            this.addCategoryIdLabel.Size = new System.Drawing.Size(157, 29);
            this.addCategoryIdLabel.TabIndex = 1;
            this.addCategoryIdLabel.Text = "Category ID:";
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
            this.menuBtn.Location = new System.Drawing.Point(13, 737);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1452, 54);
            this.menuBtn.TabIndex = 22;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.CategoryManagementTitle);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kheir Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kheir_Market_DataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Label CategoryManagementTitle;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label addCategoryNameLabel;
        private System.Windows.Forms.Label addCategoryIdLabel;
        private System.Windows.Forms.TextBox addCategoryNameInput;
        private System.Windows.Forms.TextBox addCategoryIdInput;
        private System.Windows.Forms.TextBox deleteCategoryIdInput;
        private System.Windows.Forms.Label deleteCategoryIdLabel;
        private System.Windows.Forms.TextBox updateCategoryIdInput;
        private System.Windows.Forms.Label updateCategoryIdLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox updateCategoryNameInput;
        private System.Windows.Forms.Label updateCategoryNameLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private Kheir_Market_DataSet Kheir_Market_DataSet;
        private Kheir_Market_DataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}