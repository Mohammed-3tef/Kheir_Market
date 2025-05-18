namespace Super_Market.packages.User
{
    public class User
    {
        private int ID;
        private string username;
        private string email;
        private string phone;
        private string address;
        private bool isAdmin;
        private string password;

        public User(int ID, string username, string email, string phone, string address, bool isAdmin, string password)
        {
            this.ID = ID;
            this.username = username;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.isAdmin = isAdmin;
            this.password = password;
        }
        // Getters
        public int GetID() { return this.ID; }
        public string GetUsername() { return this.username; }
        public string GetEmail() { return this.email; }
        public string GetPhone() { return this.phone; }
        public string GetAddress() { return this.address; }
        public bool IsAdmin() { return this.isAdmin; }
        public string GetPassword() { return this.password; }
        
        // Setters
        public void setData(string newName, string newEmail, string newPhone, string newAddress, bool newAdmin)
        {
            this.username = newName; 
            this.email = newEmail;
            this.phone = newPhone;
            this.address = newAddress;
            this.isAdmin = newAdmin;
        }
        public void SetPassword(string password) {  this.password = password; }
    }
}