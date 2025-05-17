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
            this.mainWindow.users.addUser(user);
            this.mainWindow.user = user;

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
