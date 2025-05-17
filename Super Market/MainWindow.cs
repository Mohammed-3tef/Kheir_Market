using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Super_Market.pages;
using System.Text.RegularExpressions;
using Super_Market.packages.display;
using Super_Market.packages.User;
using System.Security.Policy;


namespace Super_Market
{
    public partial class MainWindow : Form
    {
        public RepositoryOfUsers users = new RepositoryOfUsers();
        public User user;
        string tempName , tempPassword;

        public bool isValidInteger(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageDisplay.ShowError("Please enter a valid integer.");
                return false;
            }
            else if (!input.All(char.IsDigit))
            {
                MessageDisplay.ShowError("Please enter a valid integer.");
                return false;
            }

            return true;
        }

        public MainWindow()
        {
            InitializeComponent();
            this.passwordInput.PasswordChar = '*';
        }

        private void signUpPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
            this.Hide();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidName(this.usernameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid username.");
                this.usernameInput.Focus();
                return;
            }
            
            if(!Validator.IsValidPassword(this.passwordInput.Text))
            {
                MessageDisplay.ShowError("Password must be at least 8 characters long and contain: \nat least one uppercase letter, one lowercase letter, one digit, and one special character.");
                this.passwordInput.Focus();
                return;
            }
            
            tempName = this.usernameInput.Text;
            tempPassword = this.passwordInput.Text;

            // load user data from repository
            this.user = this.users.getUser(this.tempName, this.tempPassword);
            MessageDisplay.ShowSuccess("Log In Successfully...");

            switch (this.user.IsAdmin()){
                case true:
                    AdminMenuPage adminMenuPage = new AdminMenuPage(this);
                    adminMenuPage.Show();
                    this.Hide();
                    break;
                case false:
                    CustomerMenuPage customerMenuPage = new CustomerMenuPage(this);
                    customerMenuPage.Show();
                    this.Hide();
                    break;
                default:
                    return;
            }
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
    }
}
