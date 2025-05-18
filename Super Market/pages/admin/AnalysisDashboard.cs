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
using Super_Market.packages.display;

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
                P.PRICE AS Price , COUNT(DISTINCT OD.UID) AS Product_Purchases 
                FROM PRODUCT P
                JOIN DEPARTMENT D ON P.DID = D.DID
                JOIN CATEGORY CAT ON D.CID = CAT.CID
                JOIN COMPANY C ON P.COMPID = C.COMPID
                JOIN STOCK S ON P.PID = S.PROD_ID
                JOIN [ORDER_DETAILS] OD ON P.PID = OD.PID
                GROUP BY 
                    P.PID, P.NAME, CAT.NAME, D.NAME, C.NAME, S.PRODUCT_QUANTITY, P.PRICE
                ORDER BY 
                    Product_Purchases DESC;
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
            if (this.monthsComboBox.SelectedItem == null)
            {
                MessageDisplay.ShowError("Please select a month.");
                return;
            }
            // string selectedYear = this.yearTextBox.Text;
            string query = @"SELECT P.PID AS ID, P.NAME AS Name,
                                CAT.NAME AS Category, D.NAME AS Department, 
                                C.NAME AS Company, S.PRODUCT_QUANTITY AS Quantity,
                                P.PRICE AS Price , DATENAME(MONTH, DATEFROMPARTS(@Year, @Mnth, 1)) AS [Month], @Year AS [Year]
                                FROM PRODUCT P
                                        JOIN DEPARTMENT D ON P.DID = D.DID
                                        JOIN CATEGORY CAT ON D.CID = CAT.CID
                                        JOIN COMPANY C ON P.COMPID = C.COMPID
                                        JOIN STOCK S ON P.PID = S.PROD_ID
                                WHERE 
                                    P.PID NOT IN (
                                        SELECT 
                                            OD.PID
                                        FROM 
                                            ORDER_DETAILS OD
                                        JOIN 
                                            ""ORDER"" O ON OD.OID = O.OID
                                        WHERE 
                                            MONTH(O.ORDER_DATE) = @Mnth AND YEAR(O.ORDER_DATE) = @Year
                               );";
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@Mnth", this.monthsComboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Year", "2025");
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
