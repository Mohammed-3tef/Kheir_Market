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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            this.username = usernameInput.Text;
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            this.password = passwordInput.Text;
        }

        private void emailInput_TextChanged(object sender, EventArgs e)
        {
            this.email = emailInput.Text;
        }

        private void confirmPasswordInput_TextChanged(object sender, EventArgs e)
        {
            this.confirmPassword = confirmPasswordInput.Text;
        }

        private void adminBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.isAdmin = 1;
        }

        private void customerBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.isAdmin = 0;
        }

        private void logInPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.mainWindow == null) this.mainWindow = new MainWindow();
            this.mainWindow.Show();
            this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.username) || string.IsNullOrEmpty(this.password) || string.IsNullOrEmpty(this.confirmPassword) || string.IsNullOrEmpty(this.email) || this.isAdmin == -1){
                System.Windows.Forms.MessageBox.Show("Please fill in all fields.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                return;
            }

            if (this.password != this.confirmPassword){
                System.Windows.Forms.MessageBox.Show("Password and Confirm Password do not match.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                return;
            }

            // WRITE YOUR SIGN_UP LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Sign Up Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
            this.mainWindow.Show();
            this.Close();
        }
    }
}
