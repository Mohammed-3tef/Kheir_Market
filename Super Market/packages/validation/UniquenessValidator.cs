using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market.packages.validation
{
    public class UniquenessValidator
    {
        private const string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";

        public static bool DoesUserIDExist(int userId)
        {
            string query = @"SELECT * FROM [USER]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["UID"]);
                        if (id == userId) return true;
                    }
                }
            }
            return false;
        }

        public static bool DoesCompanyIDExist(int companyId)
        {
            string query = @"SELECT * FROM COMPANY";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["COMPID"]);
                        if (id == companyId) return true;
                    }
                }
            }

            return false;
        }

        public static bool DoesDepartmentIDExist(int departmentId)
        {
            string query = @"SELECT * FROM DEPARTMENT";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["DID"]);
                        if (id == departmentId) return true;
                    }
                }
            }
            return false;
        }

        public static bool DoesProductIDExist(int productId)
        {
            string query = @"SELECT * FROM PRODUCT";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["PID"]);
                        if (id == productId) return true;
                    }
                }
            }
            return false;
        }

        public static bool DoesCategoryIDExist(int categoryId)
        {
            string query = @"SELECT * FROM CATEGORY";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["CID"]);
                        if (id == categoryId) return true;
                    }
                }
            }
            return false;
        }
    }
}
