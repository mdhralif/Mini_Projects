// Program.cs
using System;
using System.Collections.Generic;

namespace Inventory_Management_System_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFilePath = @"D:\Downloads\Inventory-Management-System-Console-App-V2-master\UserData.txt";
            string inventoryFilePath = @"D:\Downloads\Inventory-Management-System-Console-App-V2-master\InventoryData.txt";

            List<User> users = UserDataHandler.RetrieveUsers(userFilePath);

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Create a new user");
            Console.WriteLine("2. Store inventory information");
            Console.WriteLine("3. Search for product by name");
            Console.Write("Enter the number corresponding to the action: ");

            if (int.TryParse(Console.ReadLine(), out int actionChoice))
            {
                switch (actionChoice)
                {
                    case 1:
                        User newUser = CreateUser();
                        Console.WriteLine("New User Created:");
                        Console.WriteLine($"Username: {newUser.GetUsername}, Role: {newUser.GetRole}");
                        users.Add(newUser);
                        UserDataHandler.StoreUsers(users, userFilePath);
                        Console.WriteLine("User data stored successfully.");
                        break;

                    case 2:
                        List<Product> inventory = CreateInventory();
                        InventoryHandler.StoreInventory(inventory, inventoryFilePath);
                        Console.WriteLine("\nInventory Data Stored:");
                        foreach (var product in inventory)
                        {
                            Console.WriteLine($"Product: {product.GetName}, Quantity: {product.GetQuantity}, Price: {product.GetPrice}, Category: {product.GetCategory.GetName}");
                        }
                        break;

                    case 3:
                        Console.Write("Enter the product name to search: ");
                        string searchProductName = Console.ReadLine();
                        InventoryHandler.SearchProductByName(searchProductName, inventoryFilePath);
                        break;

                    default:
                        Console.WriteLine("Invalid action choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input for action choice.");
            }
        }

        static User CreateUser()
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

        static List<Product> CreateInventory()
        {
            List<Product> inventory = new List<Product>();

            Console.Write("\nEnter the number of products to add to the inventory: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfProducts) && numberOfProducts > 0)
            {
                for (int i = 0; i < numberOfProducts; i++)
                {
                    Console.WriteLine($"\nEnter details for Product {i + 1}:");

                    Console.Write("Product Name: ");
                    string productName = Console.ReadLine();

                    Console.Write("Quantity: ");
                    if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
                    {
                        Console.Write("Price: ");
                        if (double.TryParse(Console.ReadLine(), out double price) && price >= 0)
                        {
                            Console.Write("Category: ");
                            string category = Console.ReadLine();

                            inventory.Add(new Product(productName, quantity, price, new Category(category)));
                        }
                        else
                        {
                            Console.WriteLine("Invalid price. Product not added.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity. Product not added.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number of products. No products added to the inventory.");
            }

            return inventory;
        }
    }
}
