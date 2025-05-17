using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Market.packages.User;
 
namespace Super_Market.packages.User
{
    public class RepositoryOfUsers
    {
        private List<User> users;
        private  string connectionString = "Data Source=.;Initial Catalog=Super_Market;Integrated Security=True;";
        
        public RepositoryOfUsers() {
            this.users = new List<User>();
            string query = @"SELECT * FROM [USER];";
            
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
            
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                            User user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),reader.GetBoolean(5),reader.GetString(6));
                            this.users.Add(user);  
                    }
                }
            }
        }

        public void addUser(User user) { 
            string query = "INSERT INTO [USER] ([UID], [NAME], [EMAIL], [PHONE], [ADDRESS], [IS_ADMIN], [PASSWORD]) " +
                           "VALUES (@UserID, @Username, @Email, @Phone, @Address, @IsAdmin, @Password)";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", user.GetID());
                command.Parameters.AddWithValue("@Username", user.GetUsername());
                command.Parameters.AddWithValue("@Email", user.GetEmail());
                command.Parameters.AddWithValue("@Phone", user.GetPhone());
                command.Parameters.AddWithValue("@Address", user.GetAddress());
                command.Parameters.AddWithValue("@IsAdmin", user.IsAdmin());
                command.Parameters.AddWithValue("@Password", user.GetPassword());
            
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // public List<User> getUsers() { 
        //     return this.users;
        // }

       public void deleteUser(User user) {
           string query = "DELETE FROM [USER] WHERE [UID] = @UserID";
           using (SqlConnection connection = new SqlConnection(this.connectionString))
           using (SqlCommand command = new SqlCommand(query, connection))
           {
               command.Parameters.AddWithValue("@UserID", user.GetID());
               
               connection.Open();
               command.ExecuteNonQuery();
           }

           this.users.Remove(user);
        }

        public void clearUsers(){
            this.users.Clear();
        }

        public User getUser(string username, string password){
            foreach (User user in users){
                if (user.GetUsername() == username && user.GetPassword() == password)
                    return user;
            }
            return null;
        }

        public User getUserByID(int ID){
            foreach (User user in users){
                if (user.GetID() == ID)
                    return user;
            }
            return null;
        }
    }
}