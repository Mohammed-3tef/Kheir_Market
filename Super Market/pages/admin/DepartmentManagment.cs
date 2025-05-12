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

namespace Super_Market.pages.admin
{
    public partial class DepartmentManagment : Form
    {
        private MainWindow mainWindow;
        private int departmentID;
        private string departmentName;

        public DepartmentManagment(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void LoadDepartmentTable()
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"
                SELECT D.DID AS ID, D.NAME AS Name, C.NAME AS Category
                FROM DEPARTMENT D 
                JOIN CATEGORY C ON D.CID = C.CID
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView2.DataSource = table;
                dataGridView3.DataSource = table;
            }
        }

        private void DepartmentManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'super_Market_DataSet1.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter1.Fill(this.super_Market_DataSet1.CATEGORY);
            addCategoryComboBox.SelectedIndex = -1;
            LoadDepartmentTable();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        // --------------------------------------- CLEAR INPUTS
        private void clear_Inputs()
        {

            // --------------------------------------- ADD Inputs

            addDepartmentIdInput.Clear();
            addDepartmentNameInput.Clear();
            addCategoryComboBox.SelectedIndex = -1;

            // --------------------------------------- UPDATE Inputs

            updateDepartmentIdInput.Clear();
            updateDepartmentNameInput.Clear();
            updateCategorycomboBox.SelectedIndex = -1;
            updateBtn.Enabled = false;
            updateDepartmentNameInput.Enabled = false;
            updateCategorycomboBox.Enabled = false;


            // --------------------------------------- DELETE Inputs

            deleteDepartmentIdInput.Clear();

        }
        // --------------------------------------- ADD DEPARTMENT

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(addDepartmentIdInput.Text))
            {
                this.addDepartmentIdInput.Focus();
                return;
            }

            if (addCategoryComboBox.SelectedValue == null || string.IsNullOrWhiteSpace(addDepartmentNameInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a category and enter a department name.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                return;
            }

      
            this.departmentID = int.Parse(addDepartmentIdInput.Text);
            this.departmentName = addDepartmentNameInput.Text;
            int categoryId = (int)addCategoryComboBox.SelectedValue;

            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string checkDIDQuery = "SELECT COUNT(*) FROM DEPARTMENT WHERE DID = @DID";
            string checkCategoryQuery = "SELECT COUNT(*) FROM CATEGORY WHERE CID = @CID";
            string insertQuery = "INSERT INTO DEPARTMENT (DID, CID, NAME) VALUES (@DID, @CID, @NAME)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if DID already exists
                using (SqlCommand checkDIDCmd = new SqlCommand(checkDIDQuery, conn))
                {
                    checkDIDCmd.Parameters.AddWithValue("@DID", this.departmentID);
                    int didCount = (int)checkDIDCmd.ExecuteScalar();

                    if (didCount > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Department ID already exists.Take anthoer one", "Error",
                            (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                        return;
                    }
                }

                // Check if CID exists in CATEGORY (foreign key validation)
                using (SqlCommand checkCategoryCmd = new SqlCommand(checkCategoryQuery, conn))
                {
                    checkCategoryCmd.Parameters.AddWithValue("@CID", categoryId);
                    int cidCount = (int)checkCategoryCmd.ExecuteScalar();

                    if (cidCount == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Selected category is invalid.", "Error",
                            (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                        return;
                    }
                }

                // Proceed with insert if validations pass
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@DID", this.departmentID);
                    insertCmd.Parameters.AddWithValue("@CID", categoryId);
                    insertCmd.Parameters.AddWithValue("@NAME", this.departmentName);
                    insertCmd.ExecuteNonQuery();
                }
                clear_Inputs();
                System.Windows.Forms.MessageBox.Show("Add Department Successfully...", "Success",
                    (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                LoadDepartmentTable();
            }
        }

        // --------------------------------------- UPDATE CATEGORY

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(updateDepartmentIdInput.Text))
            {
                this.updateDepartmentIdInput.Focus();
                return;
            }

            this.departmentID = int.Parse(updateDepartmentIdInput.Text);
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = "SELECT NAME, CID FROM DEPARTMENT WHERE DID = @DID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DID", this.departmentID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Department found
                    string departmentName = reader.GetString(0);
                    int categoryId = reader.GetInt32(1);

                    updateDepartmentNameInput.Text = departmentName;
                    updateCategorycomboBox.SelectedValue = categoryId;

                    updateBtn.Enabled = true;
                    updateDepartmentNameInput.Enabled = true;
                    updateCategorycomboBox.Enabled = true;
                }
                else
                {
                    // Department not found
                    System.Windows.Forms.MessageBox.Show(
                        "Department Not Found...",
                        "Warning",
                        (MessageBoxButtons)MessageBoxButton.OK,
                        (MessageBoxIcon)MessageBoxImage.Warning
                    );

                    // Optional: disable update inputs if not found
                    updateBtn.Enabled = false;
                    updateDepartmentNameInput.Enabled = false;
                    updateCategorycomboBox.Enabled = false;
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(updateDepartmentIdInput.Text))
            {
                this.updateDepartmentIdInput.Focus();
                return;
            }

            if (updateCategorycomboBox.SelectedValue == null || string.IsNullOrWhiteSpace(updateDepartmentNameInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a category and enter a department name.");
                return;
            }

            this.departmentID = int.Parse(updateDepartmentIdInput.Text);
            this.departmentName = updateDepartmentNameInput.Text;
            int categoryId = (int)updateCategorycomboBox.SelectedValue;

            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string updateQuery = "UPDATE DEPARTMENT SET NAME = @NAME, CID = @CID WHERE DID = @DID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@NAME", this.departmentName);
                cmd.Parameters.AddWithValue("@CID", categoryId);
                cmd.Parameters.AddWithValue("@DID", this.departmentID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Update Department Successfully...", "Info",
                        (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Update Failed. Department may not exist.", "Error",
                        (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                }
            }
            updateDepartmentNameInput.Clear();
            updateCategorycomboBox.SelectedIndex = -1;
            updateBtn.Enabled = false;
            updateDepartmentNameInput.Enabled = false;
            updateCategorycomboBox.Enabled = false;
            clear_Inputs();
            LoadDepartmentTable();
        }

        // --------------------------------------- DELETE Department

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(deleteDepartmentIdInput.Text))
            {
                this.deleteDepartmentIdInput.Focus();
                return;
            }

            int departmentId = int.Parse(deleteDepartmentIdInput.Text);
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

            // First, check if the department exists
            string checkQuery = "SELECT COUNT(*) FROM DEPARTMENT WHERE DID = @DID";
            string deleteQuery = "DELETE FROM DEPARTMENT WHERE DID = @DID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@DID", departmentId);
                conn.Open();

                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Department Not Found...", "Warning",
                        (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                    return;
                }

                // Proceed with delete
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@DID", departmentId);
                    deleteCmd.ExecuteNonQuery();
                }

                System.Windows.Forms.MessageBox.Show("Delete Department Successfully...", "Info",
                    (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
            }
            clear_Inputs();
            LoadDepartmentTable();
        }
    }
}
