using DGVPrinterHelper;
using Kheir_Market.packages.display;
using Kheir_Market.pages.admin;
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
    public partial class AdminMenuPage : Form
    {
        private MainWindow mainWindow;
        private List<string> months = new List<string>
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        private List<string> years = new List<string> { };
        private string connectionString = "Data Source=.;Initial Catalog=Kheir_Market;Integrated Security=True;";

        public AdminMenuPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.welcomePersonMsg.Text = "Welcome, " + this.mainWindow.user.GetUsername();
            this.monthsComboBox.Items.AddRange(months.ToArray());
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                this.years.Add(i.ToString());
            }

            this.FormClosing += this.mainWindow.formClosing;
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement(this.mainWindow);
            productManagement.Show();
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            UserManagement customerManagement = new UserManagement(this.mainWindow);
            customerManagement.Show();
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
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
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement(this.mainWindow);
            categoryManagement.Show();
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
        }

        private void departmentBtn_Click(object sender, EventArgs e)
        {
            DepartmentManagement departmentManagment = new DepartmentManagement(this.mainWindow);
            departmentManagment.Show();
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
        }

        private void companyBtn_Click(object sender, EventArgs e)
        {
            CompanyManagement companyManagement = new CompanyManagement(this.mainWindow);
            companyManagement.Show();
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.SubTitle = "\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Kheir Market\nGenerated on: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            printer.FooterSpacing = 15;

            if (this.TabControl.SelectedTab == mostPurchasedProductPage)
            {
                printer.Title = "Most Purchased Products";
                printer.PrintDataGridView(this.dataGridView1);
            }
            else if (this.TabControl.SelectedTab == unsoldProductByMonthPage)
            {
                if (this.yearsComboBox.SelectedItem == null)
                {
                    MessageDisplay.ShowError("Please select a year.");
                    this.yearsComboBox.Focus();
                    return;
                }

                if (this.monthsComboBox.SelectedItem == null)
                {
                    MessageDisplay.ShowError("Please select a month.");
                    this.monthsComboBox.Focus();
                    return;
                }

                printer.Title = "Unsold Products by " + this.months[this.monthsComboBox.SelectedIndex] + " " + this.yearsComboBox.Text;
                printer.PrintDataGridView(this.dataGridView2);
            }
            else if (this.TabControl.SelectedTab == interactiveCustomersPage)
            {
                printer.Title = "Interactive Customers";
                printer.PrintDataGridView(this.dataGridView3);
            }
            else if (this.TabControl.SelectedTab == topPurchasingCustomerPage)
            {
                printer.Title = "Top Purchasing Customers";
                printer.PrintDataGridView(this.dataGridView4);
            }
            else if (this.TabControl.SelectedTab == salesComparisonPage)
            {
                printer.Title = "Sales Comparison by Category";
                printer.PrintDataGridView(this.dataGridView5);
            }
            else if (this.TabControl.SelectedTab == productPurchaseSummaryPage)
            {
                printer.Title = "Product Purchase Summary";
                printer.PrintDataGridView(this.dataGridView6);
            }
        }

        private void AdminMenuPage_Load(object sender, EventArgs e)
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
            if (this.yearsComboBox.SelectedItem == null)
            {
                MessageDisplay.ShowError("Please select a year.");
                this.yearsComboBox.Focus();
                return;
            }
            
            if (this.monthsComboBox.SelectedItem == null)
            {
                MessageDisplay.ShowError("Please select a month.");
                this.monthsComboBox.Focus();
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
                WHERE IS_ADMIN = 'false' AND NOT EXISTS (
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

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            // check if the AboutPage is already open
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form is AboutPage){
                    form.BringToFront();
                    return;
                }
            }

            AboutPage aboutPage = new AboutPage();
            aboutPage.Show();
        }
    }
}
