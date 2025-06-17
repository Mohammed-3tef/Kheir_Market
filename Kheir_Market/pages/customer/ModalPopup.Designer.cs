namespace Kheir_Market.pages.customer
{
    partial class ModalPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalPopup));
            this.gmailBtn = new System.Windows.Forms.Button();
            this.whatsappBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmailBtn
            // 
            this.gmailBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gmailBtn.BackgroundImage")));
            this.gmailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gmailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gmailBtn.Location = new System.Drawing.Point(423, 105);
            this.gmailBtn.Name = "gmailBtn";
            this.gmailBtn.Size = new System.Drawing.Size(227, 210);
            this.gmailBtn.TabIndex = 0;
            this.gmailBtn.UseVisualStyleBackColor = true;
            this.gmailBtn.Click += new System.EventHandler(this.gmailBtn_Click);
            // 
            // whatsappBtn
            // 
            this.whatsappBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("whatsappBtn.BackgroundImage")));
            this.whatsappBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.whatsappBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whatsappBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatsappBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.whatsappBtn.Location = new System.Drawing.Point(118, 105);
            this.whatsappBtn.Name = "whatsappBtn";
            this.whatsappBtn.Size = new System.Drawing.Size(227, 210);
            this.whatsappBtn.TabIndex = 1;
            this.whatsappBtn.Text = "COMING SOON";
            this.whatsappBtn.UseVisualStyleBackColor = true;
            // 
            // ModalPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.whatsappBtn);
            this.Controls.Add(this.gmailBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ModalPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kheir Market";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gmailBtn;
        private System.Windows.Forms.Button whatsappBtn;
    }
}