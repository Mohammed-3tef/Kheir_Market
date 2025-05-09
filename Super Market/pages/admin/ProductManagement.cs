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

namespace Super_Market.pages
{
    public partial class ProductManagement : Form
    {
        private MainWindow mainWindow;
        private int productID;
        private string productName, category, department, company;
        private decimal productPrice;
        private int productQuantity;

        public ProductManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'super_Market_DataSet.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.super_Market_DataSet.COMPANY);
            // TODO: This line of code loads data into the 'super_Market_DataSet.DEPARTMENT' table. You can move, or remove it, as needed.
            this.dEPARTMENTTableAdapter.Fill(this.super_Market_DataSet.DEPARTMENT);
            // TODO: This line of code loads data into the 'super_Market_DataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.super_Market_DataSet.CATEGORY);
            
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"
                SELECT 
                P.PID AS ID, P.NAME AS Name,
                CAT.NAME AS Category, D.NAME AS Department, 
                C.NAME AS Company, S.PRODUCT_QUANTITY AS Quantity,
                P.PRICE AS Price
                FROM PRODUCT P
                JOIN DEPARTMENT D ON P.DID = D.DID
                JOIN CATEGORY CAT ON D.CID = CAT.CID
                JOIN COMPANY C ON P.COMPID = C.COMPID
                JOIN STOCK S ON P.PID = S.PROD_ID
            ";

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

            // Populate ComboBoxes
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Categories
                using (SqlCommand catCmd = new SqlCommand("SELECT NAME FROM CATEGORY", conn))
                using (SqlDataReader reader = catCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addCategoryComboBox.Items.Add(reader.GetString(0));
                        updateCategoryComboBox.Items.Add(reader.GetString(0));
                    }
                }

