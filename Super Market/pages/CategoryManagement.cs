using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.pages
{
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'super_MarketDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.super_MarketDataSet.Category);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage();
            adminMenuPage.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn1_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
        
        private void refreshBtn2_Click(object sender, EventArgs e)
        {

        }
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn3_Click(object sender, EventArgs e)
        {

        }

        private void addCategoryIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCategoryNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCategoryNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCategoryIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteCategoryIdInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
