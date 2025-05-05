namespace Super_Market.pages
{
    partial class CustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            this.CustomerManagementTitle = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.refreshBtn1 = new System.Windows.Forms.Button();
            this.updateCustomerIdLabel = new System.Windows.Forms.Label();
            this.updateCustomerIdInput = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshBtn2 = new System.Windows.Forms.Button();
            this.deleteCustomerIdLabel = new System.Windows.Forms.Label();
            this.deleteCustomerIdInput = new System.Windows.Forms.TextBox();
            this.menuBtn = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.deletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerManagementTitle
            // 
            this.CustomerManagementTitle.AutoSize = true;
            this.CustomerManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerManagementTitle.Location = new System.Drawing.Point(502, 44);
            this.CustomerManagementTitle.Name = "CustomerManagementTitle";
            this.CustomerManagementTitle.Size = new System.Drawing.Size(491, 51);
            this.CustomerManagementTitle.TabIndex = 14;
            this.CustomerManagementTitle.Text = "Customer Management";
            this.CustomerManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.updatePage);
            this.TabControl.Controls.Add(this.deletePage);
            this.TabControl.Location = new System.Drawing.Point(12, 98);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1458, 584);
            this.TabControl.TabIndex = 15;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.searchBtn);
            this.updatePage.Controls.Add(this.updateBtn);
            this.updatePage.Controls.Add(this.refreshBtn1);
            this.updatePage.Controls.Add(this.updateCustomerIdLabel);
            this.updatePage.Controls.Add(this.updateCustomerIdInput);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1450, 555);
            this.updatePage.TabIndex = 0;
            this.updatePage.Text = "Update Customer";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(367, 95);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(131, 39);
            this.searchBtn.TabIndex = 25;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(281, 416);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(217, 61);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update Customer";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // refreshBtn1
            // 
            this.refreshBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn1.Location = new System.Drawing.Point(56, 416);
            this.refreshBtn1.Name = "refreshBtn1";
            this.refreshBtn1.Size = new System.Drawing.Size(217, 61);
            this.refreshBtn1.TabIndex = 23;
            this.refreshBtn1.Text = "Refresh Table";
            this.refreshBtn1.UseVisualStyleBackColor = true;
            this.refreshBtn1.Click += new System.EventHandler(this.refreshBtn1_Click);
            // 
            // updateCustomerIdLabel
            // 
            this.updateCustomerIdLabel.AutoSize = true;
            this.updateCustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerIdLabel.Location = new System.Drawing.Point(51, 68);
            this.updateCustomerIdLabel.Name = "updateCustomerIdLabel";
            this.updateCustomerIdLabel.Size = new System.Drawing.Size(164, 29);
            this.updateCustomerIdLabel.TabIndex = 21;
            this.updateCustomerIdLabel.Text = "Customer ID:";
            // 
            // updateCustomerIdInput
            // 
            this.updateCustomerIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateCustomerIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerIdInput.Location = new System.Drawing.Point(56, 100);
            this.updateCustomerIdInput.Name = "updateCustomerIdInput";
            this.updateCustomerIdInput.Size = new System.Drawing.Size(305, 30);
            this.updateCustomerIdInput.TabIndex = 22;
            this.updateCustomerIdInput.TextChanged += new System.EventHandler(this.updateCustomerIdInput_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(566, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(878, 548);
            this.dataGridView2.TabIndex = 0;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Controls.Add(this.dataGridView1);
            this.deletePage.Controls.Add(this.refreshBtn2);
            this.deletePage.Controls.Add(this.deleteCustomerIdLabel);
            this.deletePage.Controls.Add(this.deleteCustomerIdInput);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1450, 555);
            this.deletePage.TabIndex = 1;
            this.deletePage.Text = "Delete Customer";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(291, 296);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(217, 61);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete Customer";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(878, 548);
            this.dataGridView1.TabIndex = 0;
            // 
            // refreshBtn2
            // 
            this.refreshBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn2.Location = new System.Drawing.Point(68, 296);
            this.refreshBtn2.Name = "refreshBtn2";
            this.refreshBtn2.Size = new System.Drawing.Size(217, 61);
            this.refreshBtn2.TabIndex = 19;
            this.refreshBtn2.Text = "Refresh Table";
            this.refreshBtn2.UseVisualStyleBackColor = true;
            this.refreshBtn2.Click += new System.EventHandler(this.refreshBtn2_Click);
            // 
            // deleteCustomerIdLabel
            // 
            this.deleteCustomerIdLabel.AutoSize = true;
            this.deleteCustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerIdLabel.Location = new System.Drawing.Point(63, 71);
            this.deleteCustomerIdLabel.Name = "deleteCustomerIdLabel";
            this.deleteCustomerIdLabel.Size = new System.Drawing.Size(164, 29);
            this.deleteCustomerIdLabel.TabIndex = 17;
            this.deleteCustomerIdLabel.Text = "Customer ID:";
            // 
            // deleteCustomerIdInput
            // 
            this.deleteCustomerIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteCustomerIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerIdInput.Location = new System.Drawing.Point(68, 103);
            this.deleteCustomerIdInput.Name = "deleteCustomerIdInput";
            this.deleteCustomerIdInput.Size = new System.Drawing.Size(442, 30);
            this.deleteCustomerIdInput.TabIndex = 18;
            this.deleteCustomerIdInput.TextChanged += new System.EventHandler(this.deleteCustomerIdInput_TextChanged);
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(16, 688);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1450, 54);
            this.menuBtn.TabIndex = 16;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.CustomerManagementTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.TabControl.ResumeLayout(false);
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerManagementTitle;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button refreshBtn2;
        private System.Windows.Forms.Label deleteCustomerIdLabel;
        private System.Windows.Forms.TextBox deleteCustomerIdInput;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button refreshBtn1;
        private System.Windows.Forms.Label updateCustomerIdLabel;
        private System.Windows.Forms.TextBox updateCustomerIdInput;
        private System.Windows.Forms.Button searchBtn;
    }
}