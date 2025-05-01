using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private bool isAdmin;

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
            if (adminBtn.Checked)
                this.isAdmin = true;
        }

        private void customerBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (customerBtn.Checked)
                this.isAdmin = false;
        }

        private void logInPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.mainWindow == null) this.mainWindow = new MainWindow();
            this.mainWindow.Show();
            this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign Up Successfully...");
            if (this.mainWindow == null) this.mainWindow = new MainWindow();
            this.mainWindow.Show();
            this.Close();
        }
    }
}
