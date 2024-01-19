using System;

namespace Inventory_Management_System_Console_App
{
    public static class UserHandler
    {
        public static User CreateUser()
        {
            Console.WriteLine("Enter new user details:");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Choose User Role:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Employee");
            Console.WriteLine("3. Customer");
            Console.Write("Enter the number corresponding to the role: ");

            if (int.TryParse(Console.ReadLine(), out int roleChoice) && roleChoice >= 1 && roleChoice <= 3)
            {
                User.Role selectedRole = (User.Role)(roleChoice - 1);
                return new User(username, password, email, phoneNumber, address, selectedRole);
            }
            else
            {
                Console.WriteLine("Invalid role choice. Defaulting to Customer role.");
                return new User(username, password, email, phoneNumber, address, User.Role.Customer);
            }
        }
    }
}
