using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using Super_Market.packages.display;
using Super_Market.packages.User;

namespace Super_Market.pages.customer
{
    // ================================================== Order Management ===================================  
    public partial class OrderManagement : Form
    {
        private MainWindow mainWindow;
        private int DID;

        public OrderManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }


        // ================================ Clear Inputs ===========================  
        private void clearInputs()
        {
            this.addProductComboBox.DataSource = null;
            this.addDepartmentComboBox.SelectedIndex = -1;
            this.addProductComboBox.SelectedIndex = -1;
            this.fromInput.Value = 0;
            this.toInput.Value = 0;
            this.addQuantityInput.Value = 0;
            this.updateQuantityInput.Value = 0;
            this.addProductComboBox.Enabled = false;
            this.addQuantityInput.Enabled = false;
            this.addBtn.Enabled = false;
            this.updateBtn.Enabled = false;
        }

        // ================================ Load Products ===========================  
        private void loadProducts(int did, int minPrice, int maxPrice)
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"SELECT * FROM PRODUCT P WHERE P.Price BETWEEN @minPrice AND @maxPrice AND P.DID = @DID";

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

        // ================================ Load Table ===========================  
        private void loadTable(int userId)
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"SELECT OD.ORDER_ID AS [Order ID], P.NAME AS [Product Name], OD.QUANTITY AS Quantity, 
                    P.PRICE AS [Unit Price], (OD.QUANTITY * P.PRICE) AS [Total Price],
                    C.NAME AS Company, D.NAME AS Department FROM ORDER_DETAILS OD
                    JOIN PRODUCT P ON OD.PID = P.PID JOIN COMPANY C ON P.COMPID = C.COMPID
                    JOIN DEPARTMENT D ON P.DID = D.DID JOIN [USER] U ON OD.UID = U.UID
                    WHERE U.UID = @UID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@UID", userId);
                DataTable productTable = new DataTable();
                adapter.Fill(productTable);

                // Calculate the grand total
                decimal grandTotal = 0;
                foreach (DataRow row in productTable.Rows)
                {
                    grandTotal += Convert.ToDecimal(row["Total Price"]);
                }

                // Add a footer row with the grand total
                if (productTable.Rows.Count > 0)
                {
                    DataRow footerRow = productTable.NewRow();
                    footerRow["Product Name"] = "TOTAL";
                    footerRow["Total Price"] = grandTotal;
                    productTable.Rows.Add(footerRow);
                }

                dataGridView1.DataSource = productTable;
                dataGridView2.DataSource = productTable;
                dataGridView3.DataSource = productTable;

