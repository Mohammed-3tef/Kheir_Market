using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.pages.admin
{
    public partial class AnalysisDashboard : Form
    {
        private MainWindow mainWindow;
        private List<string> months = new List<string>
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        private string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";


        public AnalysisDashboard(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.monthsComboBox.Items.AddRange(months.ToArray());
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        private void AnalysisDashboard_Load(object sender, EventArgs e)
        {
            MostPurchasedProduct();
            InteractiveCustomers();
            TopPurchasingCustomer();
            SalesComparison();
            ProductPurchaseSummary();
        }

        // ---------------------------------------------- MOST PURCHASED PRODUCT 

        private void MostPurchasedProduct()
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

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView1.DataSource = table;
            }
        }

        // ---------------------------------------------- UNSOLD PRODUCT BY MONTH

        private void UnsoldProductByMonth(object sender, EventArgs e)
        {
            string query = @"
                
            ";

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView2.DataSource = table;
            }
        }

        // ---------------------------------------------- INTERACTIVE CUSTOMERS

        private void InteractiveCustomers()
        {
            string query = @"
                
            ";

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView3.DataSource = table;
            }
        }
        // ---------------------------------------------- TOP PURCHASING CUSTOMER

        private void TopPurchasingCustomer()
        {
            string query = @"
                
            ";

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView4.DataSource = table;
            }
        }

        // ---------------------------------------------- SALES COMPARISON


        private void SalesComparison()
        {
            string query = @"
                
            ";

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView5.DataSource = table;
            }
        }


        // ---------------------------------------------- Product Purchase Summary

        private void ProductPurchaseSummary()
        {
            string query = @"
                
            ";

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView6.DataSource = table;
            }
        }
    }
}
