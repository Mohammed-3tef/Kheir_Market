using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Super_Market.packages.otp;
using System.Windows.Threading;
using Super_Market.packages.display;
using System.Windows.Controls.Primitives;

namespace Super_Market.pages
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
            //this.otpService.SendOTP(mainWindow.getUsername(), mainWindow.getEmail());
            StartEnableTimer();
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
            SignUp signUp = new SignUp(this.mainWindow);
            signUp.Show();
            this.Close();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (this.otpInput.Text == this.otpService.GetOTP() && Validator.IsValidInteger(this.otpInput.Text))
            {
                

                return;
            }

            MessageDisplay.ShowError("Invalid OTP code. Please try again.");
            this.otpInput.Focus();
        }

        private void resendBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.otpService.SendOTP(mainWindow.getUsername(), mainWindow.getEmail());
            StartEnableTimer();
        }

        private void logInPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mainWindow.Show();
            this.Close();
        }
    }
}
