using System;

namespace Inventory_Management_System_Console_App
{
    public class User : ICloneable
    {
        private string username;
        private string password;
        private string email;
        private string phoneNumber;
        private string address;
        private Role role;
        private int userID;
        private static int nextUserID = 1;  // Start from 1 to avoid 0 as a user ID

        public enum Role
        {
            Admin,
            Employee,
            Customer
        }

        public User(string username, string password, string email, string phoneNumber, string address, Role role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.role = role;
            this.userID = nextUserID++;
        }

        // Copy constructor for cloning
        private User(User user)
        {
            this.username = user.username;
            this.password = user.password;
            this.email = user.email;
            this.phoneNumber = user.phoneNumber;
            this.address = user.address;
            this.role = user.role;
            this.userID = user.userID;
        }

        // Properties for retrieving user information
        public string GetUsername => username;
        public string GetPassword => password;
        public string GetEmail => email;
        public string GetPhoneNumber => phoneNumber;
        public string GetAddress => address;
        public Role GetRole => role;
        public int GetUserID => userID;

        // Methods to check user roles
        public bool IsAdmin => role == Role.Admin;
        public bool IsEmployee => role == Role.Employee;

        // Clone method for ICloneable interface
        public object Clone()
        {
            return new User(this);
        }
    }
}
