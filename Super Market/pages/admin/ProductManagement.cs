using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Super_Market.packages.display;

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

            // Attach event handlers for cascading combo boxes
            addCategoryComboBox.SelectedIndexChanged += AddCategoryComboBox_SelectedIndexChanged;
            addCompanyComboBox.SelectedIndexChanged += AddCompanyComboBox_SelectedIndexChanged;

            // Initially disable Add button
            addBtn.Enabled = false;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

            // Load Categories (top level)
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                addCategoryComboBox.Items.Clear();
                addDepartmentComboBox.Items.Clear();
                addCompanyComboBox.Items.Clear();

                using (SqlCommand catCmd = new SqlCommand("SELECT NAME FROM CATEGORY", conn))
                using (SqlDataReader reader = catCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addCategoryComboBox.Items.Add(reader.GetString(0));
                    }
                }
            }

            // Reset Department and Company comboBoxes
            addDepartmentComboBox.Enabled = false;
            addCompanyComboBox.Enabled = false;

            addCategoryComboBox.SelectedIndex = -1;
            addDepartmentComboBox.SelectedIndex = -1;
            addCompanyComboBox.SelectedIndex = -1;

            addBtn.Enabled = false;

            // Other initialization (price, quantity limits) remain unchanged
            addProductQuantityInput.Minimum = 0;
            addProductQuantityInput.Maximum = 5000;
            addProductPriceInput.DecimalPlaces = 2;
            addProductPriceInput.Increment = 0.01M;
            addProductPriceInput.Minimum = 0;
            addProductPriceInput.Maximum = 999999;
        }

        private void AddCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDepartmentComboBox.Items.Clear();
            addCompanyComboBox.Items.Clear();
            addDepartmentComboBox.Enabled = false;

            addDepartmentComboBox.SelectedIndex = -1;
            addCompanyComboBox.SelectedIndex = -1;
            addBtn.Enabled = false;

            if (addCategoryComboBox.SelectedIndex == -1)
                return;

            string selectedCategory = addCategoryComboBox.SelectedItem.ToString();

            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load Departments filtered by Category
                string deptQuery = @"
                    SELECT D.NAME 
                    FROM DEPARTMENT D
                    JOIN CATEGORY C ON D.CID = C.CID
                    WHERE C.NAME = @categoryName
                ";

                using (SqlCommand cmd = new SqlCommand(deptQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryName", selectedCategory);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            addDepartmentComboBox.Items.Add(reader.GetString(0));
                        }
                    }
                }

                addDepartmentComboBox.Enabled = addDepartmentComboBox.Items.Count > 0;

                // Load Companies filtered by Category only
                string compQuery = @"
                        SELECT DISTINCT C.NAME
                        FROM COMPANY C
                        JOIN CATEGORY CAT ON C.CATE_ID = CAT.CID
                        WHERE CAT.NAME = @categoryName
                        ";

                using (SqlCommand cmd = new SqlCommand(compQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryName", selectedCategory);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            addCompanyComboBox.Items.Add(reader.GetString(0));
                        }
                    }
                }

                addCompanyComboBox.Enabled = addCompanyComboBox.Items.Count > 0;
                addCompanyComboBox.Refresh();
            }
        }

    
        // When a company is selected, enable Add button if all 3 selections are made
        private void AddCompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                addBtn.Enabled =
                addCategoryComboBox.SelectedIndex != -1 &&
                addDepartmentComboBox.SelectedIndex != -1 &&
                addCompanyComboBox.SelectedIndex != -1;
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
            // Validate Product ID is an integer
            //if (!this.mainWindow.isValidInteger(this.addProductIdInput.Text))
            //    return;

            int productId = int.Parse(this.addProductIdInput.Text);

            if (productId < 0)
            {
                MessageDisplay.ShowError("Product ID must be a positive integer.");
                this.addProductIdInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.addProductNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a product name.");
                this.addProductNameInput.Focus();
                return;
            }

            if (this.addCategoryComboBox.SelectedIndex == -1)
            {
                MessageDisplay.ShowError("Please select a category.");
                this.addCategoryComboBox.Focus();
                return;
            }

            if (this.addDepartmentComboBox.SelectedIndex == -1)
            {
                MessageDisplay.ShowError("Please select a department.");
                this.addDepartmentComboBox.Focus();
                return;
            }

            if (this.addCompanyComboBox.SelectedIndex == -1)
            {
                MessageDisplay.ShowError("Please select a company.");
                this.addCompanyComboBox.Focus();
                return;
            }

            if (this.addProductQuantityInput.Value <= 0)
            {
                MessageDisplay.ShowError("Product quantity must be greater than 0.");
                this.addProductQuantityInput.Focus();
                return;
            }

            if (this.addProductPriceInput.Value <= 0)
            {
                MessageDisplay.ShowError("Product price must be greater than 0.");
                this.addProductPriceInput.Focus();
                return;
            }

            // Assign variables from UI inputs
            this.productID = productId;
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

                // Check if product ID already exists
                string checkQuery = "SELECT COUNT(*) FROM PRODUCT WHERE PID = @pid";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@pid", this.productID);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageDisplay.ShowError("Product ID already exists.");
                        return;
                    }
                }

                // Get department ID
                int departmentId;
                using (SqlCommand deptCmd = new SqlCommand("SELECT DID FROM DEPARTMENT WHERE NAME = @name", conn))
                {
                    deptCmd.Parameters.AddWithValue("@name", this.department);
                    object deptObj = deptCmd.ExecuteScalar();
                    if (deptObj == null)
                    {
                        MessageDisplay.ShowError("Selected department does not exist.");
                        return;
                    }
                    departmentId = Convert.ToInt32(deptObj);
                }

                // Get company ID
                int companyId;
                using (SqlCommand compCmd = new SqlCommand("SELECT COMPID FROM COMPANY WHERE NAME = @name", conn))
                {
                    compCmd.Parameters.AddWithValue("@name", this.company);
                    object compObj = compCmd.ExecuteScalar();
                    if (compObj == null)
                    {
                        MessageDisplay.ShowError("Selected company does not exist.");
                        return;
                    }
                    companyId = Convert.ToInt32(compObj);
                }

                // Insert into STOCK table
                using (SqlCommand stockCmd = new SqlCommand("INSERT INTO STOCK (Prod_ID, PRODUCT_QUANTITY) VALUES (@Prod_ID, @qty)", conn))
                {
                    stockCmd.Parameters.AddWithValue("@Prod_ID", this.productID);
                    stockCmd.Parameters.AddWithValue("@qty", this.productQuantity);
                    stockCmd.ExecuteNonQuery();
                }

                int stockId = this.productID;  

                // Insert into PRODUCT table
                using (SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO PRODUCT (PID, DID,SID,COMPID, NAME, PRICE)
                    VALUES (@pid, @did, @sid,@compid, @name, @price)", conn))
                { 
                    insertCmd.Parameters.AddWithValue("@pid", this.productID);
                    insertCmd.Parameters.AddWithValue("@did", departmentId);
                    insertCmd.Parameters.AddWithValue("@sid", stockId);
                    insertCmd.Parameters.AddWithValue("@compid", companyId);
                    insertCmd.Parameters.AddWithValue("@name", this.productName);
                    insertCmd.Parameters.AddWithValue("@price", this.productPrice);

                    insertCmd.ExecuteNonQuery();
                }

                clear_Inputs();

                MessageDisplay.ShowSuccess("Product added successfully.");
                LoadProductData();
            }
        }

        // --------------------------------------- UPDATE PRODUCT

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.updateProductIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid product ID.");
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
                MessageDisplay.ShowWarning("Product Not Found...");
                this.updateProductIdInput.Focus();
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

            MessageDisplay.ShowSuccess("Product updated successfully.");
            clear_Inputs();
            LoadProductData();
        }


        // --------------------------------------- DELETE PRODUCT

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.deleteProductIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid product ID.");
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
                        MessageDisplay.ShowWarning("Product Not Found...");
                        this.deleteProductIdInput.Focus();
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

            MessageDisplay.ShowSuccess("Product deleted successfully.");
            clear_Inputs();
            LoadProductData();
        }

    }
}
