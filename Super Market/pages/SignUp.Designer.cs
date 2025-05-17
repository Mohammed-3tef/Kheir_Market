namespace Super_Market.pages
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.logInLable = new System.Windows.Forms.Label();
            this.logInPageLink = new System.Windows.Forms.LinkLabel();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.confirmPasswordInput = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.Button();
            this.showConfirmPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logInLable
            // 
            this.logInLable.AutoSize = true;
            this.logInLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLable.Location = new System.Drawing.Point(562, 717);
            this.logInLable.Name = "logInLable";
            this.logInLable.Size = new System.Drawing.Size(266, 32);
            this.logInLable.TabIndex = 19;
            this.logInLable.Text = "Have an account? ";
            // 
            // logInPageLink
            // 
            this.logInPageLink.AutoSize = true;
            this.logInPageLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInPageLink.LinkColor = System.Drawing.Color.Black;
            this.logInPageLink.Location = new System.Drawing.Point(834, 717);
            this.logInPageLink.Name = "logInPageLink";
            this.logInPageLink.Size = new System.Drawing.Size(79, 29);
            this.logInPageLink.TabIndex = 18;
            this.logInPageLink.TabStop = true;
            this.logInPageLink.Text = "Log In";
            this.logInPageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInPageLink_LinkClicked);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Location = new System.Drawing.Point(599, 638);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(290, 64);
            this.signUpBtn.TabIndex = 17;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(686, 498);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(423, 34);
            this.passwordInput.TabIndex = 16;
            // 
            // usernameInput
            // 
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(686, 265);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(471, 34);
            this.usernameInput.TabIndex = 15;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(387, 500);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(155, 32);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(387, 264);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(161, 32);
            this.usernameLabel.TabIndex = 13;
            this.usernameLabel.Text = "Username:";
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(693, 174);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(158, 42);
            this.signUpLabel.TabIndex = 29;
            this.signUpLabel.Text = "Sign Up";
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(397, 89);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(729, 51);
            this.appTitle.TabIndex = 11;
            this.appTitle.Text = "Super Market Management System";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.AutoSize = true;
            this.welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMsg.Location = new System.Drawing.Point(693, 60);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(163, 32);
            this.welcomeMsg.TabIndex = 10;
            this.welcomeMsg.Text = "Welcome to";
            this.welcomeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordInput.Location = new System.Drawing.Point(686, 556);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.Size = new System.Drawing.Size(423, 34);
            this.confirmPasswordInput.TabIndex = 21;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(387, 558);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(269, 32);
            this.confirmPasswordLabel.TabIndex = 20;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // emailInput
            // 
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(686, 323);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(471, 34);
            this.emailInput.TabIndex = 23;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(387, 322);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 32);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "Email:";
            // 
            // phoneInput
            // 
            this.phoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneInput.Location = new System.Drawing.Point(686, 378);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(471, 34);
            this.phoneInput.TabIndex = 28;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(387, 377);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(225, 32);
            this.phoneLabel.TabIndex = 27;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // addressInput
            // 
            this.addressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressInput.Location = new System.Drawing.Point(686, 438);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(471, 34);
            this.addressInput.TabIndex = 30;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(387, 440);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(134, 32);
            this.addressLabel.TabIndex = 29;
            this.addressLabel.Text = "Address:";
            // 
            // showPassword
            // 
            this.showPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPassword.BackgroundImage")));
            this.showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.Location = new System.Drawing.Point(1115, 498);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(42, 34);
            this.showPassword.TabIndex = 31;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // showConfirmPassword
            // 
            this.showConfirmPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showConfirmPassword.BackgroundImage")));
            this.showConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showConfirmPassword.Location = new System.Drawing.Point(1115, 556);
            this.showConfirmPassword.Name = "showConfirmPassword";
            this.showConfirmPassword.Size = new System.Drawing.Size(42, 34);
            this.showConfirmPassword.TabIndex = 32;
            this.showConfirmPassword.UseVisualStyleBackColor = true;
            this.showConfirmPassword.Click += new System.EventHandler(this.showConfirmPassword_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1482, 864);
            this.Controls.Add(this.showConfirmPassword);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.logInLable);
            this.Controls.Add(this.logInPageLink);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.welcomeMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logInLable;
        private System.Windows.Forms.LinkLabel logInPageLink;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.TextBox confirmPasswordInput;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Button showConfirmPassword;
    }
}