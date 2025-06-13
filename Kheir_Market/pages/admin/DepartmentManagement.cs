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
using Kheir_Market.packages.display;
using Kheir_Market.packages.validation;

namespace Kheir_Market.pages.admin
{
    public partial class DepartmentManagement : Form
    {
        private MainWindow mainWindow;
        private int departmentID;
        private string departmentName;
        private const string connectionString = "Data Source=.;Initial Catalog=Kheir_Market;Integrated Security=True;";

        public DepartmentManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            this.FormClosing += this.mainWindow.formClosing;
        }

        private void LoadDepartmentTable()
        {
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
            this.cATEGORYTableAdapter.Fill(this.Kheir_Market_DataSet.CATEGORY);
            addCategoryComboBox.SelectedIndex = -1;
            updateCategorycomboBox.SelectedIndex = -1;
            LoadDepartmentTable();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.FormClosing -= this.mainWindow.formClosing;
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
            if (!Validator.IsValidInteger(addDepartmentIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid department ID.");
                this.addDepartmentIdInput.Focus();
                return;
            }

            if (UniquenessValidator.DoesDepartmentIDExist(int.Parse(addDepartmentIdInput.Text)))
            {
                MessageDisplay.ShowError("Department ID already exists.");
                this.addDepartmentIdInput.Focus();
                return;
            }

            if (!Validator.IsValidName(addDepartmentNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid department name.");
                this.addDepartmentNameInput.Focus();
                return;
            }

            if (addCategoryComboBox.SelectedValue == null)
            {
                MessageDisplay.ShowError("Please select a category.");
                this.addCategoryComboBox.Focus();
                return;
            }

            this.departmentID = int.Parse(addDepartmentIdInput.Text);
            this.departmentName = addDepartmentNameInput.Text;
            int categoryId = (int)addCategoryComboBox.SelectedValue;

            string insertQuery = "INSERT INTO DEPARTMENT (DID, CID, NAME) VALUES (@DID, @CID, @NAME)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Proceed with insert if validations pass
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@DID", this.departmentID);
                    insertCmd.Parameters.AddWithValue("@CID", categoryId);
                    insertCmd.Parameters.AddWithValue("@NAME", this.departmentName);
                    insertCmd.ExecuteNonQuery();
                }

                clear_Inputs();
                MessageDisplay.ShowSuccess("Department added successfully.");
                LoadDepartmentTable();
            }
        }

        // --------------------------------------- UPDATE CATEGORY

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(updateDepartmentIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid department ID.");
                this.updateDepartmentIdInput.Focus();
                return;
            }

            this.departmentID = int.Parse(updateDepartmentIdInput.Text);
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
                    MessageDisplay.ShowError("Department Not Found...");
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(updateDepartmentIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid department ID.");
                this.updateDepartmentIdInput.Focus();
                return;
            }

            if (!Validator.IsValidName(updateDepartmentNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid department name.");
                this.addDepartmentNameInput.Focus();
                return;
            }

            if (updateCategorycomboBox.SelectedValue == null)
            {
                MessageDisplay.ShowError("Please select a category.");
                this.addCategoryComboBox.Focus();
                return;
            }

            this.departmentID = int.Parse(updateDepartmentIdInput.Text);
            this.departmentName = updateDepartmentNameInput.Text;
            int categoryId = (int)updateCategorycomboBox.SelectedValue;

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
                    MessageDisplay.ShowSuccess("Department updated successfully.");
                }
                else
                {
                    MessageDisplay.ShowError("Update Failed. Department may not exist.");
                }
            }

            clear_Inputs();
            LoadDepartmentTable();
        }

        // --------------------------------------- DELETE Department

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(deleteDepartmentIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid department ID.");
                this.deleteDepartmentIdInput.Focus();
                return;
            }

            if (!UniquenessValidator.DoesDepartmentIDExist(int.Parse(deleteDepartmentIdInput.Text)))
            {
                MessageDisplay.ShowError("Department Not Found...");
                this.deleteDepartmentIdInput.Focus();
                return;
            }

            int departmentId = int.Parse(deleteDepartmentIdInput.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Start a transaction to ensure all deletes happen atomically
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 2. Delete PRODUCTS related to this department
                        string deleteProductQuery = "DELETE FROM PRODUCT WHERE DID = @DID";
                        using (SqlCommand deleteProductCmd = new SqlCommand(deleteProductQuery, conn, transaction))
                        {
                            deleteProductCmd.Parameters.AddWithValue("@DID", departmentId);
                            deleteProductCmd.ExecuteNonQuery();
                        }
                        // 1. Delete STOCK entries related to PRODUCTS in this department
                        string deleteStockQuery = @"
                            DELETE S
                            FROM STOCK S
                            INNER JOIN PRODUCT P ON S.PROD_ID = P.PID
                            WHERE P.DID = @DID";
                        using (SqlCommand deleteStockCmd = new SqlCommand(deleteStockQuery, conn, transaction))
                        {
                            deleteStockCmd.Parameters.AddWithValue("@DID", departmentId);
                            deleteStockCmd.ExecuteNonQuery();
                        }
                        // 3. Finally, delete the DEPARTMENT
                        string deleteDepartmentQuery = "DELETE FROM DEPARTMENT WHERE DID = @DID";
                        using (SqlCommand deleteDepartmentCmd = new SqlCommand(deleteDepartmentQuery, conn, transaction))
                        {
                            deleteDepartmentCmd.Parameters.AddWithValue("@DID", departmentId);
                            deleteDepartmentCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageDisplay.ShowSuccess("Department deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageDisplay.ShowError("Delete failed: " + ex.Message);
                    }
                }
            }

            clear_Inputs();
            LoadDepartmentTable();
        }
    }
}
