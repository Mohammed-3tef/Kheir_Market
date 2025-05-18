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

        private List<string> years = new List<string> { };
        private string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

        public AnalysisDashboard(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.monthsComboBox.Items.AddRange(months.ToArray());
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                this.years.Add(i.ToString());
            }
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
            this.yearsComboBox.Items.AddRange(this.years.ToArray());
        }

        // ---------------------------------------------- MOST PURCHASED PRODUCT 

        private void MostPurchasedProduct()
        {
            string query = @"
                SELECT 
                P.PID AS ID, P.NAME AS Name,
                CAT.NAME AS Category, D.NAME AS Department, 
                C.NAME AS Company, S.PRODUCT_QUANTITY AS Quantity,
                P.PRICE AS Price , COUNT(DISTINCT OD.UID) AS [Product Purchases] 
                FROM PRODUCT P
                JOIN DEPARTMENT D ON P.DID = D.DID
                JOIN CATEGORY CAT ON D.CID = CAT.CID
                JOIN COMPANY C ON P.COMPID = C.COMPID
                JOIN STOCK S ON P.PID = S.PROD_ID
                JOIN [ORDER_DETAILS] OD ON P.PID = OD.PID
                GROUP BY 
                    P.PID, P.NAME, CAT.NAME, D.NAME, C.NAME, S.PRODUCT_QUANTITY, P.PRICE
                ORDER BY [Product Purchases] DESC;
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
                this.monthsComboBox.Focus();
                return;
            }

            if (this.yearsComboBox.SelectedItem == null)
            {
                MessageDisplay.ShowError("Please select a year.");
                this.yearsComboBox.Focus();
                return;
            }

            string query = @"
                SELECT P.PID AS ID, P.NAME AS Name,
                CAT.NAME AS Category, D.NAME AS Department, 
                C.NAME AS Company, S.PRODUCT_QUANTITY AS Quantity,
                P.PRICE AS Price , DATENAME(MONTH, DATEFROMPARTS(@Year, @Mnth, 1)) AS [Month], @Year AS [Year]
                FROM PRODUCT P
                    JOIN DEPARTMENT D ON P.DID = D.DID
                    JOIN CATEGORY CAT ON D.CID = CAT.CID
                    JOIN COMPANY C ON P.COMPID = C.COMPID
                    JOIN STOCK S ON P.PID = S.PROD_ID
                WHERE P.PID NOT IN (
                    SELECT OD.PID
                    FROM ORDER_DETAILS OD
                    JOIN ""ORDER"" O ON OD.OID = O.OID
                    WHERE MONTH(O.ORDER_DATE) = @Mnth AND YEAR(O.ORDER_DATE) = @Year
                );
            ";

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@Mnth", this.monthsComboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Year", this.yearsComboBox.Text);
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView2.DataSource = table;
            }
        }

        // ---------------------------------------------- INTERACTIVE CUSTOMERS

        private void InteractiveCustomers()
        {
            string query = @"
                SELECT 
	                U.UID AS [User ID], 
	                U.NAME AS [Name], 
	                U.EMAIL AS [Email], 
	                U.PHONE AS [Phone Number],
                    MAX(O.ORDER_DATE) AS [Last Purchase Date]
                FROM [USER] U
                LEFT JOIN [ORDER_DETAILS] OD ON U.UID = OD.UID
                LEFT JOIN [ORDER] O ON O.OID = OD.OID
                WHERE NOT EXISTS (
                    SELECT *
                    FROM [ORDER] O2
                    JOIN [ORDER_DETAILS] OD2 ON O2.OID = OD2.OID
                    WHERE OD2.UID = U.UID
                      AND YEAR(O2.ORDER_DATE) = 2024
                )
                GROUP BY U.UID, U.NAME, U.EMAIL, U.PHONE , O.ORDER_DATE
                ORDER BY U.UID;
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
                WITH MonthlyCustomerTotals AS (
                    SELECT 
                        U.UID AS [Customer ID],
                        U.NAME AS [Customer Name],
                        YEAR(O.ORDER_DATE) AS [Order Year],
                        MONTH(O.ORDER_DATE) AS [Order Month],
                        SUM(OD.QUANTITY) AS [Total Quantity],
                        SUM(O.TOTAL_PRICE) AS [Total Spent]
                    FROM [ORDER] O
                    JOIN ORDER_DETAILS OD ON O.OID = OD.OID
                    JOIN [USER] U ON OD.UID = U.UID
                    GROUP BY U.UID, U.NAME, YEAR(O.ORDER_DATE), MONTH(O.ORDER_DATE)
                ),
                RankedCustomers AS (
                    SELECT *,
                        ROW_NUMBER() OVER (PARTITION BY [Order Year], [Order Month] ORDER BY [Total Spent] DESC) AS Rank
                    FROM MonthlyCustomerTotals
                )
                SELECT 
                    [Customer ID], 
                    [Customer Name],
                    [Total Quantity],
                    [Total Spent], 
                    [Order Month], 
                    [Order Year]
                FROM RankedCustomers
                WHERE Rank = 1
                ORDER BY [Order Year], [Order Month];
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
                    SELECT 
                        c.NAME AS [Category],
                        SUM(p.PRICE * od.QUANTITY) AS [Total Sales]
                    FROM CATEGORY c
                    JOIN DEPARTMENT d ON c.CID = d.CID
                    JOIN PRODUCT p ON d.DID = p.DID
                    JOIN ORDER_DETAILS od ON p.PID = od.PID
                    JOIN [ORDER] o ON od.ORDER_ID = o.OID
                    -- WHERE c.NAME IN ('Food', 'Electronic') if you want to comparison between two categories
                    -- ORDER BY [Total Sales] DESC;        
                    GROUP BY c.NAME
                    ORDER BY [Total Sales] DESC;
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
                SELECT 
                    p.PID AS [ID],
                    p.NAME AS [Name],
                    d.NAME AS Department,
                    c.NAME AS Category,
                    co.NAME AS Company,
                    p.PRICE AS Price,
                    COUNT(DISTINCT(od.UID)) AS [Total Customer Purchases]
                FROM PRODUCT p
                JOIN DEPARTMENT d ON p.DID = d.DID
                JOIN CATEGORY c ON d.CID = c.CID
                JOIN COMPANY co ON p.COMPID = co.COMPID
                LEFT JOIN ORDER_DETAILS od ON p.PID = od.PID
                GROUP BY p.PID, p.NAME, d.NAME, c.NAME, co.NAME , p.PRICE
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
