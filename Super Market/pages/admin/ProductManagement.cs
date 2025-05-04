using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: This line of code loads data into the 'super_MarketDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.super_MarketDataSet.Category);
            // TODO: This line of code loads data into the 'super_MarketDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.super_MarketDataSet.Product);
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

        private void addProductIdInput_TextChanged(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.addProductIdInput.Text)) return;
            this.productID = int.Parse(this.addProductIdInput.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
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

        private void updateProductIdInput_TextChanged(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.updateProductIdInput.Text)) return;
            this.productID = int.Parse(this.updateProductIdInput.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
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
            // WRITE YOUR DELETE PRODUCT LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Delete Product Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void deleteProductIdInput_TextChanged(object sender, EventArgs e)
        {
            if(!this.mainWindow.isValidInteger(this.deleteProductIdInput.Text)) return;
            this.productID = int.Parse(this.deleteProductIdInput.Text);
        }
    }
}
