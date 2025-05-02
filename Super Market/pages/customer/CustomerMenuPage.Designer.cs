namespace Super_Market.pages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenuPage));
            this.logOutBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.appTitle = new System.Windows.Forms.Label();
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.welcomePersonMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(479, 489);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(477, 116);
            this.logOutBtn.TabIndex = 21;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.Location = new System.Drawing.Point(479, 340);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(477, 116);
            this.orderBtn.TabIndex = 19;
            this.orderBtn.Text = "Order Management";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(325, 122);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(729, 51);
            this.appTitle.TabIndex = 18;
            this.appTitle.Text = "Super Market Management System";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.AutoSize = true;
            this.welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMsg.Location = new System.Drawing.Point(621, 93);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(163, 32);
            this.welcomeMsg.TabIndex = 17;
            this.welcomeMsg.Text = "Welcome to";
            this.welcomeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomePersonMsg
            // 
            this.welcomePersonMsg.AutoSize = true;
            this.welcomePersonMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomePersonMsg.Location = new System.Drawing.Point(621, 245);
            this.welcomePersonMsg.Name = "welcomePersonMsg";
            this.welcomePersonMsg.Size = new System.Drawing.Size(156, 32);
            this.welcomePersonMsg.TabIndex = 25;
            this.welcomePersonMsg.Text = "Welcome, ";
            this.welcomePersonMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.welcomePersonMsg);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.welcomeMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "CustomerMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.Label welcomePersonMsg;
    }
}