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

namespace Super_Market.pages
{
    public partial class SignUp : Form
    {
        private MainWindow mainWindow;
        private string username;
        private string email;
        private string password;
        private string confirmPassword;
        private int isAdmin = -1;

        public SignUp(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void adminBtn_CheckedChanged(object sender, EventArgs e){
            this.isAdmin = 1;
        }

        private void customerBtn_CheckedChanged(object sender, EventArgs e){
            this.isAdmin = 0;
        }

        private void logInPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mainWindow.Show();
            this.Close();
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

            if (this.password != this.confirmPassword)
            {
                MessageDisplay.ShowError("Password and Confirm Password do not match.");
                this.confirmPasswordInput.Focus();
                return;
            }

            if (this.isAdmin == -1)
            {
                MessageDisplay.ShowError("Please select a user type.");
                return;
            }

            // WRITE YOUR SIGN_UP LOGIC HERE



            //

            MessageDisplay.ShowSuccess("OTP Send Successfully...");

            OTPVerifyPage oTPVerifyPage = new OTPVerifyPage(this.mainWindow);
            oTPVerifyPage.Show();
            this.Close();
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            this.passwordInput.PasswordChar = '*';
        }

        private void confirmPasswordInput_TextChanged(object sender, EventArgs e)
        {
            this.confirmPasswordInput.PasswordChar = '*';
        }
    }
}
