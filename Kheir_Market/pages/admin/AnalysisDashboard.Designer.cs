namespace Kheir_Market.pages.admin
{
    partial class AnalysisDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalysisDashboard));
            this.SalesAnalysisDashboardTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuBtn = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.mostPurchasedProductPage = new System.Windows.Forms.TabPage();
            this.unsoldProductByMonthPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.yearsComboBox = new System.Windows.Forms.ComboBox();
            this.addProductCategoryLabel = new System.Windows.Forms.Label();
            this.monthsComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.interactiveCustomersPage = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.topPurchasingCustomerPage = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.salesComparisonPage = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.productPurchaseSummaryPage = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.printBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.mostPurchasedProductPage.SuspendLayout();
            this.unsoldProductByMonthPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.interactiveCustomersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.topPurchasingCustomerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.salesComparisonPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.productPurchaseSummaryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesAnalysisDashboardTitle
            // 
            this.SalesAnalysisDashboardTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalesAnalysisDashboardTitle.AutoSize = true;
            this.SalesAnalysisDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesAnalysisDashboardTitle.Location = new System.Drawing.Point(478, 19);
            this.SalesAnalysisDashboardTitle.Name = "SalesAnalysisDashboardTitle";
            this.SalesAnalysisDashboardTitle.Size = new System.Drawing.Size(551, 51);
            this.SalesAnalysisDashboardTitle.TabIndex = 20;
            this.SalesAnalysisDashboardTitle.Text = "Sales Analysis Dashboard";
            this.SalesAnalysisDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1442, 615);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(17, 729);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1452, 54);
            this.menuBtn.TabIndex = 22;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.mostPurchasedProductPage);
            this.TabControl.Controls.Add(this.unsoldProductByMonthPage);
            this.TabControl.Controls.Add(this.interactiveCustomersPage);
            this.TabControl.Controls.Add(this.topPurchasingCustomerPage);
            this.TabControl.Controls.Add(this.salesComparisonPage);
            this.TabControl.Controls.Add(this.productPurchaseSummaryPage);
            this.TabControl.Location = new System.Drawing.Point(13, 73);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1456, 650);
            this.TabControl.TabIndex = 21;
            // 
            // mostPurchasedProductPage
            // 
            this.mostPurchasedProductPage.Controls.Add(this.dataGridView1);
            this.mostPurchasedProductPage.Location = new System.Drawing.Point(4, 25);
            this.mostPurchasedProductPage.Name = "mostPurchasedProductPage";
            this.mostPurchasedProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.mostPurchasedProductPage.Size = new System.Drawing.Size(1448, 621);
            this.mostPurchasedProductPage.TabIndex = 0;
            this.mostPurchasedProductPage.Text = "Most Purchased Product";
            this.mostPurchasedProductPage.UseVisualStyleBackColor = true;
            // 
            // unsoldProductByMonthPage
            // 
            this.unsoldProductByMonthPage.Controls.Add(this.label1);
            this.unsoldProductByMonthPage.Controls.Add(this.yearsComboBox);
            this.unsoldProductByMonthPage.Controls.Add(this.addProductCategoryLabel);
            this.unsoldProductByMonthPage.Controls.Add(this.monthsComboBox);
            this.unsoldProductByMonthPage.Controls.Add(this.dataGridView2);
            this.unsoldProductByMonthPage.Location = new System.Drawing.Point(4, 25);
            this.unsoldProductByMonthPage.Name = "unsoldProductByMonthPage";
            this.unsoldProductByMonthPage.Padding = new System.Windows.Forms.Padding(3);
            this.unsoldProductByMonthPage.Size = new System.Drawing.Size(1448, 621);
            this.unsoldProductByMonthPage.TabIndex = 1;
            this.unsoldProductByMonthPage.Text = "Unsold Products by Month";
            this.unsoldProductByMonthPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(783, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Year:";
            // 
            // yearsComboBox
            // 
            this.yearsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearsComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.yearsComboBox.DropDownHeight = 200;
            this.yearsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsComboBox.FormattingEnabled = true;
            this.yearsComboBox.IntegralHeight = false;
            this.yearsComboBox.Location = new System.Drawing.Point(880, 27);
            this.yearsComboBox.MaxDropDownItems = 5;
            this.yearsComboBox.Name = "yearsComboBox";
            this.yearsComboBox.Size = new System.Drawing.Size(358, 33);
            this.yearsComboBox.TabIndex = 27;
            // 
            // addProductCategoryLabel
            // 
            this.addProductCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addProductCategoryLabel.AutoSize = true;
            this.addProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductCategoryLabel.Location = new System.Drawing.Point(281, 27);
            this.addProductCategoryLabel.Name = "addProductCategoryLabel";
            this.addProductCategoryLabel.Size = new System.Drawing.Size(91, 29);
            this.addProductCategoryLabel.TabIndex = 26;
            this.addProductCategoryLabel.Text = "Month:";
            // 
            // monthsComboBox
            // 
            this.monthsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthsComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsComboBox.FormattingEnabled = true;
            this.monthsComboBox.Location = new System.Drawing.Point(378, 27);
            this.monthsComboBox.MaxDropDownItems = 5;
            this.monthsComboBox.Name = "monthsComboBox";
            this.monthsComboBox.Size = new System.Drawing.Size(358, 33);
            this.monthsComboBox.TabIndex = 25;
            this.monthsComboBox.SelectedIndexChanged += new System.EventHandler(this.UnsoldProductByMonth);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1442, 531);
            this.dataGridView2.TabIndex = 1;
            // 
            // interactiveCustomersPage
            // 
            this.interactiveCustomersPage.Controls.Add(this.dataGridView3);
            this.interactiveCustomersPage.Location = new System.Drawing.Point(4, 25);
            this.interactiveCustomersPage.Name = "interactiveCustomersPage";
            this.interactiveCustomersPage.Padding = new System.Windows.Forms.Padding(3);
            this.interactiveCustomersPage.Size = new System.Drawing.Size(1448, 621);
            this.interactiveCustomersPage.TabIndex = 2;
            this.interactiveCustomersPage.Text = "Inactive Customers";
            this.interactiveCustomersPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1442, 615);
            this.dataGridView3.TabIndex = 1;
            // 
            // topPurchasingCustomerPage
            // 
            this.topPurchasingCustomerPage.Controls.Add(this.dataGridView4);
            this.topPurchasingCustomerPage.Location = new System.Drawing.Point(4, 25);
            this.topPurchasingCustomerPage.Name = "topPurchasingCustomerPage";
            this.topPurchasingCustomerPage.Padding = new System.Windows.Forms.Padding(3);
            this.topPurchasingCustomerPage.Size = new System.Drawing.Size(1448, 621);
            this.topPurchasingCustomerPage.TabIndex = 3;
            this.topPurchasingCustomerPage.Text = "Top Purchasing ";
            this.topPurchasingCustomerPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1442, 615);
            this.dataGridView4.TabIndex = 1;
            // 
            // salesComparisonPage
            // 
            this.salesComparisonPage.Controls.Add(this.dataGridView5);
            this.salesComparisonPage.Location = new System.Drawing.Point(4, 25);
            this.salesComparisonPage.Name = "salesComparisonPage";
            this.salesComparisonPage.Padding = new System.Windows.Forms.Padding(3);
            this.salesComparisonPage.Size = new System.Drawing.Size(1448, 621);
            this.salesComparisonPage.TabIndex = 4;
            this.salesComparisonPage.Text = "Sales Comparison ";
            this.salesComparisonPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(1442, 615);
            this.dataGridView5.TabIndex = 1;
            // 
            // productPurchaseSummaryPage
            // 
            this.productPurchaseSummaryPage.Controls.Add(this.dataGridView6);
            this.productPurchaseSummaryPage.Location = new System.Drawing.Point(4, 25);
            this.productPurchaseSummaryPage.Name = "productPurchaseSummaryPage";
            this.productPurchaseSummaryPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPurchaseSummaryPage.Size = new System.Drawing.Size(1448, 621);
            this.productPurchaseSummaryPage.TabIndex = 5;
            this.productPurchaseSummaryPage.Text = "Product Purchase ";
            this.productPurchaseSummaryPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(1442, 615);
            this.dataGridView6.TabIndex = 1;
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printBtn.BackgroundImage")));
            this.printBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.printBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(1415, 20);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(50, 50);
            this.printBtn.TabIndex = 23;
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // AnalysisDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.SalesAnalysisDashboardTitle);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "AnalysisDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kheir Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnalysisDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.mostPurchasedProductPage.ResumeLayout(false);
            this.unsoldProductByMonthPage.ResumeLayout(false);
            this.unsoldProductByMonthPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.interactiveCustomersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.topPurchasingCustomerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.salesComparisonPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.productPurchaseSummaryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalesAnalysisDashboardTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage mostPurchasedProductPage;
        private System.Windows.Forms.TabPage unsoldProductByMonthPage;
        private System.Windows.Forms.TabPage interactiveCustomersPage;
        private System.Windows.Forms.TabPage topPurchasingCustomerPage;
        private System.Windows.Forms.TabPage salesComparisonPage;
        private System.Windows.Forms.TabPage productPurchaseSummaryPage;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Label addProductCategoryLabel;
        private System.Windows.Forms.ComboBox monthsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearsComboBox;
        private System.Windows.Forms.Button printBtn;
    }
}