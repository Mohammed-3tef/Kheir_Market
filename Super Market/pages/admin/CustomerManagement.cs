using System;
using System.Collections;
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
        private const string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

        public CustomerManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this._mainWindow = mainWindow;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            loadUserList();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage= new AdminMenuPage(this._mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        private void loadUserList()
        {
            string query = "SELECT * FROM [USER]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView1.DataSource = table;
                this.dataGridView2.DataSource = table;
            }
        }

        private void clearInputs()
        {
            this.updateNameInput.Clear();
            this.updateEmailInput.Clear();
            this.updatePhoneInput.Clear();
            this.updateAddressInput.Clear();
            this.updateIdInput.Clear();

            this.updateBtn.Enabled = false;
            this.updateNameInput.Enabled = false;
            this.updateEmailInput.Enabled = false;
            this.updatePhoneInput.Enabled = false;
            this.updateAddressInput.Enabled = false;
            this.updateAdminBtn.Enabled = false;
            this.updateCustomerBtn.Enabled = false;
            this.updateBtn.Enabled = false;

            this.deleteCustomerIdInput.Clear();
        }

        // -------------------------------------- ADD CUSTOMER

        // -------------------------------------- UPDATE CUSTOMER
        private void searchBtn_Click(object sender, EventArgs e)
        {
            this._mainWindow.users.refreshUsers();

            if (this._mainWindow.users.IsEmpty() == 0)
            {
                MessageDisplay.ShowError("There are currently no registered users !!");
                this.deleteCustomerIdInput.Focus();
                return;
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
                MessageDisplay.ShowError("Sorry you can't Edit Admin !!");
                this.updateIdInput.Focus();
                return;
            }
            
            this.updateNameInput.Text = this._mainWindow.user.GetUsername();
            this.updateEmailInput.Text = this._mainWindow.user.GetEmail();
            this.updatePhoneInput.Text = this._mainWindow.user.GetPhone();
            this.updateAddressInput.Text = this._mainWindow.user.GetAddress();

            if (this._mainWindow.user.IsAdmin()) this.updateAdminBtn.Checked = true;
            else this.updateCustomerBtn.Checked = true;
            
            this.updateBtn.Enabled = true;
            this.updateNameInput.Enabled = true;
            this.updateEmailInput.Enabled = true;
            this.updatePhoneInput.Enabled = true;
            this.updateAddressInput.Enabled = true;
            this.updateAdminBtn.Enabled = true;
            this.updateCustomerBtn.Enabled = true;
        }
        
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string userName = this.updateNameInput.Text;
            string userEmail = this.updateEmailInput.Text;
            string userPhone = this.updatePhoneInput.Text;
            string userAddress = this.updateAddressInput.Text;
            bool isAdmin;

            if (!Validator.IsValidInteger(this.updateIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.updateIdInput.Focus();
                return;
            }

            if (!Validator.IsValidName(userName))
            {
                MessageDisplay.ShowError("Please enter a valid name !!");
                this.updateNameInput.Focus();
                return;
            }

            if (!Validator.IsValidEmail(userEmail))
            {
                MessageDisplay.ShowError("Please enter a valid email !!");
                this.updateEmailInput.Focus();
                return;
            }

            if (!Validator.IsValidPhone(userPhone))
            {
                MessageDisplay.ShowError("Please enter a valid phone !!");
                this.updatePhoneInput.Focus();
                return;
            }

            if (!Validator.IsValidAddress(userAddress))
            {
                MessageDisplay.ShowError("Please enter a valid address !!");
                this.updateAddressInput.Focus();
                return;
            }
            
            if (this.updateAdminBtn.Checked) isAdmin = true;
            else if (this.updateCustomerBtn.Checked) isAdmin = false;
            else{
                MessageDisplay.ShowError("Please select a user type !!");
                return;
            }

            this._mainWindow.user.setData(userName, userEmail, userPhone, userAddress, isAdmin);
            this._mainWindow.users.updateUser(this._mainWindow.user);
            MessageDisplay.ShowSuccess("Update Customer Successfully...");
            loadUserList();
            clearInputs();
        }
        
        // -------------------------------------- DELETE CUSTOMER
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this._mainWindow.users.refreshUsers();

            if (this._mainWindow.users.IsEmpty() == 0)
            {
                MessageDisplay.ShowError("There are currently no registered users !!");
                this.deleteCustomerIdInput.Focus();
                return;
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
                MessageDisplay.ShowError("Sorry you can't Edit Admin !!");
                this.deleteCustomerIdInput.Focus();
                return;
            }

            this._mainWindow.users.deleteUser(user);
            MessageDisplay.ShowSuccess("Delete Customer Successfully...");
            loadUserList();
            clearInputs();
        }
    }
}
