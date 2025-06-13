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
using Kheir_Market.packages.display;
using Kheir_Market.packages.validation;

namespace Kheir_Market.pages.admin
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
        private const string connectionString = "Data Source=.;Initial Catalog=Kheir_Market;Integrated Security=True;";

        public CompanyManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.addCountryComboBox.Items.AddRange(countries.ToArray());
            this.updateCountryComboBox.Items.AddRange(countries.ToArray());

            this.addCountryComboBox.SelectedIndex = -1;
            this.updateCountryComboBox.SelectedIndex = -1;

            this.FormClosing += this.mainWindow.formClosing;
        }

        private void cleanInputs()
        {
            this.addCompanyIdInput.Clear();
            this.addCompanyNameInput.Clear();
            this.updateCompanyIdInput.Clear();
            this.updateCompanyNameInput.Clear();
            this.deleteCompanyIdInput.Clear();

            this.addCountryComboBox.SelectedIndex = -1;
            this.addCategoryComboBox.SelectedIndex = -1;
            this.updateCountryComboBox.SelectedIndex = -1;
            this.updateCategorycomboBox.SelectedIndex = -1;

            this.updateCompanyNameInput.Enabled = false;
            this.updateCategorycomboBox.Enabled = false;
            this.updateCountryComboBox.Enabled = false;
            this.updateBtn.Enabled = false;
        }

        private void loadCompanyTable()
        {
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
            // TODO: This line of code loads data into the 'super_Market_DataSet1.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.Kheir_Market_DataSet.CATEGORY);

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
            this.FormClosing -= this.mainWindow.formClosing;
            this.Close();
        }

        // ------------------------------------------- ADD COMPANY

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(this.addCompanyIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid company ID.");
                this.addCompanyIdInput.Focus();
                return;
            }

            if (UniquenessValidator.DoesCompanyIDExist(int.Parse(this.addCompanyIdInput.Text)))
            {
                MessageDisplay.ShowError("This company ID already exists.");
                this.addCompanyIdInput.Focus();
                return;
            }

            if (!Validator.IsValidName(this.addCompanyNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid company name.");
                this.addCompanyNameInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.addCategoryComboBox.Text))
            {
                MessageDisplay.ShowError("Please select a valid category.");
                this.addCategoryComboBox.Focus();
                return;
            }

            this.companyId = int.Parse(addCompanyIdInput.Text);
            this.companyName = addCompanyNameInput.Text;
            this.category = addCategoryComboBox.Text;
            this.country = string.IsNullOrWhiteSpace(addCountryComboBox.Text) ? "Not Chosen" : addCountryComboBox.Text;


            // Insert the new company into the database
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

            MessageDisplay.ShowSuccess("Company added successfully.");
            cleanInputs();
            loadCompanyTable();
        }

        // ------------------------------------------- UPDATE COMPANY

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(updateCompanyIdInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid company ID.");
                this.updateCompanyIdInput.Focus();
                return;
            }

            if (!UniquenessValidator.DoesCompanyIDExist(int.Parse(updateCompanyIdInput.Text)))
            {
                MessageDisplay.ShowError("This company ID does not exist.");
                this.updateCompanyIdInput.Focus();
                return;
            }

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
                        updateCategorycomboBox.Text = reader["CATEGORY"].ToString();

                        updateCompanyNameInput.Enabled = true;
                        updateCategorycomboBox.Enabled = true;
                        updateCountryComboBox.Enabled = true;   
                        updateBtn.Enabled = true;
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(!Validator.IsValidInteger(updateCompanyIdInput.Text)){
                MessageDisplay.ShowError("Please enter a valid company ID.");
                this.updateCompanyIdInput.Focus();
                return;
            }

            if (!Validator.IsValidName(updateCompanyNameInput.Text))
            {
                MessageDisplay.ShowError("Please enter a valid company name.");
                this.updateCompanyNameInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(updateCategorycomboBox.Text))
            {
                MessageDisplay.ShowError("Please select a valid category.");
                this.updateCategorycomboBox.Focus();
                return;
            }

            this.companyId = int.Parse(updateCompanyIdInput.Text);
            this.companyName = updateCompanyNameInput.Text;
            this.category = updateCategorycomboBox.Text;
            this.country = updateCountryComboBox.Text;

            // Update the company details in the database
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

            MessageDisplay.ShowSuccess("Company updated successfully.");
            cleanInputs();
            loadCompanyTable();
        }

        // ------------------------------------------- DELETE COMPANY

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidInteger(deleteCompanyIdInput.Text)){
                MessageDisplay.ShowError("Please enter a valid company ID.");
                this.deleteCompanyIdInput.Focus();
                return;
            }

            if (!UniquenessValidator.DoesCompanyIDExist(int.Parse(deleteCompanyIdInput.Text)))
            {
                MessageDisplay.ShowError("This company ID does not exist.");
                this.deleteCompanyIdInput.Focus();
                return;
            }

            this.companyId = int.Parse(deleteCompanyIdInput.Text);

            string deleteQuery = "DELETE FROM COMPANY WHERE COMPID = @CompanyId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@CompanyId", companyId);
                    deleteCmd.ExecuteNonQuery();
                }
            }

            MessageDisplay.ShowSuccess("Company deleted successfully.");
            cleanInputs();
            loadCompanyTable();
        }
    }
}
