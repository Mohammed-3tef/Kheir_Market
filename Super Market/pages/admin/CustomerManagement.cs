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
using Super_Market.packages.display;
using Super_Market.packages.User;

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
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.updateIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.updateIdInput.Focus();
                return;
            }

            this.customerID = int.Parse(this.updateIdInput.Text);

            // WRITE YOUR UPDATE LOGIC HERE



            //
        }
        
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.updateIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.updateIdInput.Focus();
                return;
            }

            this.customerID = int.Parse(this.deleteCustomerIdInput.Text);
            User user = this.mainWindow.users.getUserByID(this.customerID);

            if (user == null){
                MessageDisplay.ShowError("User doesn't Exist !!");
                this.updateIdInput.Focus();
                return;
            }

            // Print For User Data Ya Atef

            this.updateBtn.Enabled = true;
        }

        // -------------------------------------- DELETE CUSTOMER
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.deleteCustomerIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.deleteCustomerIdInput.Focus();
                return;
            }

            this.customerID = int.Parse(this.deleteCustomerIdInput.Text);
            User user = this.mainWindow.users.getUserByID(this.customerID);

            if (user == null){
                MessageDisplay.ShowError("User doesn't Exist !!");
                this.deleteCustomerIdInput.Focus();
                return;
            }

            this.mainWindow.users.deleteUser(user);
            MessageDisplay.ShowSuccess("Delete Customer Successfully...");
        }
    }
}
