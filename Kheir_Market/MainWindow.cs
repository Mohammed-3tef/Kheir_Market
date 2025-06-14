﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kheir_Market.pages;
using System.Text.RegularExpressions;
using Kheir_Market.packages.display;
using Kheir_Market.packages.User;
using System.Security.Policy;

namespace Kheir_Market
{
    public partial class MainWindow : Form
    {
        public RepositoryOfUsers users = new RepositoryOfUsers();
        public User user;
        string tempName , tempPassword;

        public MainWindow()
        {
            InitializeComponent();
            this.passwordInput.PasswordChar = '*';

            this.FormClosing += formClosing;
        }

        public void formClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is being closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Ask for confirmation before closing
                DialogResult result = System.Windows.Forms.MessageBox.Show(
                    "Are you sure you want to exit?", "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No) e.Cancel = true; // Cancel the close event
                else System.Windows.Forms.Application.Exit(); // Kill the entire application
            }
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
            if (this.user == null)
            {
                MessageDisplay.ShowError("Invalid username or password.");
                this.usernameInput.Focus();
                return;
            }

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

        private void githubRepo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mohammed-3tef/Kheir_Market");
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            // check if the AboutPage is already open
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form is AboutPage)
                {
                    form.BringToFront();
                    return;
                }
            }

            AboutPage aboutPage = new AboutPage();
            aboutPage.Show();
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