                // Format the currency columns
                foreach (DataGridView gridView in new[] { dataGridView1, dataGridView2, dataGridView3 })
                {
                    if (gridView.Columns.Contains("Unit Price"))
                    {
                        gridView.Columns["Unit Price"].DefaultCellStyle.Format = "C2";
                    }
                    if (gridView.Columns.Contains("Total Price"))
                    {
                        gridView.Columns["Total Price"].DefaultCellStyle.Format = "C2";
                        // Make the total row bold
                        if (productTable.Rows.Count > 0)
                        {
                            gridView.Rows[gridView.Rows.Count - 1].DefaultCellStyle.Font =
                                new Font(gridView.Font, FontStyle.Bold);
                        }
                    }
                }
            }
        }

        // ================================ Menu Btn ===========================  
        private void menuBtn_Click(object sender, EventArgs e)
        {
            CustomerMenuPage customerMenuPage = new CustomerMenuPage(this.mainWindow);
            customerMenuPage.Show();
            this.Close();
        }

        // ================================ Load Order Management ===========================  
        private void OrderManagement_Load(object sender, EventArgs e)
        {
            this.dEPARTMENTTableAdapter1.Fill(this.super_Market_DataSet1.DEPARTMENT);
            loadTable(this.mainWindow.user.GetID());
            this.addDepartmentComboBox.SelectedIndex = -1;
            this.addProductComboBox.SelectedIndex = -1;
            this.fromInput.Maximum = 1000000;
            this.toInput.Maximum = 1000000;
            this.fromInput.Value = 0;
            this.toInput.Value = 1000000;
        }

        // ================================ Department Box ===========================  
        private void addDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.addDepartmentComboBox.SelectedIndex == -1)
            {
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

        // ================================ From Input ===========================  
        private void fromInput_ValueChanged(object sender, EventArgs e)
        {
            loadProducts(this.DID, Convert.ToInt32(this.fromInput.Value), Convert.ToInt32(this.toInput.Value));
            this.addProductComboBox.SelectedIndex = -1;
        }

        // ================================ To Inputs ===========================  
        private void toInput_ValueChanged(object sender, EventArgs e)
        {
            loadProducts(this.DID, Convert.ToInt32(this.fromInput.Value), Convert.ToInt32(this.toInput.Value));
            this.fromInput.Maximum = this.toInput.Value;
            this.addProductComboBox.SelectedIndex = -1;
        }



        // ================================ Add Btn ===========================  
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.addDepartmentComboBox.SelectedValue == null)
            {
                MessageDisplay.ShowError("Please enter a valid department.");
                this.addDepartmentComboBox.Focus();
                return;
            }

            if (this.addProductComboBox.SelectedValue == null)
            {
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

            int productId = Convert.ToInt32(this.addProductComboBox.SelectedValue);
            int userId = this.mainWindow.user.GetID();
            int quantity = Convert.ToInt32(this.addQuantityInput.Value);
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string checkStockQuery = @"SELECT S.PRODUCT_QUANTITY FROM STOCK S 
                                         JOIN PRODUCT P ON S.PROD_ID = P.PID 
                                         WHERE P.PID = @ProductId";
                        SqlCommand checkStockCmd = new SqlCommand(checkStockQuery, conn, transaction);
                        checkStockCmd.Parameters.AddWithValue("@ProductId", productId);
                        int availableQuantity = Convert.ToInt32(checkStockCmd.ExecuteScalar());

                        if (availableQuantity < quantity)
                        {
                            throw new Exception($"Not enough stock available. Only {availableQuantity} items in stock.");
                        }

                        string getPriceQuery = "SELECT PRICE FROM PRODUCT WHERE PID = @ProductId";
                        SqlCommand getPriceCmd = new SqlCommand(getPriceQuery, conn, transaction);
                        getPriceCmd.Parameters.AddWithValue("@ProductId", productId);
                        decimal price = Convert.ToDecimal(getPriceCmd.ExecuteScalar());
                        decimal total = price * quantity;

                        string insertOrderQuery = @"INSERT INTO [ORDER] (TOTAL_PRICE, ORDER_DATE) VALUES (@Total, GETDATE());
                                        SELECT SCOPE_IDENTITY();";
                        SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, conn, transaction);
                        insertOrderCmd.Parameters.AddWithValue("@Total", total);
                        int newOrderId = Convert.ToInt32(insertOrderCmd.ExecuteScalar());

                        string getNextOrderIdQuery = "SELECT ISNULL(MAX(ORDER_ID), 0) + 1 FROM ORDER_DETAILS";
                        SqlCommand getNextOrderIdCmd = new SqlCommand(getNextOrderIdQuery, conn, transaction);
                        int nextOrderDetailId = Convert.ToInt32(getNextOrderIdCmd.ExecuteScalar());

                        string insertDetailsQuery = @"INSERT INTO ORDER_DETAILS (OID, PID, UID, ORDER_ID, QUANTITY) 
                                          VALUES (@OrderId, @ProductId, @UserId, @OrderDetailId, @Quantity);";
                        SqlCommand insertDetailsCmd = new SqlCommand(insertDetailsQuery, conn, transaction);
                        insertDetailsCmd.Parameters.AddWithValue("@OrderId", newOrderId);
                        insertDetailsCmd.Parameters.AddWithValue("@ProductId", productId);
                        insertDetailsCmd.Parameters.AddWithValue("@UserId", userId);
                        insertDetailsCmd.Parameters.AddWithValue("@OrderDetailId", nextOrderDetailId);
                        insertDetailsCmd.Parameters.AddWithValue("@Quantity", quantity);
                        insertDetailsCmd.ExecuteNonQuery();

                        string updateStockQuery = "UPDATE STOCK SET PRODUCT_QUANTITY = PRODUCT_QUANTITY - @Quantity WHERE PROD_ID = @ProductId";
                        SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn, transaction);
                        updateStockCmd.Parameters.AddWithValue("@Quantity", quantity);
                        updateStockCmd.Parameters.AddWithValue("@ProductId", productId);
                        updateStockCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageDisplay.ShowSuccess("Order added successfully!");
                        loadTable(this.mainWindow.user.GetID());
                        clearInputs();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageDisplay.ShowError($"Failed to add order: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageDisplay.ShowError($"Database connection error: {ex.Message}");
            }
        }

       // ================================ Update Btn ===========================  
          
        private void updateBtn_Click(object sender, EventArgs e)
            {
                try
                {

                    if (!int.TryParse(this.updateOrderIdInput.Text, out int orderId) || orderId <= 0)
                    {
                        MessageDisplay.ShowError("Please enter a valid positive Order ID.");
                        this.updateOrderIdInput.Focus();
                        return;
                    }

                    if (this.updateQuantityInput.Value <= 0)
                    {
                        MessageDisplay.ShowError("Quantity must be greater than 0.");
                        this.updateQuantityInput.Focus();
                        return;
                    }

                    int quantity = Convert.ToInt32(this.updateQuantityInput.Value);
                    int userId = this.mainWindow.user.GetID();
                    string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                string verifyQuery = @"SELECT COUNT(1), OD.PID, P.PRICE, OD.OID, OD.QUANTITY 
                                       FROM ORDER_DETAILS OD
                                       JOIN PRODUCT P ON OD.PID = P.PID 
                                       JOIN [USER] U ON OD.UID = U.UID
                                       WHERE OD.ORDER_ID = @OrderID AND U.UID = @UserID 
                                       GROUP BY OD.PID, P.PRICE, OD.OID, OD.QUANTITY";

                                SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn, transaction);
                                verifyCmd.Parameters.AddWithValue("@OrderID", orderId);
                                verifyCmd.Parameters.AddWithValue("@UserID", userId);

                                using (SqlDataReader reader = verifyCmd.ExecuteReader())
                                {
                                    if (!reader.HasRows)
                                    {
                                        throw new Exception("Order not found or doesn't belong to current user.");
                                    }

                                    reader.Read();
                                    int pid = reader.GetInt32(1);
                                    decimal price = reader.GetDecimal(2);
                                    int oid = reader.GetInt32(3);
                                    int oldQuantity = reader.GetInt32(4);
                                    reader.Close();

                                    int quantityDifference = quantity - oldQuantity;

                                    if (quantityDifference > 0)
                                    {
                                        string checkStockQuery = "SELECT PRODUCT_QUANTITY FROM STOCK WHERE PROD_ID = @ProductId";
                                        SqlCommand checkStockCmd = new SqlCommand(checkStockQuery, conn, transaction);
                                        checkStockCmd.Parameters.AddWithValue("@ProductId", pid);
                                        int availableQuantity = Convert.ToInt32(checkStockCmd.ExecuteScalar());

                                        if (availableQuantity < quantityDifference)
                                        {
                                            throw new Exception($"Not enough stock available. Only {availableQuantity} items in stock.");
                                        }
                                    }

                                    string updateDetailsQuery = @"UPDATE ORDER_DETAILS SET QUANTITY = @Quantity WHERE ORDER_ID = @OrderID";
                                    SqlCommand updateDetailsCmd = new SqlCommand(updateDetailsQuery, conn, transaction);
                                    updateDetailsCmd.Parameters.AddWithValue("@Quantity", quantity);
                                    updateDetailsCmd.Parameters.AddWithValue("@OrderID", orderId);
                                    int rowsAffected = updateDetailsCmd.ExecuteNonQuery();

                                    if (rowsAffected == 0)
                                    {
                                        throw new Exception("Failed to update order details.");
                                    }

                                    decimal totalPrice = price * quantity;
                                    string updateTotalQuery = @"UPDATE [ORDER] SET TOTAL_PRICE = @TotalPrice WHERE OID = @OID";
                                    SqlCommand updateTotalCmd = new SqlCommand(updateTotalQuery, conn, transaction);
                                    updateTotalCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                                    updateTotalCmd.Parameters.AddWithValue("@OID", oid);
                                    updateTotalCmd.ExecuteNonQuery();

                                    string updateStockQuery = "UPDATE STOCK SET PRODUCT_QUANTITY = PRODUCT_QUANTITY - @Difference WHERE PROD_ID = @ProductId";
                                    SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn, transaction);
                                    updateStockCmd.Parameters.AddWithValue("@Difference", quantityDifference);
                                    updateStockCmd.Parameters.AddWithValue("@ProductId", pid);
                                    updateStockCmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageDisplay.ShowSuccess("Order updated successfully.");
                                loadTable(userId);
                                clearInputs();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageDisplay.ShowError($"Failed to update order: {ex.Message}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageDisplay.ShowError($"Error: {ex.Message}");
                }
            }

        // ================================ Search Btn ===========================  
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.updateQuantityInput.Value = 0;
                this.updateQuantityInput.Enabled = false;
                this.updateBtn.Enabled = false;

                if (!int.TryParse(this.updateOrderIdInput.Text, out int orderId) || orderId <= 0)
                {
                    MessageDisplay.ShowError("Please enter a valid positive Order ID.");
                    return;
                }

                string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT OD.QUANTITY FROM ORDER_DETAILS OD
                                   JOIN [USER] U ON OD.UID = U.UID
                                   WHERE OD.ORDER_ID = @OrderID AND U.UID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        cmd.Parameters.AddWithValue("@UserID", this.mainWindow.user.GetID());

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            this.updateQuantityInput.Value = Convert.ToDecimal(result);
                            this.updateQuantityInput.Enabled = true;
                            this.updateBtn.Enabled = true;
                            MessageDisplay.ShowSuccess("Order found and ready for update.");
                        }
                        else
                        {
                            MessageDisplay.ShowWarning("Order not found or doesn't belong to you.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageDisplay.ShowError($"Search error: {ex.Message}");
            }
        }

        // ================================ Delete Btn ===========================  
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.deleteOrderIdInput.Text, out int orderId))
            {
                MessageDisplay.ShowError("Please enter a valid Order ID.");
                this.deleteOrderIdInput.Focus();
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string getDetailsQuery = @"SELECT OD.OID, OD.PID, OD.QUANTITY 
                                       FROM ORDER_DETAILS OD
                                       JOIN [USER] U ON OD.UID = U.UID
                                       WHERE OD.ORDER_ID = @OrderID AND U.UID = @UserID";

                        SqlCommand getDetailsCmd = new SqlCommand(getDetailsQuery, conn, transaction);
                        getDetailsCmd.Parameters.AddWithValue("@OrderID", orderId);
                        getDetailsCmd.Parameters.AddWithValue("@UserID", this.mainWindow.user.GetID());

                        SqlDataReader reader = getDetailsCmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            reader.Close();
                            throw new Exception("Order not found or doesn't belong to you.");
                        }

                        reader.Read();
                        int oid = reader.GetInt32(0);
                        int pid = reader.GetInt32(1);
                        int quantity = reader.GetInt32(2);
                        reader.Close();

                        string deleteDetailsQuery = "DELETE FROM ORDER_DETAILS WHERE ORDER_ID = @OrderID";
                        SqlCommand deleteDetailsCmd = new SqlCommand(deleteDetailsQuery, conn, transaction);
                        deleteDetailsCmd.Parameters.AddWithValue("@OrderID", orderId);
                        deleteDetailsCmd.ExecuteNonQuery();

                        string deleteOrderQuery = "DELETE FROM [ORDER] WHERE OID = @OID";
                        SqlCommand deleteOrderCmd = new SqlCommand(deleteOrderQuery, conn, transaction);
                        deleteOrderCmd.Parameters.AddWithValue("@OID", oid);
                        deleteOrderCmd.ExecuteNonQuery();

                        string restoreStockQuery = "UPDATE STOCK SET PRODUCT_QUANTITY = PRODUCT_QUANTITY + @Quantity WHERE PROD_ID = @ProductId";
                        SqlCommand restoreStockCmd = new SqlCommand(restoreStockQuery, conn, transaction);
                        restoreStockCmd.Parameters.AddWithValue("@Quantity", quantity);
                        restoreStockCmd.Parameters.AddWithValue("@ProductId", pid);
                        restoreStockCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageDisplay.ShowSuccess("Order deleted successfully.");
                        loadTable(this.mainWindow.user.GetID());
                        clearInputs();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageDisplay.ShowError("Failed to delete order. Error: " + ex.Message);
            }
        }
    }
}