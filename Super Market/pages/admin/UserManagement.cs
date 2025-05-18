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
using Super_Market.packages.validation;

namespace Super_Market.pages
{
    public partial class UserManagement : Form
    {
        private MainWindow _mainWindow;
        private int _customerId;
        private const string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

        public UserManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this._mainWindow = mainWindow;
            this.addPasswordInput.PasswordChar = '*';
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            loadUserList();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this._mainWindow.users.refreshUsers();
            AdminMenuPage adminMenuPage= new AdminMenuPage(this._mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        private void loadUserList()
        {
            string query = "SELECT * FROM [USER] ORDER BY UID;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView1.DataSource = table;
                this.dataGridView2.DataSource = table;
                this.dataGridView3.DataSource = table;
            }
        }

        private void clearInputs()
        {
            this.addIdInput.Clear();
            this.addNameInput.Clear();
            this.addEmailInput.Clear();
            this.addPhoneInput.Clear();
            this.addAddressInput.Clear();
            this.addPasswordInput.Clear();
            this.addAdminBtn.Checked = false;
            this.addCustomerBtn.Checked = false;

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
            this.updateBtn.Enabled = false;

            this.deleteIdInput.Clear();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (this.addPasswordInput.PasswordChar == '*')
            {
                this.addPasswordInput.PasswordChar = '\0';
                this.showPassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                this.addPasswordInput.PasswordChar = '*';
                this.showPassword.BackgroundImage = Properties.Resources.show;
            }
        }

        // -------------------------------------- ADD CUSTOMER

        private void addBtn_Click(object sender, EventArgs e)
        {
            this._mainWindow.users.refreshUsers();

            if (!Validator.IsValidInteger(this.addIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.addIdInput.Focus();
                return;
            }

            if (UniquenessValidator.DoesUserIDExist(int.Parse(this.addIdInput.Text)))
            {
                MessageDisplay.ShowError("The specified ID already exists !!");
                this.addIdInput.Focus();
                return;
            }

            if (!Validator.IsValidName(this.addNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid name !!");
                this.addNameInput.Focus();
                return;
            }

            if (!Validator.IsValidPhone(this.addPhoneInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid phone !!");
                this.addPhoneInput.Focus();
                return;
            }

            if (!Validator.IsValidEmail(this.addEmailInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid email !!");
                this.addEmailInput.Focus();
                return;
            }

            if (!Validator.IsValidAddress(this.addAddressInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid address.\n" +
                                     "Example: 13st Tahrir, Dokki, Giza");
                this.addAddressInput.Focus();
                return;
            }

            if (!Validator.IsValidPassword(this.addPasswordInput.Text))
            {
                MessageDisplay.ShowError("Password must be at least 8 characters long and contain: \nat least one uppercase letter, one lowercase letter, one digit, and one special character.");
                this.addPasswordInput.Focus();
                return;
            }

            bool isAdmin;

            if (this.addAdminBtn.Checked) isAdmin = true;
            else if (this.addCustomerBtn.Checked) isAdmin = false;
            else
            {
                MessageDisplay.ShowError("Please select a user type !!");
                return;
            }

            User user = new User(
                int.Parse(this.addIdInput.Text),
                this.addNameInput.Text,
                this.addEmailInput.Text,
                this.addPhoneInput.Text,
                this.addAddressInput.Text,
                isAdmin,
                this.addPasswordInput.Text
            );

            this._mainWindow.users.addUser(user);
            MessageDisplay.ShowSuccess("Add Customer Successfully...");
            loadUserList();
            clearInputs();
        }

        // -------------------------------------- UPDATE CUSTOMER
        private void searchBtn_Click(object sender, EventArgs e)
        {
            this._mainWindow.users.refreshUsers();

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

            this.updateNameInput.Text = this._mainWindow.user.GetUsername().Trim();
            this.updateEmailInput.Text = this._mainWindow.user.GetEmail().Trim();
            this.updatePhoneInput.Text = this._mainWindow.user.GetPhone().Trim();
            this.updateAddressInput.Text = this._mainWindow.user.GetAddress().Trim();

            if (this._mainWindow.user.IsAdmin()) this.addAdminBtn.Checked = true;
            else this.addCustomerBtn.Checked = true;
            
            this.updateBtn.Enabled = true;
            this.updateNameInput.Enabled = true;
            this.updateEmailInput.Enabled = true;
            this.updatePhoneInput.Enabled = true;
            this.updateAddressInput.Enabled = true;
            this.addAdminBtn.Enabled = true;
            this.addCustomerBtn.Enabled = true;
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
                MessageDisplay.ShowError("Please enter a valid address.\n" +
                                     "Example: 13st Tahrir, Dokki, Giza");
                this.updateAddressInput.Focus();
                return;
            }

            this._mainWindow.user.setData(userName, userEmail, userPhone, userAddress, this._mainWindow.user.IsAdmin());
            this._mainWindow.users.updateUser(this._mainWindow.user);
            MessageDisplay.ShowSuccess("Update Customer Successfully...");
            loadUserList();
            clearInputs();
        }
        
        // -------------------------------------- DELETE CUSTOMER
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this._mainWindow.users.refreshUsers();

            if (!Validator.IsValidInteger(this.deleteIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid ID !!");
                this.deleteIdInput.Focus();
                return;
            }

            this._customerId = int.Parse(this.deleteIdInput.Text);
            User user = this._mainWindow.users.getUserByID(this._customerId);
            
            if (user == null){
                MessageDisplay.ShowError("The specified user does not exist !!");
                this.deleteIdInput.Focus();
                return;
            }

            this._mainWindow.users.deleteUser(user);
            MessageDisplay.ShowSuccess("Delete Customer Successfully...");
            loadUserList();
            clearInputs();
        }
    }
}
