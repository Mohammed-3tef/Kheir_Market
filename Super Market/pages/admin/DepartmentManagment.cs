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

namespace Super_Market.pages.admin
{
    public partial class DepartmentManagment : Form
    {
        private MainWindow mainWindow;
        private int departmentID;
        private string departmentName;
        private string categoryName;

        public DepartmentManagment(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        
        private void DepartmentManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'super_Market_DataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.super_Market_DataSet.CATEGORY);
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"
                SELECT D.DID AS ID, D.NAME AS Name, C.NAME AS Category
                FROM DEPARTMENT D JOIN CATEGORY C 
                ON D.CATE_ID = C.CID
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
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        // --------------------------------------- ADD DEPARTMENT

        private void refreshBtn1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(addDepartmentIdInput.Text)){
                this.addDepartmentIdInput.Focus();
                return;
            }

            this.departmentID = int.Parse(addDepartmentIdInput.Text);
            this.departmentName = addDepartmentNameInput.Text;
            this.categoryName = addCategoryComboBox.Text;

            // WRITE YOUR ADD DEPARTMENT LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Add Department Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        // --------------------------------------- UPDATE CATEGORY

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(updateDepartmentIdInput.Text)){
                this.updateDepartmentIdInput.Focus();
                return;
            }

            this.departmentID = int.Parse(updateDepartmentIdInput.Text);
            bool isFound = false;

            // WRITE YOUR SEARCH DEPARTMENT_ID LOGIC HERE



            //

            if (!isFound)
            {
                System.Windows.Forms.MessageBox.Show("Department Not Found...", "Warning", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            // WRITE YOUR SEARCH DEPARTMENT_ID LOGIC HERE



            //

            this.updateBtn.Enabled = true;
            this.updateDepartmentNameInput.Enabled = true;
            this.updateCategorycomboBox.Enabled = true;
        }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(updateDepartmentIdInput.Text))
            {
                this.updateDepartmentIdInput.Focus();
                return;
            }

            this.departmentID = int.Parse(updateDepartmentIdInput.Text);
            this.departmentName = updateDepartmentNameInput.Text;
            this.categoryName = updateCategorycomboBox.Text;

            // WRITE YOUR UPDATE DEPARTMENT LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Update Department Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        // --------------------------------------- DELETE Department

        private void refreshBtn3_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(deleteDepartmentIdInput.Text)){
                this.deleteDepartmentIdInput.Focus();
                return;
            }

            // WRITE YOUR DELETE DEPARTMENT LOGIC HERE



            //

            System.Windows.Forms.MessageBox.Show("Delete Department Successfully...", "Info", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }
    }
}
