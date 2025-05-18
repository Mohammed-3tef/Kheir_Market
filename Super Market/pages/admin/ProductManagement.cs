using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Super_Market.packages.display;
using Super_Market.packages.validation;

namespace Super_Market.pages
{
    public partial class ProductManagement : Form
    {
        private MainWindow mainWindow;
        private int productID;
        private string productName, category, department, company;
        private double productPrice;
        private int productQuantity;
        private const string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

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
            // TODO: This line of code loads data into the 'super_Market_DataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.super_Market_DataSet.CATEGORY);
            LoadProductData();

            addDepartmentComboBox.Items.Clear();
            addCompanyComboBox.Items.Clear();

            // Reset Department and Company comboBoxes
            addDepartmentComboBox.Enabled = false;
            addCompanyComboBox.Enabled = false;

            addCategoryComboBox.SelectedIndex = -1;
            addDepartmentComboBox.SelectedIndex = -1;
            addCompanyComboBox.SelectedIndex = -1;

            // Other initialization (price, quantity limits) remain unchanged
            addProductQuantityInput.Minimum = 0;
            addProductQuantityInput.Maximum = 500000;

            updateProductQuantityInput.Minimum = 0;
            updateProductQuantityInput.Maximum = 500000;

            addProductPriceInput.DecimalPlaces = 2;
            addProductPriceInput.Increment = 0.01M;
            addProductPriceInput.Minimum = 0;
            addProductPriceInput.Maximum = 999999;

            updateProductPriceInput.DecimalPlaces = 2;
            updateProductPriceInput.Increment = 0.01M;
            updateProductPriceInput.Minimum = 0;
            updateProductPriceInput.Maximum = 999999;
        }

        private void AddCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDepartmentComboBox.Items.Clear();
            addCompanyComboBox.Items.Clear();
            addDepartmentComboBox.Enabled = false;
            addCompanyComboBox.Enabled = false;
            addProductQuantityInput.Enabled = false;
            addProductPriceInput.Enabled = false;

            addDepartmentComboBox.SelectedIndex = -1;
            addCompanyComboBox.SelectedIndex = -1;

            if (addCategoryComboBox.SelectedIndex == -1) return;
                
            string selectedCategory = addCategoryComboBox.Text;

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

                addDepartmentComboBox.Enabled = addDepartmentComboBox.Items.Count > 0;
                addCompanyComboBox.Enabled = addCompanyComboBox.Items.Count > 0;

