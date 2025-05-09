using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Runtime.CompilerServices;

namespace Super_Market.pages.admin
{
    public partial class CompanyManagement : Form
    {
        private MainWindow mainWindow;
        private int companyId;
        private string companyName;
        private string country;
        private string category;
        private List<string> countries = new List<string>
        {    
            "Not Chosen" ,
            // Arabic countries
            "Algeria", "Bahrain", "Egypt", "Iraq", "Jordan",
            "Kuwait", "Lebanon", "Libya", "Mauritania", "Morocco", "Oman", "Palestine",
            "Qatar", "Saudi Arabia", "Somalia", "Sudan", "Syria", "Tunisia", "United Arab Emirates", "Yemen",

            // Asian countries (non-Arabic)
            "Afghanistan", "China", "India", "Indonesia", "Iran",
            "Israel", "Japan", "Kazakhstan", "Malaysia",
            "North Korea", "Pakistan", "Philippines",
            "Russia", "Singapore", "South Korea", "Taiwan",
            "Thailand", "Turkey", "Vietnam",

            // European countries
            "Albania", "Andorra", "Austria", "Belarus", "Belgium",
            "Bulgaria", "Croatia", "Czech Republic", "Denmark", "Finland", "France",
            "Germany", "Greece", "Hungary", "Iceland", "Ireland", "Italy",
            "Norway", "Poland", "Portugal", "Romania", "Serbia", "Spain", "Sweden",
            "Switzerland", "Ukraine", "United Kingdom",

            // South American countries
            "Argentina", "Bolivia", "Brazil", "Chile", "Colombia",
            "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname",
            "Uruguay", "Venezuela",

            // North American countries
            "Canada", "Costa Rica", "Cuba", "Dominican Republic",
            "Jamaica", "Mexico", "Panama",
            "United States",
        };

        public CompanyManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.addCountryComboBox.Items.AddRange(countries.ToArray());
            this.updateCountryComboBox.Items.AddRange(countries.ToArray());

            this.addCountryComboBox.SelectedIndex = -1;
            this.updateCountryComboBox.SelectedIndex = -1;
        }

