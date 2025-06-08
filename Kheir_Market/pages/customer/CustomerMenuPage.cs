using Kheir_Market.packages.display;
using Kheir_Market.pages.customer;
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

namespace Kheir_Market.pages
{
    public partial class CustomerMenuPage : Form
    {
        private MainWindow mainWindow;
        private string connectionString = "Data Source=localhost;Initial Catalog=Kheir_Market;Integrated Security=True";

        public CustomerMenuPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.welcomePersonMsg.Text = "Welcome, \n" + this.mainWindow.user.GetUsername();
        }

        private void LoadProductData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query;
                if (this.addCategoryComboBox.SelectedItem == null)
                {
                    query = @"
                        SELECT 
                        P.PID AS ID, P.NAME AS Name,
                        CAT.NAME AS Category, D.NAME AS Department, 
                        C.NAME AS Company, S.PRODUCT_QUANTITY AS Quantity,
                        P.PRICE AS Price
                        FROM PRODUCT P
                        JOIN DEPARTMENT D ON P.DID = D.DID
                        JOIN CATEGORY CAT ON D.CID = CAT.CID
                        JOIN COMPANY C ON P.COMPID = C.COMPID
                        JOIN STOCK S ON P.PID = S.PROD_ID;
                    ";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Replace with the correct grids
                        dataGridView1.DataSource = dt;
                    }
                }
                else {
                    query = @"
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
                        WHERE CAT.NAME = @CategoryName;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", this.addCategoryComboBox.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Replace with the correct grids
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void CustomerMenuPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kheir_Market_DataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.kheir_Market_DataSet.CATEGORY);
            this.addCategoryComboBox.SelectedIndex = -1;
            LoadProductData();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No) return;
            this.mainWindow.Show();
            this.Close();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement(this.mainWindow);
            orderManagement.Show();
            this.Close();
        }

        private void addCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            // check if the AboutPage is already open
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form is AboutPage)
                {
                    form.BringToFront();
                    return;
                }
            }

            AboutPage aboutPage = new AboutPage();
            aboutPage.Show();
        }
    }
}
