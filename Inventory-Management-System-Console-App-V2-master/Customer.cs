using System;

namespace Inventory_Management_System_Console_App
{
    public class Customer : ICloneable
    {
        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        private int customerID;
        private static int nextCustomerID = 1;

        public Customer(string name, string address, string phoneNumber, string email = "")
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.customerID = nextCustomerID;
            nextCustomerID++;
        }

        // Copy constructor for cloning
        private Customer(Customer customer)
        {
            this.name = customer.name;
            this.address = customer.address;
            this.phoneNumber = customer.phoneNumber;
            this.email = customer.email;
            this.customerID = customer.customerID;
        }

        // Properties for retrieving customer information
        public string GetName => name;
        public string GetAddress => address;
        public string GetPhoneNumber => phoneNumber;
        public string GetEmail => email;
        public int GetCustomerID => customerID;

        // Clone method for ICloneable interface
        public object Clone()
        {
            return new Customer(this);
        }
    }
}
