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
    public partial class CustomerManagement : Form
    {
        private MainWindow mainWindow;
        private int customerID;

        public CustomerManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage= new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        // -------------------------------------- UPDATE CUSTOMER
        private void updateCustomerIdInput_TextChanged(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.updateCustomerIdInput.Text)) return;
            this.customerID = int.Parse(this.updateCustomerIdInput.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // WRITE YOUR SEARCH CUSTOMER_ID LOGIC HERE



            //

            bool isFound = false;
            if (!isFound){
                System.Windows.Forms.MessageBox.Show("Customer Not Found...", "Warning", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            // WRITE YOUR SEARCH CUSTOMER_ID LOGIC HERE



            //

            this.updateBtn.Enabled = true;
        }

        private void refreshBtn1_Click(object sender, EventArgs e)
        {
            // WRITE YOUR REFRESH BTN1 LOGIC HERE



            //
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // WRITE YOUR UPDATE LOGIC HERE



            //
        }

        // -------------------------------------- DELETE CUSTOMER

        private void deleteCustomerIdInput_TextChanged(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.deleteCustomerIdInput.Text)) return;
            this.customerID = int.Parse(this.deleteCustomerIdInput.Text);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // WRITE YOUR DELETE LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Delete Customer Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            // WRITE THE SAME YOUR REFRESH BTN1 LOGIC HERE



            //
        }
    }
}
