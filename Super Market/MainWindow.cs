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
        private string username;
        private string password;

        public string getUsername(){
            return this.username;
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
            if (string.IsNullOrEmpty(this.username) || string.IsNullOrEmpty(this.password))
            {
                System.Windows.Forms.MessageBox.Show("Please fill in all fields.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                return;
            }

            System.Windows.Forms.MessageBox.Show("Log In Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
            AdminMenuPage menuPage = new AdminMenuPage(this);
            menuPage.Show();
            this.Hide();
        }
    }
}
