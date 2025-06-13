using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kheir_Market.packages.otp;
using System.Windows.Threading;
using Kheir_Market.packages.display;
using System.Windows.Controls.Primitives;
using Kheir_Market.packages.User;

namespace Kheir_Market.pages
{
    public partial class OTPVerifyPage : Form
    {
        private MainWindow mainWindow;
        private OTPService otpService = new OTPService();
        private DispatcherTimer timer;
        public OTPVerifyPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.otpService.SendOTP(this.mainWindow.user.GetUsername(),this.mainWindow.user.GetEmail());
            StartEnableTimer();

            this.FormClosing += this.mainWindow.formClosing;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.resendBtn.Enabled = true;
            this.timer.Stop();
        }

        private void StartEnableTimer()
        {
            this.resendBtn.Enabled = false;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(30);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.mainWindow = new MainWindow();
            this.mainWindow.Show();
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (this.otpInput.Text == this.otpService.GetOTP() && Validator.IsValidInteger(this.otpInput.Text))
            {
                this.mainWindow.users.addUser(this.mainWindow.user);
                CustomerMenuPage customerMenuPage = new CustomerMenuPage(this.mainWindow);
                customerMenuPage.Show();
                this.FormClosing -= this.mainWindow.formClosing;
                this.Close();
            }
            else
            {
                MessageDisplay.ShowError("Invalid OTP code. Please try again.");
                this.otpInput.Focus();
            }
        }

        private void resendBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.otpService.SendOTP(this.mainWindow.user.GetUsername(),this.mainWindow.user.GetEmail());
            StartEnableTimer();
        }

        private void logInPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mainWindow.Show();
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
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
    }
}
