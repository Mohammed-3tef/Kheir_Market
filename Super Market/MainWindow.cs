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
                System.Windows.Forms.MessageBox.Show("Please enter a valid integer.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                return false;
            }
            else if (!input.All(char.IsDigit))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid integer.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void signUpPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
            this.Hide();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            MessageDisplay.ShowInfo(this.usernameInput.Text);
            MessageDisplay.ShowInfo(this.passwordInput.Text);

            if (!Validator.IsValidName(this.usernameInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid username.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.usernameInput.Focus();
                return;
            }
            
            if(!Validator.IsValidPassword(this.passwordInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid password.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.passwordInput.Focus();
                return;
            }
            
            tempName = this.usernameInput.Text;
            tempPassword = this.passwordInput.Text;
            // load user data from repository
            user = users.getUser(this.tempName, this.tempPassword);
            MessageDisplay.ShowSuccess("Log In Successfully...");
            switch (user.IsAdmin()){
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

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            this.passwordInput.PasswordChar = '*';
        }
    }
}
