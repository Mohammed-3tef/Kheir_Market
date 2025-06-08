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

namespace Kheir_Market.pages
{
    public partial class CategoryManagement : Form
    {
        private MainWindow mainWindow;
        private int categoryID;
        private string categoryName;
        private const string connectionString = "Data Source=.;Initial Catalog=Kheir_Market;Integrated Security=True;";

        public CategoryManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'super_Market_DataSet1.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.Kheir_Market_DataSet.CATEGORY);
        }

        
        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        private void clear_Inputs()
        {
            // --------------------------------------- ADD Inputs

            addCategoryIdInput.Clear();
            addCategoryNameInput.Clear();
           
            // --------------------------------------- UPDATE Inputs

            updateCategoryIdInput.Clear();
            updateCategoryNameInput.Clear();
            updateCategoryNameInput.Enabled = false;
            updateBtn.Enabled = false;

            // --------------------------------------- DELETE Inputs

            deleteCategoryIdInput.Clear();
        }

        private void LoadCategoryTable()
        {
            string query = @"SELECT * FROM CATEGORY";

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

        // --------------------------------------- ADD CATEGORY

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(addCategoryIdInput.Text)) { 
                MessageDisplay.ShowError("Please enter a valid Category ID.");
                this.addCategoryIdInput.Focus();
                return;
            }

            if (UniquenessValidator.DoesCategoryIDExist(int.Parse(addCategoryIdInput.Text)))
            {
                MessageDisplay.ShowWarning("Category ID already exists. Please choose another one.");
                this.addCategoryIdInput.Focus();
                return;
            }

            if (!Validator.IsValidName(this.addCategoryNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid name.");
                this.addCategoryNameInput.Focus();
                return;
            }

            this.categoryID = int.Parse(addCategoryIdInput.Text);
            this.categoryName = this.addCategoryNameInput.Text;

            string insertQuery = "INSERT INTO CATEGORY (CID, NAME) VALUES (@CID, @NAME)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@CID", this.categoryID);
                    insertCmd.Parameters.AddWithValue("@NAME", this.categoryName);
                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageDisplay.ShowSuccess("Category added successfully.");
            LoadCategoryTable();
            clear_Inputs();
        }

        // --------------------------------------- UPDATE CATEGORY

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.updateCategoryIdInput.Text)){
                MessageDisplay.ShowError("Please enter a valid Category ID.");
                this.updateCategoryIdInput.Focus();
                return;
            }

            if (!UniquenessValidator.DoesCategoryIDExist(int.Parse(this.updateCategoryIdInput.Text)))
            {
                MessageDisplay.ShowWarning("Category ID does not exist. Please enter a valid one.");
                this.updateCategoryIdInput.Focus();
                return;
            }

            this.categoryID = int.Parse(this.updateCategoryIdInput.Text);

            string query = "SELECT NAME FROM CATEGORY WHERE CID = @CID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CID", this.categoryID);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    updateCategoryNameInput.Text = reader.GetString(0);

                    updateBtn.Enabled = true;
                    updateCategoryNameInput.Enabled = true;
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(updateCategoryIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid Category ID.");
                this.updateCategoryIdInput.Focus();
                return;
            }

            if (!Validator.IsValidName(this.updateCategoryNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid name.");
                this.updateCategoryNameInput.Focus();
                return;
            }

            this.categoryID = int.Parse(updateCategoryIdInput.Text);
            this.categoryName = updateCategoryNameInput.Text;

            string updateQuery = "UPDATE CATEGORY SET NAME = @NAME WHERE CID = @CID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@NAME", this.categoryName);
                cmd.Parameters.AddWithValue("@CID", this.categoryID);

                conn.Open();

                int affected = cmd.ExecuteNonQuery();
                if (affected > 0)
                {
                    MessageDisplay.ShowSuccess("Category updated successfully...");
                }
                else
                {
                    MessageDisplay.ShowWarning("Update failed. Category may not exist.");
                }
            }

            LoadCategoryTable();
            clear_Inputs();
        }

        // --------------------------------------- DELETE CATEGORY

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(deleteCategoryIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid Category ID.");
                this.deleteCategoryIdInput.Focus();
                return;
            }

            if (!UniquenessValidator.DoesCategoryIDExist(int.Parse(deleteCategoryIdInput.Text)))
            {
                MessageDisplay.ShowWarning("Category ID does not exist. Please enter a valid one.");
                this.deleteCategoryIdInput.Focus();
                return;
            }

            this.categoryID = int.Parse(deleteCategoryIdInput.Text);
           
            string deleteQuery = @"
                DELETE OD
                FROM ORDER_DETAILS OD
                JOIN PRODUCT P ON OD.PID = P.PID
                JOIN DEPARTMENT D ON P.DID = D.DID
                WHERE D.CID = @CID;
                       
                DELETE P
                FROM PRODUCT P
                JOIN DEPARTMENT D ON P.DID = D.DID
                WHERE D.CID = @CID;
                                                            
                DELETE FROM DEPARTMENT
                WHERE CID = @CID;

                DELETE FROM COMPANY
                WHERE CATE_ID = @CID;

                DELETE FROM CATEGORY
                WHERE CID = @CID;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
            {
                conn.Open();
                deleteCmd.Parameters.AddWithValue("@CID", categoryID);
                deleteCmd.ExecuteNonQuery();
            }

            MessageDisplay.ShowSuccess("Delete Category Successfully...");
            LoadCategoryTable();
            clear_Inputs();
        }
    }
}
