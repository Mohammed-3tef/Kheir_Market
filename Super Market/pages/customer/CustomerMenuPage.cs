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

using Super_Market.pages.customer;

namespace Super_Market.pages
{
    public partial class CustomerMenuPage : Form
    {
        private MainWindow mainWindow;

        public CustomerMenuPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.welcomePersonMsg.Text = "Welcome, " + this.mainWindow.getUsername();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No) return;
            this.mainWindow.Show();
            this.Close();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement(this.mainWindow);
            orderManagement.Show();
            this.Close();
        }
    }
}
