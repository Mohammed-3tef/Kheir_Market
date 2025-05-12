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
            if (this.mainWindow == null) this.mainWindow = new MainWindow();
            this.mainWindow.Show();
            this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.usernameInput.Text) || string.IsNullOrEmpty(this.passwordInput.Text) || string.IsNullOrEmpty(this.confirmPasswordInput.Text) || string.IsNullOrEmpty(this.emailInput.Text) || string.IsNullOrEmpty(this.phoneInput.Text) || this.isAdmin == -1){
                System.Windows.Forms.MessageBox.Show("Please fill in all fields.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                return;
            }

            if (!this.mainWindow.isValidEmail(this.emailInput.Text)){
                System.Windows.Forms.MessageBox.Show("Please enter a valid email.", "Error", 
                    (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.emailInput.Focus();
                return;
            }

            if (!this.mainWindow.isValidPhone(this.phoneInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid phone number.", "Error",
                    (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.phoneInput.Focus();
                return;
            }

            if (this.password != this.confirmPassword){
                System.Windows.Forms.MessageBox.Show("Password and Confirm Password do not match.", "Error", 
                    (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.confirmPasswordInput.Focus();
                return;
            }

            // WRITE YOUR SIGN_UP LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Sign Up Successfully...", "Info", 
                (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
            
            if (isAdmin == 1)
            {
                AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
                adminMenuPage.Show();
                this.Close();
            } else {
                CustomerMenuPage customerMenuPage = new CustomerMenuPage(this.mainWindow);
                customerMenuPage.Show();
                this.Close();
            }

            this.Close();
        }
    }
}
