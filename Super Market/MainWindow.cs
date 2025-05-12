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

namespace Super_Market
{
    public partial class MainWindow : Form
    {
        private int userID;
        private string username;
        private string password;
        private bool isAdmin = true;

        public int getUserId(){
            return this.userID;
        }

        public string getUsername(){
            return this.username;
        }

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

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            this.username = usernameInput.Text;
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            this.password = passwordInput.Text;
        }

        private void signUpPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
            this.Hide();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.username) || string.IsNullOrEmpty(this.password)){
                System.Windows.Forms.MessageBox.Show("Please fill in all fields.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                return;
            }

            // WRITE YOUR LOGIN LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Log In Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
            switch (!isAdmin){
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
    }
}
