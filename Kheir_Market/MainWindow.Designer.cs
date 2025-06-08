namespace Kheir_Market
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.logInLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.signUpPageLink = new System.Windows.Forms.LinkLabel();
            this.signUpLable = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.Button();
            this.githubRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMsg.Location = new System.Drawing.Point(403, 99);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(729, 32);
            this.welcomeMsg.TabIndex = 0;
            this.welcomeMsg.Text = "Welcome to";
            this.welcomeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appTitle
            // 
            this.appTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(391, 128);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(741, 67);
            this.appTitle.TabIndex = 1;
            this.appTitle.Text = "Kheir Market";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logInLabel
            // 
            this.logInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInLabel.AutoSize = true;
            this.logInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel.Location = new System.Drawing.Point(702, 234);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(127, 42);
            this.logInLabel.TabIndex = 2;
            this.logInLabel.Text = "Log In";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(397, 347);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(161, 32);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(397, 407);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(155, 32);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameInput
            // 
            this.usernameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(613, 345);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(519, 34);
            this.usernameInput.TabIndex = 5;
            // 
            // passwordInput
            // 
            this.passwordInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(613, 405);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(471, 34);
            this.passwordInput.TabIndex = 6;
            // 
            // logInBtn
            // 
            this.logInBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.Location = new System.Drawing.Point(630, 515);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(290, 64);
            this.logInBtn.TabIndex = 7;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signUpPageLink
            // 
            this.signUpPageLink.ActiveLinkColor = System.Drawing.Color.Red;
            this.signUpPageLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpPageLink.AutoSize = true;
            this.signUpPageLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPageLink.LinkColor = System.Drawing.Color.Black;
            this.signUpPageLink.Location = new System.Drawing.Point(890, 611);
            this.signUpPageLink.Name = "signUpPageLink";
            this.signUpPageLink.Size = new System.Drawing.Size(99, 29);
            this.signUpPageLink.TabIndex = 8;
            this.signUpPageLink.TabStop = true;
            this.signUpPageLink.Text = "Sign Up";
            this.signUpPageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpPageLink_LinkClicked);
            // 
            // signUpLable
            // 
            this.signUpLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpLable.AutoSize = true;
            this.signUpLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLable.Location = new System.Drawing.Point(530, 608);
            this.signUpLable.Name = "signUpLable";
            this.signUpLable.Size = new System.Drawing.Size(340, 32);
            this.signUpLable.TabIndex = 9;
            this.signUpLable.Text = "Don\'t have an account? ";
            // 
            // showPassword
            // 
            this.showPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPassword.BackgroundImage")));
            this.showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.Location = new System.Drawing.Point(1090, 405);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(42, 34);
            this.showPassword.TabIndex = 10;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
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
            this.githubRepo.TabIndex = 11;
            this.githubRepo.UseVisualStyleBackColor = false;
            this.githubRepo.Click += new System.EventHandler(this.githubRepo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.githubRepo);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.signUpLable);
            this.Controls.Add(this.signUpPageLink);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.logInLabel);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.welcomeMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kheir Market";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label logInLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.LinkLabel signUpPageLink;
        private System.Windows.Forms.Label signUpLable;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Button githubRepo;
    }
}

