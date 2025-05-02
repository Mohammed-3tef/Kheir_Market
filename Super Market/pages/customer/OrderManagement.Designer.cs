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
            this.productTableAdapter = new Super_Market.Super_MarketDataSetTableAdapters.ProductTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_MarketDataSet = new Super_Market.Super_MarketDataSet();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.OrderManagementTitle = new System.Windows.Forms.Label();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addPage = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.menuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet)).BeginInit();
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
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(566, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(876, 549);
            this.dataGridView3.TabIndex = 0;
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
            // deletePage
            // 
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1448, 555);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete Order";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // OrderManagementTitle
            // 
            this.OrderManagementTitle.AutoSize = true;
            this.OrderManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderManagementTitle.Location = new System.Drawing.Point(478, 27);
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
            this.updatePage.Size = new System.Drawing.Size(1448, 555);
            this.updatePage.TabIndex = 1;
            this.updatePage.Text = "Update Order";
            this.updatePage.UseVisualStyleBackColor = true;
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
            this.dataGridView2.Size = new System.Drawing.Size(876, 549);
            this.dataGridView2.TabIndex = 0;
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
            this.dataGridView1.Size = new System.Drawing.Size(876, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.dataGridView1);
            this.addPage.Location = new System.Drawing.Point(4, 25);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(1448, 555);
            this.addPage.TabIndex = 0;
            this.addPage.Text = "Add Order";
            this.addPage.UseVisualStyleBackColor = true;
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
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.OrderManagementTitle);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.updatePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addPage.ResumeLayout(false);
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
        private System.Windows.Forms.Label OrderManagementTitle;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button menuBtn;
    }
}