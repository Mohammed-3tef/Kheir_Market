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
            // TODO: This line of code loads data into the 'super_Market_DataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.super_Market_DataSet.CATEGORY);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        // --------------------------------------- ADD CATEGORY

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(addCategoryIdInput.Text)) { 
                this.addCategoryIdInput.Focus();
                return;
            }

            this.categoryID = int.Parse(addCategoryIdInput.Text);
            this.categoryName = this.addCategoryNameInput.Text;

            // WRITE YOUR ADD CATEGORY LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Add Category Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void refreshBtn1_Click(object sender, EventArgs e)
        {
            // WRITE YOUR REFRESH BTN_1 LOGIC HERE



            //
        }

        // --------------------------------------- UPDATE CATEGORY

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(this.updateCategoryIdInput.Text)){
                this.updateCategoryIdInput.Focus();
                return;
            }

            this.categoryID = int.Parse(this.updateCategoryIdInput.Text);
            bool isFound = false;

            // WRITE YOUR SEARCH CATEGORY_ID LOGIC HERE



            //

            if (!isFound)
            {
                System.Windows.Forms.MessageBox.Show("Category Not Found...", "Warning", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            // WRITE YOUR SEARCH CATEGORY_ID LOGIC HERE



            //

            this.updateBtn.Enabled = true;
            this.updateCategoryNameInput.Enabled = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(updateCategoryIdInput.Text))
            {
                this.updateCategoryIdInput.Focus();
                return;
            }

            this.categoryID = int.Parse(updateCategoryIdInput.Text);
            this.categoryName = updateCategoryNameInput.Text;

            // WRITE YOUR UPDATE CATEGORY LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Update Category Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            // WRITE THE SAME REFRESH BTN_1 LOGIC HERE



            //
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

            // WRITE YOUR DELETE CATEGORY LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Delete Category Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void refreshBtn3_Click(object sender, EventArgs e)
        {
            // WRITE THE SAME REFRESH BTN_1 LOGIC HERE



            //
        }
    }
}
