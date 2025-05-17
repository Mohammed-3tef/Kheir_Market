using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Super_Market.packages.display;

namespace Super_Market.pages.customer
{
    public partial class OrderManagement : Form
    {
        private MainWindow mainWindow;
        private int DID;

        public OrderManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void clearInputs()
        {
            this.addProductComboBox.DataSource = null;

            this.addDepartmentComboBox.SelectedIndex = -1;
            this.addProductComboBox.SelectedIndex = -1;

            this.fromInput.Value = 0;
            this.toInput.Value = 0;
            this.addQuantityInput.Value = 0;

            this.addProductComboBox.Enabled = false;
            this.addQuantityInput.Enabled = false;
            this.addBtn.Enabled = false;
        }

        private void loadProducts(int did, int minPrice, int maxPrice)
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"
                SELECT * FROM PRODUCT P
                WHERE P.Price BETWEEN @minPrice AND @maxPrice AND P.DID = @DID
            ";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@minPrice", minPrice);
                cmd.Parameters.AddWithValue("@maxPrice", maxPrice);
                cmd.Parameters.AddWithValue("@DID", did);
                conn.Open();

                DataTable productTable = new DataTable();
                adapter.Fill(productTable);
                productTable.Columns.Add("DisplayText", typeof(string));
                foreach (DataRow row in productTable.Rows)
                {
                    string name = row["NAME"].ToString();
                    decimal price = Convert.ToDecimal(row["PRICE"]);
                    row["DisplayText"] = $"{name} - ${price:F2}";
                }
                addProductComboBox.DisplayMember = "DisplayText";
                addProductComboBox.ValueMember = "PID";
                addProductComboBox.DataSource = productTable;
            }
        }

        private void loadTable(int userId)
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"
                SELECT 
                    OD.ORDER_ID AS [Order ID],
                    P.NAME AS [Product Name],
                    OD.QUANTITY AS Quantity,
                    C.NAME AS Company,
                    D.NAME AS Department
                FROM ORDER_DETAILS OD
                JOIN PRODUCT P ON OD.PID = P.PID
                JOIN COMPANY C ON P.COMPID = C.COMPID
                JOIN DEPARTMENT D ON P.DID = D.DID
                JOIN [USER] U ON OD.UID = U.UID
                WHERE U.UID = @UID
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@UID", userId);

                DataTable productTable = new DataTable();
                adapter.Fill(productTable);

                dataGridView1.DataSource = productTable;
                dataGridView2.DataSource = productTable;
                dataGridView3.DataSource = productTable;
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            CustomerMenuPage customerMenuPage = new CustomerMenuPage(this.mainWindow);
            customerMenuPage.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.addDepartmentComboBox.SelectedValue == null) {
                MessageDisplay.ShowError("Please enter a valid department.");
                this.addDepartmentComboBox.Focus();
                return;
            }

            if (this.addProductComboBox.SelectedValue == null) {
                MessageDisplay.ShowError("Please enter a valid Product.");
                this.addProductComboBox.Focus();
                return;
            }

            if (this.addQuantityInput.Value <= 0)
            {
                MessageDisplay.ShowError("Please enter a valid quantity.");
                this.addQuantityInput.Focus();
                return;
            }

            // Add in database



            //

            MessageDisplay.ShowSuccess("Add Order Successfully...");
            loadTable(this.mainWindow.user.GetID());
            clearInputs();
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'super_Market_DataSet.DEPARTMENT' table. You can move, or remove it, as needed.
            this.dEPARTMENTTableAdapter1.Fill(this.super_Market_DataSet1.DEPARTMENT);

            loadTable(this.mainWindow.user.GetID());

            this.addDepartmentComboBox.SelectedIndex = -1;
            this.addProductComboBox.SelectedIndex = -1;

            this.fromInput.Maximum = 1000000;
            this.toInput.Maximum = 1000000;

            this.fromInput.Value = 0;
            this.toInput.Value = 1000000;
        }

        private void addDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.addDepartmentComboBox.SelectedIndex == -1){
                clearInputs();
                return;
            }

            this.DID = Convert.ToInt32(this.addDepartmentComboBox.SelectedValue);

            loadProducts(this.DID, 0, 1000000);

            this.addProductComboBox.SelectedIndex = -1;
            this.addProductComboBox.Enabled = true;
            this.addQuantityInput.Enabled = true;
            this.addBtn.Enabled = true;
        }

        private void fromInput_ValueChanged(object sender, EventArgs e)
        {
            loadProducts(
                this.DID, 
                Convert.ToInt32(this.fromInput.Value),
                Convert.ToInt32(this.toInput.Value)
            );
            this.addProductComboBox.SelectedIndex = -1;
        }

        private void toInput_ValueChanged(object sender, EventArgs e)
        {
            loadProducts(
                this.DID,
                Convert.ToInt32(this.fromInput.Value),
                Convert.ToInt32(this.toInput.Value)
            );
            this.fromInput.Maximum = this.toInput.Value;
            this.addProductComboBox.SelectedIndex = -1;
        }

        // -------------------------------------------- UPDATE ORDER

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (this.addQuantityInput.Value <= 0)
            {
                MessageDisplay.ShowError("Please enter a valid quantity.");
                this.addQuantityInput.Focus();
                return;
            }

            // Update in database



            //

            MessageDisplay.ShowSuccess("Update Order Successfully...");
            loadTable(this.mainWindow.user.GetID());
            clearInputs();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(Validator.IsValidInteger(this.updateOrderIdInput.Text)) {
                MessageDisplay.ShowError("Please enter a valid Order ID.");
                this.updateOrderIdInput.Focus();
                return;
            }

            // Search in database



            //
        }

        // -------------------------------------------- DELETE ORDER

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.deleteOrderIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid Order ID.");
                this.deleteOrderIdInput.Focus();
                return;
            }

            // Delete in database



            //

            MessageDisplay.ShowSuccess("Delete Order Successfully...");
            loadTable(this.mainWindow.user.GetID());
            clearInputs();
        }
    }
}