        private void loadCompanyTable()
        {
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"
                SELECT C.COMPID AS ID, C.NAME AS Company, C.COUNTRY AS Country, CAT.NAME AS Category
                FROM COMPANY AS C JOIN CATEGORY AS CAT ON C.CATE_ID = CAT.CID;
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView2.DataSource = table;
                dataGridView3.DataSource = table;
            }
        }

        private void CompanyManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'super_Market_DataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.super_Market_DataSet.CATEGORY);

            loadCompanyTable();

            this.addCategoryComboBox.SelectedIndex = -1;
            this.updateCategorycomboBox.SelectedIndex = -1;

            this.addCountryComboBox.SelectedIndex = -1;
            this.updateCountryComboBox.SelectedIndex = -1;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            AdminMenuPage adminMenuPage = new AdminMenuPage(this.mainWindow);
            adminMenuPage.Show();
            this.Close();
        }

        // ------------------------------------------- ADD COMPANY

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(addCompanyIdInput.Text))
            {
                this.addCompanyIdInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(addCompanyNameInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid company name.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addCompanyNameInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(addCategoryComboBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a valid category.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.addCategoryComboBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(addCountryComboBox.Text))
            {
                this.companyId = int.Parse(addCompanyIdInput.Text);
                this.companyName = addCompanyNameInput.Text;
                this.category = addCategoryComboBox.Text;
                this.country = "Not Chosen";
            }
            else
            {
                this.companyId = int.Parse(addCompanyIdInput.Text);
                this.companyName = addCompanyNameInput.Text;
                this.category = addCategoryComboBox.Text;
                this.country = addCountryComboBox.Text;
            }

           


            // Insert the new company into the database
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string getCategoryIdQuery = "SELECT CID FROM CATEGORY WHERE NAME = @CatName";
            string insertQuery = "INSERT INTO COMPANY (COMPID, NAME, COUNTRY, CATE_ID) VALUES (@Id, @Name, @Country, @CateId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand getCatCmd = new SqlCommand(getCategoryIdQuery, conn))
            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
            {
                conn.Open();


                int categoryId = -1;

                getCatCmd.Parameters.AddWithValue("@CatName", this.category);
                object result = getCatCmd.ExecuteScalar();
                categoryId = Convert.ToInt32(result);
                


                cmd.Parameters.AddWithValue("@Id", this.companyId);
                cmd.Parameters.AddWithValue("@Name", this.companyName);
                cmd.Parameters.AddWithValue("@Country", this.country);
                cmd.Parameters.AddWithValue("@CateId", categoryId);
                cmd.ExecuteNonQuery();
            }


                System.Windows.Forms.MessageBox.Show("Add Company Successfully...", "Success",
                    (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void refreshBtn1_Click(object sender, EventArgs e)
        {
            loadCompanyTable();
        }

        // ------------------------------------------- UPDATE COMPANY

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            if (!this.mainWindow.isValidInteger(updateCompanyIdInput.Text))
            {
                this.addCompanyIdInput.Focus();
                return;
            }

           
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string query = @"
                    SELECT C.NAME, C.COUNTRY, CAT.NAME AS Category 
                    FROM COMPANY C
                    JOIN CATEGORY CAT ON C.CATE_ID = CAT.CID
                    WHERE C.COMPID = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", int.Parse(updateCompanyIdInput.Text));
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        updateCompanyNameInput.Text = reader["NAME"].ToString();
                        updateCountryComboBox.Text = reader["COUNTRY"].ToString();
                        updateCategorycomboBox.Text = reader["Category"].ToString();
                        isFound = true;
                        updateCompanyNameInput.Enabled = true;
                        updateCategorycomboBox.Enabled = true;
                        updateCountryComboBox.Enabled = true;   
                        updateBtn.Enabled = true;


                    }
                }

            }



            if (!isFound)
            {
                System.Windows.Forms.MessageBox.Show("Company not found.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.updateCompanyIdInput.Focus();
                return;
            }


            // Load the company details into the update fields



            //
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(!this.mainWindow.isValidInteger(updateCompanyIdInput.Text)){
                this.updateCompanyIdInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(updateCompanyNameInput.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid company name.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.updateCompanyNameInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(updateCategorycomboBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please select a valid category.", "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                this.updateCategorycomboBox.Focus();
                return;
            }

            

            this.companyId = int.Parse(updateCompanyIdInput.Text);
            this.companyName = updateCompanyNameInput.Text;
            this.category = updateCategorycomboBox.Text;
            this.country = updateCountryComboBox.Text;

            // Update the company details in the database
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string getCategoryIdQuery = "SELECT CID FROM CATEGORY WHERE NAME = @CatName";
            string updateQuery = @"
                    UPDATE COMPANY
                    SET NAME = @Name, COUNTRY = @Country, CATE_ID = @CateId
                    WHERE COMPID = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand getCatCmd = new SqlCommand(getCategoryIdQuery, conn))
            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                conn.Open();
                int categoryId = -1;


                getCatCmd.Parameters.AddWithValue("@CatName", this.category);
                object result = getCatCmd.ExecuteScalar();
                categoryId = Convert.ToInt32(result);

                cmd.Parameters.AddWithValue("@Id", this.companyId);
                cmd.Parameters.AddWithValue("@Name", this.companyName);
                cmd.Parameters.AddWithValue("@Country", this.country);
                cmd.Parameters.AddWithValue("@CateId", categoryId);
                cmd.ExecuteNonQuery();
            }

                //

                System.Windows.Forms.MessageBox.Show("Update Company Successfully...", "Success",
                    (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            loadCompanyTable();
        }

        // ------------------------------------------- DELETE COMPANY

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!this.mainWindow.isValidInteger(deleteCompanyIdInput.Text)){
                this.deleteCompanyIdInput.Focus();
                return;
            }

            this.companyId = int.Parse(deleteCompanyIdInput.Text);

            // Check if the company ID exists in the database
            string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
            string checkQuery = "SELECT COUNT(*) FROM COMPANY WHERE COMPID = @CompanyId";
            string deleteQuery = "DELETE FROM COMPANY WHERE COMPID = @CompanyId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@CompanyId", companyId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Company ID not found.", "Error",
                            (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                        this.deleteCompanyIdInput.Focus();
                        return;
                    }
                }

                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@CompanyId", companyId);
                    deleteCmd.ExecuteNonQuery();
                }
            }




            System.Windows.Forms.MessageBox.Show("Delete Company Successfully...", "Success",
                (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        private void refreshBtn3_Click(object sender, EventArgs e)
        {
            loadCompanyTable();
        }

        private void updateCompanyIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCompanyNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addCountryComboBox.SelectedItem = countries[0];
        }

        private void addCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addCountryComboBox.SelectedItem = countries[0] ;
        }
    }
}