                // Departments
                using (SqlCommand deptCmd = new SqlCommand("SELECT NAME FROM DEPARTMENT", conn))
                using (SqlDataReader reader = deptCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addDepartmentComboBox.Items.Add(reader.GetString(0));
                        updateDepartmentComboBox.Items.Add(reader.GetString(0));
                    }
                }

                // Companies
                using (SqlCommand compCmd = new SqlCommand("SELECT NAME FROM COMPANY", conn))
                using (SqlDataReader reader = compCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addCompanyComboBox.Items.Add(reader.GetString(0));
                        updateCompanyComboBox.Items.Add(reader.GetString(0));
                    }
                }
            }

            // Set defaults
            addCategoryComboBox.SelectedIndex = -1;
            addDepartmentComboBox.SelectedIndex = -1;
            addCompanyComboBox.SelectedIndex = -1;

            addProductQuantityInput.Minimum = 0;
            addProductQuantityInput.Maximum = 5000;
            updateProductQuantityInput.Minimum = 0;
            updateProductQuantityInput.Maximum = 5000;

            addProductPriceInput.DecimalPlaces = 2;
            addProductPriceInput.Increment = 0.01M;
            addProductPriceInput.Minimum = 0;
            addProductPriceInput.Maximum = 999999;

            updateProductPriceInput.DecimalPlaces = 2;
            updateProductPriceInput.Increment = 0.01M;
            updateProductPriceInput.Minimum = 0;
            updateProductPriceInput.Maximum = 999999;
        }


        // --------------------------------------- Clear inputs
        private void clear_Inputs()
        {
            // ---------- ADD Section
            addProductIdInput.Clear();
            addProductNameInput.Clear();
            addCategoryComboBox.SelectedIndex = -1;
            addDepartmentComboBox.SelectedIndex = -1;
            addCompanyComboBox.SelectedIndex = -1;
            addProductQuantityInput.Value = 0;
            addProductPriceInput.Value = 0;

            // ---------- UPDATE Section
            updateProductIdInput.Clear();
            updateProductNameInput.Clear();
            updateCategoryComboBox.SelectedIndex = -1;
            updateDepartmentComboBox.SelectedIndex = -1;
            updateCompanyComboBox.SelectedIndex = -1;
            updateProductQuantityInput.Value = 0;
            updateProductPriceInput.Value = 0;

            updateBtn.Enabled = false;
            updateProductNameInput.Enabled = false;
            updateProductQuantityInput.Enabled = false;
            updateProductPriceInput.Enabled = false;
            updateCategoryComboBox.Enabled = false;
            updateDepartmentComboBox.Enabled = false;
            updateCompanyComboBox.Enabled = false;

            // ---------- DELETE Section
            deleteProductIdInput.Clear();
        }

        private void LoadProductData()
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                P.PID AS ID, P.NAME AS Name,
                CAT.NAME AS Category, D.NAME AS Department, 
                C.NAME AS Company, S.PRODUCT_QUANTITY AS Quantity,
                P.PRICE AS Price
                FROM PRODUCT P
                JOIN DEPARTMENT D ON P.DID = D.DID
                JOIN CATEGORY CAT ON D.CID = CAT.CID
                JOIN COMPANY C ON P.COMPID = C.COMPID
                JOIN STOCK S ON P.PID = S.PROD_ID
            ";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Replace with the correct grids
                    dataGridView1.DataSource = dt;
                    dataGridView2.DataSource = dt;
                    dataGridView3.DataSource = dt;
                }
            }
        }

        // --------------------------------------- ADD PRODUCT
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.addProductIdInput.Text)) return;

            if (int.Parse(this.addProductIdInput.Text) < 0)
            {
                System.Windows.Forms.MessageBox.Show("Product ID must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.addProductIdInput.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.addProductNameInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.addProductNameInput.Focus();
                return;
            }
            if (this.addCategoryComboBox.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.addCategoryComboBox.Focus();
                return;
            }
            if (this.addDepartmentComboBox.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Please select a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.addDepartmentComboBox.Focus();
                return;
            }
            if (this.addCompanyComboBox.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Please select a company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.addCompanyComboBox.Focus();
                return;
            }
            if (this.addProductQuantityInput.Value <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Product quantity must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.addProductQuantityInput.Focus();
                return;
            }
            if (this.addProductPriceInput.Value <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Product price must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.addProductPriceInput.Focus();
                return;
            }

            this.productID = int.Parse(this.addProductIdInput.Text);
            this.productName = this.addProductNameInput.Text;
            this.productQuantity = (int)this.addProductQuantityInput.Value;
            this.productPrice = this.addProductPriceInput.Value;
            this.category = this.addCategoryComboBox.SelectedItem.ToString();
            this.department = this.addDepartmentComboBox.SelectedItem.ToString();
            this.company = this.addCompanyComboBox.SelectedItem.ToString();

            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // First check if product ID already exists
                string checkQuery = "SELECT COUNT(*) FROM PRODUCT WHERE PID = @pid";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@pid", this.productID);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Product ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Get IDs for foreign keys
                int departmentId, companyId, stockId;

                // Get department ID
                using (SqlCommand deptCmd = new SqlCommand("SELECT DID FROM DEPARTMENT WHERE NAME = @name", conn))
                {
                    deptCmd.Parameters.AddWithValue("@name", this.department);
                    departmentId = Convert.ToInt32(deptCmd.ExecuteScalar());
                }

                // Get company ID
                using (SqlCommand compCmd = new SqlCommand("SELECT COMPID FROM COMPANY WHERE NAME = @name", conn))
                {
                    compCmd.Parameters.AddWithValue("@name", this.company);
                    companyId = Convert.ToInt32(compCmd.ExecuteScalar());
                }

                // Insert into STOCK table
                using (SqlCommand stockCmd = new SqlCommand("INSERT INTO STOCK (Prod_ID, PRODUCT_QUANTITY) VALUES (@Prod_ID, @qty)", conn))
                {
                    stockCmd.Parameters.AddWithValue("@Prod_ID", this.productID);
                    stockCmd.Parameters.AddWithValue("@qty", this.productQuantity);
                    stockCmd.ExecuteNonQuery();
                }
                stockId = this.productID;

                // Insert into PRODUCT table
                using (SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO PRODUCT (PID, DID, Prod_ID , COMPID , NAME , PRICE )
                    VALUES (@pid,@did,@Prod_ID,@compid,@name,@price)", conn))
                {
                    insertCmd.Parameters.AddWithValue("@pid", this.productID);
                    insertCmd.Parameters.AddWithValue("@did", departmentId);
                    insertCmd.Parameters.AddWithValue("@Prod_ID", stockId);
                    insertCmd.Parameters.AddWithValue("@compid", companyId);
                    insertCmd.Parameters.AddWithValue("@name", this.productName);
                    insertCmd.Parameters.AddWithValue("@price", this.productPrice);

                    insertCmd.ExecuteNonQuery();
                }

                

                clear_Inputs();

                System.Windows.Forms.MessageBox.Show("Add Product Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refreshBtn1_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }




        // --------------------------------------- UPDATE PRODUCT

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.updateProductIdInput.Text))
            {
                this.updateProductIdInput.Focus();
                return;
            }

            this.productID = int.Parse(this.updateProductIdInput.Text);
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                    P.NAME, P.PRICE, S.PRODUCT_QUANTITY, 
                    CAT.NAME AS Category, D.NAME AS Department, C.NAME AS Company
                    FROM PRODUCT P
                    JOIN STOCK S ON P.PID = S.PROD_ID
                    JOIN DEPARTMENT D ON P.DID = D.DID
                    JOIN CATEGORY CAT ON D.CID = CAT.CID
                    JOIN COMPANY C ON P.COMPID = C.COMPID
                    WHERE P.PID = @pid
                ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", this.productID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            this.updateProductNameInput.Text = reader["NAME"].ToString();
                            this.updateProductPriceInput.Value = Convert.ToDecimal(reader["PRICE"]);
                            this.updateProductQuantityInput.Value = Convert.ToInt32(reader["PRODUCT_QUANTITY"]);
                            this.updateCategoryComboBox.SelectedItem = reader["Category"].ToString();
                            this.updateDepartmentComboBox.SelectedItem = reader["Department"].ToString();
                            this.updateCompanyComboBox.SelectedItem = reader["Company"].ToString();
                        }
                    }
                }
            }

            if (!isFound)
            {
                System.Windows.Forms.MessageBox.Show("Product Not Found...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.updateBtn.Enabled = true;
            this.updateProductNameInput.Enabled = true;
            this.updateProductQuantityInput.Enabled = true;
            this.updateProductPriceInput.Enabled = true;
            this.updateCategoryComboBox.Enabled = true;
            this.updateDepartmentComboBox.Enabled = true;
            this.updateCompanyComboBox.Enabled = true;
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string name = this.updateProductNameInput.Text;
            decimal price = this.updateProductPriceInput.Value;
            int quantity = (int)this.updateProductQuantityInput.Value;
            string category = this.updateCategoryComboBox.SelectedItem?.ToString();
            string department = this.updateDepartmentComboBox.SelectedItem?.ToString();
            string company = this.updateCompanyComboBox.SelectedItem?.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get foreign key IDs
                int departmentId, companyId;

                using (SqlCommand cmd = new SqlCommand("SELECT DID FROM DEPARTMENT WHERE NAME = @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", department);
                    departmentId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (SqlCommand cmd = new SqlCommand("SELECT COMPID FROM COMPANY WHERE NAME = @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", company);
                    companyId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Update PRODUCT table
                using (SqlCommand cmd = new SqlCommand(@"
                    UPDATE PRODUCT
                    SET NAME = @name, PRICE = @price, DID = @did, COMPID = @compid
                    WHERE PID = @pid", conn))
                {
                    cmd.Parameters.AddWithValue("@pid", this.productID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@did", departmentId);
                    cmd.Parameters.AddWithValue("@compid", companyId);
                    cmd.ExecuteNonQuery();
                }

                // Update STOCK table
                using (SqlCommand cmd = new SqlCommand(@"
                    UPDATE STOCK
                    SET PRODUCT_QUANTITY = @qty
                    WHERE Prod_ID = @Prod_ID", conn))
                {
                    cmd.Parameters.AddWithValue("@qty", quantity);
                    cmd.Parameters.AddWithValue("@Prod_ID", this.productID);
                    cmd.ExecuteNonQuery();
                }
            }

            System.Windows.Forms.MessageBox.Show("Update Product Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_Inputs();
        }


        // --------------------------------------- DELETE PRODUCT

        private void refreshBtn3_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.deleteProductIdInput.Text))
            {
                this.deleteProductIdInput.Focus();
                return;
            }

            this.productID = int.Parse(this.deleteProductIdInput.Text);
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            int stockId = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Check if product exists and get its Prod_ID
                using (SqlCommand cmd = new SqlCommand("SELECT Prod_ID FROM PRODUCT WHERE PID = @pid", conn))
                {
                    cmd.Parameters.AddWithValue("@pid", this.productID);
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        System.Windows.Forms.MessageBox.Show("Product Not Found...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    stockId = Convert.ToInt32(result);
                }

                // Step 2: Delete product (must come first due to FK constraint)
                using (SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCT WHERE PID = @pid", conn))
                {
                    cmd.Parameters.AddWithValue("@pid", this.productID);
                    cmd.ExecuteNonQuery();
                }

                // Step 3: Delete stock entry
                using (SqlCommand cmd = new SqlCommand("DELETE FROM STOCK WHERE Prod_ID = @Prod_ID", conn))
                {
                    cmd.Parameters.AddWithValue("@Prod_ID", stockId);
                    cmd.ExecuteNonQuery();
                }
            }

            System.Windows.Forms.MessageBox.Show("Delete Product Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_Inputs();
      
        }

    }
}
