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
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"
                SELECT 
                    P.PID AS ID, P.NAME AS Name,
                    CAT.NAME AS Category, D.NAME AS Department, 
                    C.NAME AS Company, S.PRODUCT_QUANTITY AS Quantity,
                    P.PRICE AS Price
                FROM PRODUCT P
                JOIN DEPARTMENT D ON P.DID = D.DID
                JOIN CATEGORY CAT ON D.CATE_ID = CAT.CID
                JOIN COMPANY C ON P.COMPID = C.COMPID
                JOIN STOCK S ON P.SID = S.SID
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

            this.addCategoryComboBox.SelectedIndex = -1;
            this.addDepartmentComboBox.SelectedIndex = -1;
            this.addCompanyComboBox.SelectedIndex = -1;

            this.addProductQuantityInput.Minimum = 0;
            this.addProductQuantityInput.Maximum = 5000;
            this.updateProductQuantityInput.Minimum = 0;
            this.updateProductQuantityInput.Maximum = 5000;

            this.addProductPriceInput.DecimalPlaces = 2;
            this.addProductPriceInput.Increment = 0.01M;
            this.addProductPriceInput.Minimum = 0;
            this.addProductPriceInput.Maximum = 999999;

            this.updateProductPriceInput.DecimalPlaces = 2;
            this.updateProductPriceInput.Increment = 0.01M;
            this.updateProductPriceInput.Minimum = 0;
            this.updateProductPriceInput.Maximum = 999999;
        }

        // --------------------------------------- ADD PRODUCT


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.addProductIdInput.Text)) return;
            
            if (int.Parse(this.addProductIdInput.Text) < 0)
            {
                System.Windows.Forms.MessageBox.Show("Product ID must be a positive integer.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addProductIdInput.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.addProductNameInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a product name.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addProductNameInput.Focus();
                return;
            }
            if (this.addProductQuantityInput.Value < 0)
            {
                System.Windows.Forms.MessageBox.Show("Product quantity must be a positive integer.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addProductQuantityInput.Focus();
                return;
            }
            if (this.addProductPriceInput.Value < 0)
            {
                System.Windows.Forms.MessageBox.Show("Product price must be a positive integer.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addProductPriceInput.Focus();
                return;
            }
            if (this.addCategoryComboBox.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Please select a category.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addCategoryComboBox.Focus();
                return;
            }
            if (this.addDepartmentComboBox.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Please select a department.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addDepartmentComboBox.Focus();
                return;
            }
            if (this.addCompanyComboBox.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Please select a company.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addCompanyComboBox.Focus();
                return;
            }
            if (this.addProductQuantityInput.Value == 0)
            {
                System.Windows.Forms.MessageBox.Show("Product quantity must be greater than 0.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addProductQuantityInput.Focus();
                return;
            }

            this.productID = int.Parse(this.addProductIdInput.Text);
            this.productName = this.addProductNameInput.Text;
            this.productQuantity = (int)this.addProductQuantityInput.Value;
            this.productPrice = this.addProductPriceInput.Value;
            this.category = this.addCategoryComboBox.SelectedItem.ToString();
            this.department = this.addDepartmentComboBox.SelectedItem.ToString();
            this.company = this.addCompanyComboBox.SelectedItem.ToString();

            // WRITE YOUR DELETE PRODUCT LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Add Product Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void refreshBtn1_Click(object sender, EventArgs e)
        {
            // WRITE YOUR REFRESH BTN1 LOGIC HERE



            //
        }

        // --------------------------------------- UPDATE PRODUCT

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            // WRITE THE SAME YOUR REFRESH BTN1 LOGIC HERE



            //
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.updateProductIdInput.Text)) { 
                this.updateProductIdInput.Focus();
                return; 
            }
            
            this.productID = int.Parse(this.updateProductIdInput.Text);

            // WRITE YOUR SEARCH PRODUCT_ID LOGIC HERE



            //

            bool isFound = false;
            if (!isFound)
            {
                System.Windows.Forms.MessageBox.Show("Product Not Found...", "Warning", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            // WRITE YOUR SEARCH PRODUCT_ID LOGIC HERE



            //

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
            // WRITE YOUR UPDATE PRODUCT LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Update Product Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        // --------------------------------------- DELETE PRODUCT

        private void refreshBtn3_Click(object sender, EventArgs e)
        {
            // WRITE THE SAME YOUR REFRESH BTN1 LOGIC HERE



            //
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.deleteProductIdInput.Text)) {
                this.deleteProductIdInput.Focus();
                return; 
            }
            
            this.productID = int.Parse(this.deleteProductIdInput.Text);

            // WRITE YOUR DELETE PRODUCT LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Delete Product Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }
    }
}
