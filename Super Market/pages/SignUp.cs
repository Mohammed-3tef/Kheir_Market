using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Super_Market.packages.display;
using Super_Market.packages.User;

namespace Super_Market.pages
{
    public partial class SignUp : Form
    {
        private MainWindow mainWindow;
        private string username;
        private string email;
        private string phone;
        private string address;
        private string password;
        
        public SignUp(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            this.passwordInput.PasswordChar = '*';
            this.confirmPasswordInput.PasswordChar = '*';
        }

        private void logInPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mainWindow == null) this.mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if(!Validator.IsValidName(this.usernameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid name.");
                this.usernameInput.Focus();
                return;
            }

            if (!Validator.IsValidEmail(this.emailInput.Text)){
                MessageDisplay.ShowError("Please enter a valid email.");
                this.emailInput.Focus();
                return;
            }

            if (!Validator.IsValidPhone(this.phoneInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid phone number.");
                this.phoneInput.Focus();
                return;
            }
            
            if (!Validator.IsValidAddress(this.addressInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid address.\n" +
                                         "Example: 13st Tahrir, Dokki, Giza");
                this.addressInput.Focus();
                return;
            }

            if (!Validator.IsValidPassword(this.passwordInput.Text))
            {
                MessageDisplay.ShowError("Password must be at least 8 characters long and contain: \nat least one uppercase letter, one lowercase letter, one digit, and one special character.");
                this.passwordInput.Focus();
                return;
            }

            if (this.passwordInput.Text != this.confirmPasswordInput.Text)
            {
                MessageDisplay.ShowError("Password and Confirm Password do not match.");
                this.confirmPasswordInput.Focus();
                return;
            }

            this.username = this.usernameInput.Text;
            this.password = this.passwordInput.Text;
            this.phone = this.phoneInput.Text;
            this.address = this.addressInput.Text;
            this.email = this.emailInput.Text;

            int userID = 1;
            while (this.mainWindow.users.getUserByID(userID) != null){
                userID++;
            }

            User user = new User(userID, this.username, this.email, this.phone, this.address, false , this.password);
            this.mainWindow.user = user;

            MessageDisplay.ShowSuccess("OTP Send Successfully...");

            OTPVerifyPage oTPVerifyPage = new OTPVerifyPage(this.mainWindow);
            oTPVerifyPage.Show();
            this.Close();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (this.passwordInput.PasswordChar == '*')
            {
                this.passwordInput.PasswordChar = '\0';
                this.showPassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                this.passwordInput.PasswordChar = '*';
                this.showPassword.BackgroundImage = Properties.Resources.show;
            }
        }

        private void showConfirmPassword_Click(object sender, EventArgs e)
        {
            if (this.confirmPasswordInput.PasswordChar == '*')
            {
                this.confirmPasswordInput.PasswordChar = '\0';
                this.showConfirmPassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                this.confirmPasswordInput.PasswordChar = '*';
                this.showConfirmPassword.BackgroundImage = Properties.Resources.show;
            }
        }

        private void githubRepo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mohammed-3tef/Super_Market_Management_System");
        }
    }
}
