using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private MainWindow _mainWindow;
        private int _customerId;

        public CustomerManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this._mainWindow = mainWindow;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage= new AdminMenuPage(this._mainWindow);
            adminMenuPage.Show();
            this.Close();
        }
        // -------------------------------------- ADD CUSTOMER

        // -------------------------------------- UPDATE CUSTOMER
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (this._mainWindow.users.IsEmpty() == 0)
            {
                MessageDisplay.ShowError("There are currently no registered users !!");
                this.deleteCustomerIdInput.Focus();
                return;
            }
            else
            {
                // Load the customer list
            }
            
            if (!Validator.IsValidInteger(this.updateIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.updateIdInput.Focus();
                return;
            }

            this._customerId = int.Parse(this.updateIdInput.Text);
            
            if (this._mainWindow.users.getUserByID(this._customerId) == null)
            {
                MessageDisplay.ShowError("The specified user does not exist !!");
                this.updateIdInput.Focus();
                return;
            }
            this._mainWindow.user  = this._mainWindow.users.getUserByID(this._customerId);
            
            if (this._mainWindow.user.IsAdmin())
            {
                MessageDisplay.ShowError("Sorry U can't Edit Admin !!");
                this.updateIdInput.Focus();
                return;
            }
            
            this.updateNameInput.Text = this._mainWindow.user.GetUsername();
            this.updateEmailInput.Text = this._mainWindow.user.GetEmail();
            this.updatePhoneInput.Text = this._mainWindow.user.GetPhone();
            this.updateAddressInput.Text = this._mainWindow.user.GetAddress();
            
            this.updateBtn.Enabled = true;
            this.updateNameInput.Enabled = true;
            this.updateEmailInput.Enabled = true;
            this.updatePhoneInput.Enabled = true;
            this.updateAddressInput.Enabled = true;
        }
        
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string userName = this.updateNameInput.Text;
            string userEmail = this.updateEmailInput.Text;
            string userPhone = this.updatePhoneInput.Text;
            string userAddress = this.updateAddressInput.Text;
            
            if (!Validator.IsValidInteger(this.updateIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.updateIdInput.Focus();
                return;
            }
            if (string.IsNullOrEmpty(userName) || !Validator.IsValidName(userName))
            {
                MessageDisplay.ShowError("Please enter a valid name !!");
                this.updateNameInput.Focus();
                return;
            }
            if (string.IsNullOrEmpty(userEmail) || !Validator.IsValidEmail(userEmail))
            {
                MessageDisplay.ShowError("Please enter a valid email !!");
                this.updateEmailInput.Focus();
                return;
            }
            if (string.IsNullOrEmpty(userPhone) || !Validator.IsValidPhone(userPhone))
            {
                MessageDisplay.ShowError("Please enter a valid phone !!");
                this.updatePhoneInput.Focus();
                return;
            }
            if (string.IsNullOrEmpty(userAddress) || !Validator.IsValidAddress(userAddress))
            {
                MessageDisplay.ShowError("Please enter a valid address !!");
                this.updateAddressInput.Focus();
                return;
            }
            
            this._mainWindow.user.setData(userName, userEmail, userPhone, userAddress);
            this._mainWindow.users.updateUser(this._mainWindow.user);
            MessageDisplay.ShowSuccess("Update Customer Successfully...");
            
            this.updateNameInput.Text = "";
            this.updateEmailInput.Text = "";
            this.updatePhoneInput.Text = "";
            this.updateAddressInput.Text = "";
            this.updateIdInput.Text = "";
            
            this.updateBtn.Enabled = false;
            this.updateNameInput.Enabled = false;
            this.updateEmailInput.Enabled = false;
            this.updatePhoneInput.Enabled = false;
            this.updateAddressInput.Enabled = false;
            
            this.updateIdInput.Focus();
        }
        

        // -------------------------------------- DELETE CUSTOMER
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this._mainWindow.users.IsEmpty() == 0)
            {
                MessageDisplay.ShowError("There are currently no registered users !!");
                this.deleteCustomerIdInput.Focus();
                return;
            }
            else
            {
                // Load the customer list
            }
            
            if (!Validator.IsValidInteger(this.deleteCustomerIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.deleteCustomerIdInput.Focus();
                return;
            }

            this._customerId = int.Parse(this.deleteCustomerIdInput.Text);
            User user = this._mainWindow.users.getUserByID(this._customerId);
            
            if (user == null){
                MessageDisplay.ShowError("The specified user does not exist !!");
                this.deleteCustomerIdInput.Focus();
                return;
            }
            
            if (user.IsAdmin())
            {
                MessageDisplay.ShowError("Sorry U can't Edit Admin !!");
                this.deleteCustomerIdInput.Focus();
                return;
            }

            this._mainWindow.users.deleteUser(user);
            MessageDisplay.ShowSuccess("Delete Customer Successfully...");
        }
    }
}
