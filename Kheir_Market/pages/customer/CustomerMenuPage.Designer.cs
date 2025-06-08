namespace Kheir_Market.pages
{
    partial class CustomerMenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenuPage));
            this.logOutBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.appTitle = new System.Windows.Forms.Label();
            this.welcomePersonMsg = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addProductCategoryLabel = new System.Windows.Forms.Label();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kheir_Market_DataSet = new Kheir_Market.Kheir_Market_DataSet();
            this.cATEGORYTableAdapter = new Kheir_Market.Kheir_Market_DataSetTableAdapters.CATEGORYTableAdapter();
            this.aboutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kheir_Market_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(49, 428);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(410, 116);
            this.logOutBtn.TabIndex = 21;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.Location = new System.Drawing.Point(49, 306);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(410, 116);
            this.orderBtn.TabIndex = 19;
            this.orderBtn.Text = "Order Management";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // appTitle
            // 
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(37, 40);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(422, 83);
            this.appTitle.TabIndex = 18;
            this.appTitle.Text = "Kheir Market";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomePersonMsg
            // 
            this.welcomePersonMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomePersonMsg.Location = new System.Drawing.Point(57, 162);
            this.welcomePersonMsg.Name = "welcomePersonMsg";
            this.welcomePersonMsg.Size = new System.Drawing.Size(402, 106);
            this.welcomePersonMsg.TabIndex = 25;
            this.welcomePersonMsg.Text = "Welcome, ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(549, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 602);
            this.dataGridView1.TabIndex = 26;
            // 
            // addProductCategoryLabel
            // 
            this.addProductCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductCategoryLabel.AutoSize = true;
            this.addProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductCategoryLabel.Location = new System.Drawing.Point(543, 68);
            this.addProductCategoryLabel.Name = "addProductCategoryLabel";
            this.addProductCategoryLabel.Size = new System.Drawing.Size(259, 32);
            this.addProductCategoryLabel.TabIndex = 28;
            this.addProductCategoryLabel.Text = "Product Category:";
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCategoryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addCategoryComboBox.DataSource = this.cATEGORYBindingSource;
            this.addCategoryComboBox.DisplayMember = "NAME";
            this.addCategoryComboBox.DropDownHeight = 200;
            this.addCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryComboBox.FormattingEnabled = true;
            this.addCategoryComboBox.IntegralHeight = false;
            this.addCategoryComboBox.Location = new System.Drawing.Point(888, 68);
            this.addCategoryComboBox.MaxDropDownItems = 5;
            this.addCategoryComboBox.Name = "addCategoryComboBox";
            this.addCategoryComboBox.Size = new System.Drawing.Size(582, 33);
            this.addCategoryComboBox.TabIndex = 27;
            this.addCategoryComboBox.ValueMember = "CID";
            this.addCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.addCategoryComboBox_SelectedIndexChanged);
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.kheir_Market_DataSet;
            // 
            // kheir_Market_DataSet
            // 
            this.kheir_Market_DataSet.DataSetName = "Kheir_Market_DataSet";
            this.kheir_Market_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutBtn.BackgroundImage")));
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Location = new System.Drawing.Point(12, 691);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(50, 50);
            this.aboutBtn.TabIndex = 31;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // CustomerMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.addProductCategoryLabel);
            this.Controls.Add(this.addCategoryComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.welcomePersonMsg);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.appTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "CustomerMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kheir Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerMenuPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kheir_Market_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label welcomePersonMsg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label addProductCategoryLabel;
        private System.Windows.Forms.ComboBox addCategoryComboBox;
        private Kheir_Market_DataSet kheir_Market_DataSet;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private Kheir_Market_DataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.Button aboutBtn;
    }
}