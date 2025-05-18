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
            this.updatePhoneLabel = new System.Windows.Forms.Label();
            this.updatePhoneInput = new System.Windows.Forms.TextBox();
            this.updateAddressLabel = new System.Windows.Forms.Label();
            this.updateAddressInput = new System.Windows.Forms.TextBox();
            this.updateEmailLabel = new System.Windows.Forms.Label();
            this.updateEmailInput = new System.Windows.Forms.TextBox();
            this.updateNameLabel = new System.Windows.Forms.Label();
            this.updateNameInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.updateCustomerIdLabel = new System.Windows.Forms.Label();
            this.updateIdInput = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteCustomerIdLabel = new System.Windows.Forms.Label();
            this.deleteCustomerIdInput = new System.Windows.Forms.TextBox();
            this.menuBtn = new System.Windows.Forms.Button();
            this.updateAdminLabel = new System.Windows.Forms.Label();
            this.updateAdminBtn = new System.Windows.Forms.RadioButton();
            this.updateCustomerBtn = new System.Windows.Forms.RadioButton();
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
            this.TabControl.Size = new System.Drawing.Size(1458, 633);
            this.TabControl.TabIndex = 15;
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.updateCustomerBtn);
            this.updatePage.Controls.Add(this.updateAdminBtn);
            this.updatePage.Controls.Add(this.updateAdminLabel);
            this.updatePage.Controls.Add(this.updatePhoneLabel);
            this.updatePage.Controls.Add(this.updatePhoneInput);
            this.updatePage.Controls.Add(this.updateAddressLabel);
            this.updatePage.Controls.Add(this.updateAddressInput);
            this.updatePage.Controls.Add(this.updateEmailLabel);
            this.updatePage.Controls.Add(this.updateEmailInput);
            this.updatePage.Controls.Add(this.updateNameLabel);
            this.updatePage.Controls.Add(this.updateNameInput);
            this.updatePage.Controls.Add(this.searchBtn);
            this.updatePage.Controls.Add(this.updateBtn);
            this.updatePage.Controls.Add(this.updateCustomerIdLabel);
            this.updatePage.Controls.Add(this.updateIdInput);
            this.updatePage.Controls.Add(this.dataGridView2);
            this.updatePage.Location = new System.Drawing.Point(4, 25);
            this.updatePage.Name = "updatePage";
            this.updatePage.Padding = new System.Windows.Forms.Padding(3);
            this.updatePage.Size = new System.Drawing.Size(1450, 604);
            this.updatePage.TabIndex = 0;
            this.updatePage.Text = "Update Customer";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // updatePhoneLabel
            // 
            this.updatePhoneLabel.AutoSize = true;
            this.updatePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePhoneLabel.Location = new System.Drawing.Point(51, 198);
            this.updatePhoneLabel.Name = "updatePhoneLabel";
            this.updatePhoneLabel.Size = new System.Drawing.Size(95, 29);
            this.updatePhoneLabel.TabIndex = 32;
            this.updatePhoneLabel.Text = "Phone:";
            // 
            // updatePhoneInput
            // 
            this.updatePhoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatePhoneInput.Enabled = false;
            this.updatePhoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePhoneInput.Location = new System.Drawing.Point(56, 230);
            this.updatePhoneInput.Name = "updatePhoneInput";
            this.updatePhoneInput.Size = new System.Drawing.Size(496, 30);
            this.updatePhoneInput.TabIndex = 33;
            // 
            // updateAddressLabel
            // 
            this.updateAddressLabel.AutoSize = true;
            this.updateAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAddressLabel.Location = new System.Drawing.Point(51, 328);
            this.updateAddressLabel.Name = "updateAddressLabel";
            this.updateAddressLabel.Size = new System.Drawing.Size(116, 29);
            this.updateAddressLabel.TabIndex = 30;
            this.updateAddressLabel.Text = "Address:";
            // 
            // updateAddressInput
            // 
            this.updateAddressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateAddressInput.Enabled = false;
            this.updateAddressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAddressInput.Location = new System.Drawing.Point(56, 360);
            this.updateAddressInput.Name = "updateAddressInput";
            this.updateAddressInput.Size = new System.Drawing.Size(496, 30);
            this.updateAddressInput.TabIndex = 31;
            // 
            // updateEmailLabel
            // 
            this.updateEmailLabel.AutoSize = true;
            this.updateEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmailLabel.Location = new System.Drawing.Point(51, 263);
            this.updateEmailLabel.Name = "updateEmailLabel";
            this.updateEmailLabel.Size = new System.Drawing.Size(86, 29);
            this.updateEmailLabel.TabIndex = 28;
            this.updateEmailLabel.Text = "Email:";
            // 
            // updateEmailInput
            // 
            this.updateEmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateEmailInput.Enabled = false;
            this.updateEmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmailInput.Location = new System.Drawing.Point(56, 295);
            this.updateEmailInput.Name = "updateEmailInput";
            this.updateEmailInput.Size = new System.Drawing.Size(496, 30);
            this.updateEmailInput.TabIndex = 29;
            // 
            // updateNameLabel
            // 
            this.updateNameLabel.AutoSize = true;
            this.updateNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNameLabel.Location = new System.Drawing.Point(51, 133);
            this.updateNameLabel.Name = "updateNameLabel";
            this.updateNameLabel.Size = new System.Drawing.Size(89, 29);
            this.updateNameLabel.TabIndex = 26;
            this.updateNameLabel.Text = "Name:";
            // 
            // updateNameInput
            // 
            this.updateNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateNameInput.Enabled = false;
            this.updateNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNameInput.Location = new System.Drawing.Point(56, 165);
            this.updateNameInput.Name = "updateNameInput";
            this.updateNameInput.Size = new System.Drawing.Size(496, 30);
            this.updateNameInput.TabIndex = 27;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(421, 95);
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
            this.updateBtn.Location = new System.Drawing.Point(56, 459);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(496, 61);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update Customer";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            // updateIdInput
            // 
            this.updateIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateIdInput.Location = new System.Drawing.Point(56, 100);
            this.updateIdInput.Name = "updateIdInput";
            this.updateIdInput.Size = new System.Drawing.Size(359, 30);
            this.updateIdInput.TabIndex = 22;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(613, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(831, 594);
            this.dataGridView2.TabIndex = 0;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.deleteBtn);
            this.deletePage.Controls.Add(this.dataGridView1);
            this.deletePage.Controls.Add(this.deleteCustomerIdLabel);
            this.deletePage.Controls.Add(this.deleteCustomerIdInput);
            this.deletePage.Location = new System.Drawing.Point(4, 25);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1450, 604);
            this.deletePage.TabIndex = 1;
            this.deletePage.Text = "Delete Customer";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(72, 317);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(440, 61);
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
            this.dataGridView1.Location = new System.Drawing.Point(616, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 594);
            this.dataGridView1.TabIndex = 0;
            // 
            // deleteCustomerIdLabel
            // 
            this.deleteCustomerIdLabel.AutoSize = true;
            this.deleteCustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerIdLabel.Location = new System.Drawing.Point(67, 174);
            this.deleteCustomerIdLabel.Name = "deleteCustomerIdLabel";
            this.deleteCustomerIdLabel.Size = new System.Drawing.Size(164, 29);
            this.deleteCustomerIdLabel.TabIndex = 17;
            this.deleteCustomerIdLabel.Text = "Customer ID:";
            // 
            // deleteCustomerIdInput
            // 
            this.deleteCustomerIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteCustomerIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerIdInput.Location = new System.Drawing.Point(72, 206);
            this.deleteCustomerIdInput.Name = "deleteCustomerIdInput";
            this.deleteCustomerIdInput.Size = new System.Drawing.Size(442, 30);
            this.deleteCustomerIdInput.TabIndex = 18;
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(16, 737);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(1450, 54);
            this.menuBtn.TabIndex = 16;
            this.menuBtn.Text = "Back to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // updateAdminLabel
            // 
            this.updateAdminLabel.AutoSize = true;
            this.updateAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAdminLabel.Location = new System.Drawing.Point(51, 409);
            this.updateAdminLabel.Name = "updateAdminLabel";
            this.updateAdminLabel.Size = new System.Drawing.Size(121, 29);
            this.updateAdminLabel.TabIndex = 34;
            this.updateAdminLabel.Text = "He / She:";
            // 
            // updateAdminBtn
            // 
            this.updateAdminBtn.AutoSize = true;
            this.updateAdminBtn.Enabled = false;
            this.updateAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAdminBtn.Location = new System.Drawing.Point(178, 409);
            this.updateAdminBtn.Name = "updateAdminBtn";
            this.updateAdminBtn.Size = new System.Drawing.Size(94, 29);
            this.updateAdminBtn.TabIndex = 35;
            this.updateAdminBtn.TabStop = true;
            this.updateAdminBtn.Text = "Admin";
            this.updateAdminBtn.UseVisualStyleBackColor = true;
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.AutoSize = true;
            this.updateCustomerBtn.Enabled = false;
            this.updateCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerBtn.Location = new System.Drawing.Point(426, 409);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(126, 29);
            this.updateCustomerBtn.TabIndex = 36;
            this.updateCustomerBtn.TabStop = true;
            this.updateCustomerBtn.Text = "Customer";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.CustomerManagementTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
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
        private System.Windows.Forms.Label deleteCustomerIdLabel;
        private System.Windows.Forms.TextBox deleteCustomerIdInput;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label updateCustomerIdLabel;
        private System.Windows.Forms.TextBox updateIdInput;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label updateAddressLabel;
        private System.Windows.Forms.TextBox updateAddressInput;
        private System.Windows.Forms.Label updateEmailLabel;
        private System.Windows.Forms.TextBox updateEmailInput;
        private System.Windows.Forms.Label updateNameLabel;
        private System.Windows.Forms.TextBox updateNameInput;
        private System.Windows.Forms.Label updatePhoneLabel;
        private System.Windows.Forms.TextBox updatePhoneInput;
        private System.Windows.Forms.Label updateAdminLabel;
        private System.Windows.Forms.RadioButton updateCustomerBtn;
        private System.Windows.Forms.RadioButton updateAdminBtn;
    }
}