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

namespace Super_Market.pages
{
    public partial class CategoryManagement : Form
    {
        private MainWindow mainWindow;
        private int categoryID;
        private string categoryName;

        public CategoryManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'super_Market_DataSet1.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter1.Fill(this.super_Market_DataSet1.CATEGORY);
        } // semi done 

        
        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        } //done 

        private void clear_Inputs()
        {
            // --------------------------------------- ADD Inputs

            addCategoryIdInput.Clear();
            addCategoryNameInput.Clear();
           
            // --------------------------------------- UPDATE Inputs

            updateCategoryIdInput.Clear();
            updateCategoryNameInput.Clear();
           
            // --------------------------------------- DELETE Inputs

            deleteCategoryIdInput.Clear();
        }

        private void LoadCategoryTable()
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
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
                MessageDisplay.ShowError("Please enter a valid integer for Category ID.");
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

            // WRITE YOUR ADD CATEGORY LOGIC HERE
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string checkCIDQuery = "SELECT COUNT(*) FROM CATEGORY WHERE CID = @CID";
            string insertQuery = "INSERT INTO CATEGORY (CID, NAME) VALUES (@CID, @NAME)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if CID already exists
                using (SqlCommand checkCIDCmd = new SqlCommand(checkCIDQuery, conn))
                {
                    checkCIDCmd.Parameters.AddWithValue("@CID", this.categoryID);
                    int didCount = (int)checkCIDCmd.ExecuteScalar();

                    if (didCount > 0)
                    {
                        MessageDisplay.ShowWarning("Category ID already exists. Please choose another one.");
                        return;
                    }
                }

                // Proceed with insert if validations pass
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@CID", categoryID);
                    insertCmd.Parameters.AddWithValue("@NAME", this.categoryName);
                    insertCmd.ExecuteNonQuery();
                }

                clear_Inputs();  
            }

            //

            MessageDisplay.ShowSuccess("Category added successfully.");
            LoadCategoryTable();
        }

        // --------------------------------------- UPDATE CATEGORY

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.updateCategoryIdInput.Text)){
                MessageDisplay.ShowError("Please enter a valid integer for Category ID.");
                this.updateCategoryIdInput.Focus();
                return;
            }

            this.categoryID = int.Parse(this.updateCategoryIdInput.Text);
            bool isFound = false;

            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = "SELECT NAME FROM CATEGORY WHERE CID = @CID";
            // WRITE YOUR SEARCH CATEGORY_ID LOGIC HERE
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
                    isFound = true;
                }
                else
                {
                    MessageDisplay.ShowWarning("Category Not Found...");
                    updateBtn.Enabled = false;
                  
                    updateCategoryNameInput.Enabled = false;
                }
                
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(updateCategoryIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid integer for Category ID.");
                this.updateCategoryIdInput.Focus();
                return;
            }

            this.categoryID = int.Parse(updateCategoryIdInput.Text);
            this.categoryName = updateCategoryNameInput.Text;

            // WRITE YOUR UPDATE CATEGORY LOGIC HERE
            if (!Validator.IsValidName(this.categoryName))
            {
                MessageDisplay.ShowError("Please enter a valid name.");
                this.updateCategoryNameInput.Focus();
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
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
        }

        // --------------------------------------- DELETE CATEGORY

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(deleteCategoryIdInput.Text))
            {
                this.deleteCategoryIdInput.Focus();
                return;
            }

            this.categoryID = int.Parse(deleteCategoryIdInput.Text);
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
           
            string checkQuery = "SELECT COUNT(*) FROM CATEGORY WHERE CID = @CID";
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
            // WRITE YOUR DELETE CATEGORY LOGIC HERE
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@CID", categoryID);
                conn.Open();

                int count = (int)checkCmd.ExecuteScalar();
                
                if (count == 0)
                {
                    MessageDisplay.ShowWarning("Category Not Found...");
                    return;
                }

                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@CID", categoryID);
                    deleteCmd.ExecuteNonQuery();
                    MessageDisplay.ShowSuccess("Delete Category Successfully...");
                }
            }

            LoadCategoryTable();
        }
    }
}
