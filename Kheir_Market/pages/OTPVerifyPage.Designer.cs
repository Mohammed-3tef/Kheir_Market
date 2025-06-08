namespace Kheir_Market.pages
{
    partial class OTPVerifyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPVerifyPage));
            this.resendBtn = new System.Windows.Forms.LinkLabel();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.logInLable = new System.Windows.Forms.Label();
            this.logInPageLink = new System.Windows.Forms.LinkLabel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.otpInput = new System.Windows.Forms.TextBox();
            this.OTPLabel = new System.Windows.Forms.Label();
            this.OTPVerificationLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.githubRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resendBtn
            // 
            this.resendBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resendBtn.AutoSize = true;
            this.resendBtn.Enabled = false;
            this.resendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resendBtn.LinkColor = System.Drawing.Color.Black;
            this.resendBtn.Location = new System.Drawing.Point(806, 452);
            this.resendBtn.Name = "resendBtn";
            this.resendBtn.Size = new System.Drawing.Size(154, 29);
            this.resendBtn.TabIndex = 56;
            this.resendBtn.TabStop = true;
            this.resendBtn.Text = "Resend OTP";
            this.resendBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resendBtn_LinkClicked);
            // 
            // verifyBtn
            // 
            this.verifyBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.Location = new System.Drawing.Point(752, 523);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(208, 64);
            this.verifyBtn.TabIndex = 55;
            this.verifyBtn.Text = "Verify OTP";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // logInLable
            // 
            this.logInLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInLable.AutoSize = true;
            this.logInLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLable.Location = new System.Drawing.Point(561, 609);
            this.logInLable.Name = "logInLable";
            this.logInLable.Size = new System.Drawing.Size(266, 32);
            this.logInLable.TabIndex = 54;
            this.logInLable.Text = "Have an account? ";
            // 
            // logInPageLink
            // 
            this.logInPageLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInPageLink.AutoSize = true;
            this.logInPageLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInPageLink.LinkColor = System.Drawing.Color.Black;
            this.logInPageLink.Location = new System.Drawing.Point(833, 609);
            this.logInPageLink.Name = "logInPageLink";
            this.logInPageLink.Size = new System.Drawing.Size(79, 29);
            this.logInPageLink.TabIndex = 53;
            this.logInPageLink.TabStop = true;
            this.logInPageLink.Text = "Log In";
            this.logInPageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInPageLink_LinkClicked);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(530, 523);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(208, 64);
            this.CancelBtn.TabIndex = 52;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // otpInput
            // 
            this.otpInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.otpInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpInput.Location = new System.Drawing.Point(530, 415);
            this.otpInput.Name = "otpInput";
            this.otpInput.Size = new System.Drawing.Size(430, 34);
            this.otpInput.TabIndex = 51;
            // 
            // OTPLabel
            // 
            this.OTPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OTPLabel.AutoSize = true;
            this.OTPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPLabel.Location = new System.Drawing.Point(524, 380);
            this.OTPLabel.Name = "OTPLabel";
            this.OTPLabel.Size = new System.Drawing.Size(436, 32);
            this.OTPLabel.TabIndex = 50;
            this.OTPLabel.Text = "Enter the OTP below to verify it";
            // 
            // OTPVerificationLabel
            // 
            this.OTPVerificationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OTPVerificationLabel.AutoSize = true;
            this.OTPVerificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPVerificationLabel.Location = new System.Drawing.Point(591, 270);
            this.OTPVerificationLabel.Name = "OTPVerificationLabel";
            this.OTPVerificationLabel.Size = new System.Drawing.Size(305, 42);
            this.OTPVerificationLabel.TabIndex = 49;
            this.OTPVerificationLabel.Text = "OTP Verification";
            // 
            // appTitle
            // 
            this.appTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(375, 129);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(729, 65);
            this.appTitle.TabIndex = 48;
            this.appTitle.Text = "Kheir Market";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMsg.Location = new System.Drawing.Point(384, 97);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(720, 32);
            this.welcomeMsg.TabIndex = 47;
            this.welcomeMsg.Text = "Welcome to";
            this.welcomeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // githubRepo
            // 
            this.githubRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.githubRepo.BackColor = System.Drawing.SystemColors.Control;
            this.githubRepo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("githubRepo.BackgroundImage")));
            this.githubRepo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.githubRepo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubRepo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.githubRepo.FlatAppearance.BorderSize = 0;
            this.githubRepo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.githubRepo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.githubRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.githubRepo.Location = new System.Drawing.Point(1420, 691);
            this.githubRepo.Name = "githubRepo";
            this.githubRepo.Size = new System.Drawing.Size(50, 50);
            this.githubRepo.TabIndex = 57;
            this.githubRepo.UseVisualStyleBackColor = false;
            this.githubRepo.Click += new System.EventHandler(this.githubRepo_Click);
            // 
            // OTPVerifyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.githubRepo);
            this.Controls.Add(this.resendBtn);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.logInLable);
            this.Controls.Add(this.logInPageLink);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.otpInput);
            this.Controls.Add(this.OTPLabel);
            this.Controls.Add(this.OTPVerificationLabel);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.welcomeMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "OTPVerifyPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kheir Market";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel resendBtn;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.Label logInLable;
        private System.Windows.Forms.LinkLabel logInPageLink;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox otpInput;
        private System.Windows.Forms.Label OTPLabel;
        private System.Windows.Forms.Label OTPVerificationLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.Button githubRepo;
    }
}