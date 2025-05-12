namespace Super_Market.pages.customer
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
            this.OrderManagementTitle = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addPage = new System.Windows.Forms.TabPage();
            this.toInput = new System.Windows.Forms.NumericUpDown();
            this.fromInput = new System.Windows.Forms.NumericUpDown();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addProductDepartmentLabel = new System.Windows.Forms.Label();
            this.addDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.addQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.addProductQuantityLabel = new System.Windows.Forms.Label();
            this.addProductComboBox = new System.Windows.Forms.ComboBox();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.menuBtn = new System.Windows.Forms.Button();
            this.super_Market_DataSet1 = new Super_Market.Super_Market_DataSet();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTTableAdapter1 = new Super_Market.Super_Market_DataSetTableAdapters.DEPARTMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.deletePage.SuspendLayout();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityInput)).BeginInit();
            this.TabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.super_Market_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
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
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1448, 621);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Order";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // OrderManagementTitle
            // 
            this.OrderManagementTitle.AutoSize = true;
            this.OrderManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderManagementTitle.Location = new System.Drawing.Point(509, 27);
            this.OrderManagementTitle.Name = "OrderManagementTitle";
            this.OrderManagementTitle.Size = new System.Drawing.Size(410, 51);
            this.OrderManagementTitle.TabIndex = 20;
            this.OrderManagementTitle.Text = "Order Management";
            this.OrderManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1448, 621);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Order";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(617, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(825, 612);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.toInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toInput.Location = new System.Drawing.Point(359, 205);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(158, 30);
            this.toInput.TabIndex = 47;
            this.toInput.ValueChanged += new System.EventHandler(this.toInput_ValueChanged);
            // 
            // fromInput
            // 
            this.fromInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromInput.Location = new System.Drawing.Point(137, 203);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(158, 30);
            this.fromInput.TabIndex = 46;
            this.fromInput.ValueChanged += new System.EventHandler(this.fromInput_ValueChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(50, 200);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(81, 29);
            this.fromLabel.TabIndex = 45;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(301, 204);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(52, 29);
            this.toLabel.TabIndex = 44;
            this.toLabel.Text = "To:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(50, 171);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(245, 29);
            this.priceLabel.TabIndex = 43;
            this.priceLabel.Text = "Select Price Range:";
            // 
            // addProductDepartmentLabel
            // 
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
            // addQuantityInput
            // 
            this.addQuantityInput.Enabled = false;
            this.addQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantityInput.Location = new System.Drawing.Point(55, 394);
            this.addQuantityInput.Name = "addQuantityInput";
            this.addQuantityInput.Size = new System.Drawing.Size(462, 30);
            this.addQuantityInput.TabIndex = 38;
            // 
            // addProductQuantityLabel
            // 
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
            this.addProductComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProductComboBox.DisplayMember = "NAME";
            this.addProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addProductComboBox.Enabled = false;
            this.addProductComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductComboBox.FormattingEnabled = true;
            this.addProductComboBox.Location = new System.Drawing.Point(55, 299);
            this.addProductComboBox.MaxDropDownItems = 5;
            this.addProductComboBox.Name = "addProductComboBox";
            this.addProductComboBox.Size = new System.Drawing.Size(462, 33);
            this.addProductComboBox.TabIndex = 36;
            this.addProductComboBox.ValueMember = "PID";
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameLabel.Location = new System.Drawing.Point(50, 267);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(186, 29);
            this.addProductNameLabel.TabIndex = 35;
            this.addProductNameLabel.Text = "Product Name:";
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(55, 464);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(462, 61);
            this.addBtn.TabIndex = 34;
            this.addBtn.Text = "Add Order";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
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
            // super_Market_DataSet1
            // 
            this.super_Market_DataSet1.DataSetName = "Super_Market_DataSet";
            this.super_Market_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPARTMENTBindingSource
            // 
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.super_Market_DataSet1;
            // 
            // dEPARTMENTTableAdapter1
            // 
            this.dEPARTMENTTableAdapter1.ClearBeforeFill = true;
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
            this.Text = "Super Market Management System";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.updatePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityInput)).EndInit();
            this.TabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.super_Market_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).EndInit();
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
        private Super_Market_DataSet super_Market_DataSet;
        private Super_Market_DataSetTableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
        private Super_Market_DataSet super_Market_DataSet1;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private Super_Market_DataSetTableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter1;
    }
}