                if (addCompanyComboBox.Enabled)
                {
                    addProductQuantityInput.Enabled = true;
                    addProductPriceInput.Enabled = true;
                }
            }
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
            if (!Validator.IsValidInteger(this.addProductIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid product ID.");
                this.addProductIdInput.Focus();
                return;
            }

            if (UniquenessValidator.DoesProductIDExist(int.Parse(this.addProductIdInput.Text)))
            {
                MessageDisplay.ShowError("Product ID already exists.");
                this.addProductIdInput.Focus();
                return;
            }

            if (int.Parse(this.addProductIdInput.Text) <= 0)
            {
                MessageDisplay.ShowError("Product ID must be a positive integer.");
                this.addProductIdInput.Focus();
                return;
            }

            if (!Validator.IsValidProductName(this.addProductNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid product name.");
                this.addProductNameInput.Focus();
                return;
            }

            if (this.addCategoryComboBox.SelectedIndex == -1)
            {
                MessageDisplay.ShowError("Please select a valid category.");
                this.addCategoryComboBox.Focus();
                return;
            }

            if (this.addDepartmentComboBox.SelectedIndex == -1)
            {
                MessageDisplay.ShowError("Please select a valid department.");
                this.addDepartmentComboBox.Focus();
                return;
            }

            if (this.addCompanyComboBox.SelectedIndex == -1)
            {
                MessageDisplay.ShowError("Please select a valid company.");
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
            this.productID = int.Parse(this.addProductIdInput.Text);
            this.productName = this.addProductNameInput.Text;
            this.productQuantity = (int)this.addProductQuantityInput.Value;
            this.productPrice = (double)this.addProductPriceInput.Value;
            this.category = this.addCategoryComboBox.SelectedItem.ToString();
            this.department = this.addDepartmentComboBox.SelectedItem.ToString();
            this.company = this.addCompanyComboBox.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get department ID
                int departmentId;
                using (SqlCommand deptCmd = new SqlCommand("SELECT DID FROM DEPARTMENT WHERE NAME = @name", conn))
                {
                    deptCmd.Parameters.AddWithValue("@name", this.department);
                    object deptObj = deptCmd.ExecuteScalar();
                    if (deptObj == null)
                    {
                        MessageDisplay.ShowError("Selected department does not exist.");
                        this.addDepartmentComboBox.Focus();
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

                MessageDisplay.ShowSuccess("Product added successfully.");
                LoadProductData();
                clear_Inputs();
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

            if (!UniquenessValidator.DoesProductIDExist(int.Parse(this.updateProductIdInput.Text)))
            {
                MessageDisplay.ShowError("Product ID does not exist.");
                this.updateProductIdInput.Focus();
                return;
            }

            this.productID = int.Parse(this.updateProductIdInput.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load product details
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
                    WHERE P.PID = @pid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", this.productID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.updateProductNameInput.Text = Convert.ToString(reader["Name"]);
                            this.updateProductPriceInput.Value = Convert.ToDecimal(Convert.ToDouble(reader["Price"]));
                            this.updateProductQuantityInput.Value = Convert.ToInt32(reader["Quantity"]);
                            this.updateCategoryComboBox.SelectedIndex = updateCategoryComboBox.FindStringExact(Convert.ToString(reader["Category"]));
                        }
                    }
                }

                // Load departments for selected category
                string deptQuery = @"
                    SELECT D.NAME 
                    FROM DEPARTMENT D
                    JOIN CATEGORY C ON D.CID = C.CID
                    WHERE C.NAME = @categoryName
                ";

                using (SqlCommand cmd = new SqlCommand(deptQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryName", updateCategoryComboBox.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    updateDepartmentComboBox.DataSource = dt;
                    updateDepartmentComboBox.DisplayMember = "NAME";
                }

                // Companies based on category
                string compQuery = @"
                    SELECT DISTINCT C.NAME
                    FROM COMPANY C
                    JOIN CATEGORY CAT ON C.CATE_ID = CAT.CID
                    WHERE CAT.NAME = @categoryName
                ";

                using (SqlCommand cmd = new SqlCommand(compQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryName", updateCategoryComboBox.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    updateCompanyComboBox.DataSource = dt;
                    updateCompanyComboBox.DisplayMember = "NAME";
                }



                this.updateProductNameInput.Enabled = true;
                this.updateProductQuantityInput.Enabled = true;
                this.updateProductPriceInput.Enabled = true;
                this.updateCategoryComboBox.Enabled = true;
                this.updateDepartmentComboBox.Enabled = true;
                this.updateCompanyComboBox.Enabled = true;
                updateBtn.Enabled = true;

                string selectedCategory = updateCategoryComboBox.Text;
            }
        }

        private void updateCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateCategoryComboBox.SelectedValue == null) return;

            string selectedCategoryName = updateCategoryComboBox.Text; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load departments for selected category
                string deptQuery = @"
                    SELECT D.NAME 
                    FROM DEPARTMENT D
                    JOIN CATEGORY C ON D.CID = C.CID
                    WHERE C.NAME = @categoryName
                ";

                using (SqlCommand cmd = new SqlCommand(deptQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryName", selectedCategoryName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    updateDepartmentComboBox.DataSource = dt;
                    updateDepartmentComboBox.DisplayMember = "NAME"; 
                }

                // Companies based on category
                string compQuery = @"
                    SELECT DISTINCT C.NAME
                    FROM COMPANY C
                    JOIN CATEGORY CAT ON C.CATE_ID = CAT.CID
                    WHERE CAT.NAME = @categoryName
                ";

                using (SqlCommand cmd = new SqlCommand(compQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryName", selectedCategoryName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    updateCompanyComboBox.DataSource = dt;
                    updateCompanyComboBox.DisplayMember = "NAME"; 
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.updateProductIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid product ID.");
                this.updateProductIdInput.Focus();
                return;
            }

            if (!Validator.IsValidProductName(this.updateProductNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid product name.");
                this.updateProductNameInput.Focus();
                return;
            }

            if (!Validator.IsValidName(this.updateCategoryComboBox.Text)){
                MessageDisplay.ShowError("Please select a category.");
                this.updateCategoryComboBox.Focus();
                return;
            }

            if (!Validator.IsValidName(this.updateDepartmentComboBox.Text))
            {
                MessageDisplay.ShowError("Please select a valid department.");
                this.updateDepartmentComboBox.Focus();
                return;
            }
            
            if (!Validator.IsValidName(updateCompanyComboBox.Text))
            {
                MessageDisplay.ShowError("Please select a valid company.");
                this.updateCompanyComboBox.Focus();
                return;
            }

            if (this.updateProductQuantityInput.Value <= 0)
            {
                MessageDisplay.ShowError("Product quantity must be greater than 0.");
                this.updateProductQuantityInput.Focus();
                return;
            }

            if (this.updateProductPriceInput.Value <= 0)
            {
                MessageDisplay.ShowError("Product price must be greater than 0.");
                this.updateProductPriceInput.Focus();
                return;
            }

            this.productName = this.updateProductNameInput.Text;
            this.productPrice = (double) updateProductPriceInput.Value;
            this.productQuantity = (int) this.updateProductQuantityInput.Value;
            this.category = updateCategoryComboBox.Text;
            this.productID = int.Parse(this.updateProductIdInput.Text);
            this.department = updateDepartmentComboBox.Text;
            this.company = updateCompanyComboBox.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
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

                using (SqlCommand cmd = new SqlCommand(@"
                    UPDATE STOCK
                    SET PRODUCT_QUANTITY = @qty , PROD_ID = @Prod_ID
                    WHERE PROD_ID = @Prod_ID", conn))
                {
                    cmd.Parameters.AddWithValue("@qty", this.productQuantity);
                    cmd.Parameters.AddWithValue("@Prod_ID", this.productID);
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand(@"
                    UPDATE PRODUCT
                    SET NAME = @name, PRICE = @price, DID = @did, COMPID = @compid, PID = @pid
                    WHERE PID = @pid", conn))
                {
                    cmd.Parameters.AddWithValue("@name", this.productName);
                    cmd.Parameters.AddWithValue("@price", this.productPrice);
                    cmd.Parameters.AddWithValue("@did", departmentId);
                    cmd.Parameters.AddWithValue("@compid", companyId);
                    cmd.Parameters.AddWithValue("@pid", this.productID);
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
            int stockId = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Check if product exists and get its Prod_ID
                using (SqlCommand cmd = new SqlCommand("SELECT PID FROM PRODUCT WHERE PID = @pid", conn))
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
