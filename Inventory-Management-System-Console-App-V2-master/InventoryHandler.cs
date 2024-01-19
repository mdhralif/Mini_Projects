// InventoryHandler.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace Inventory_Management_System_Console_App
{
    public class InventoryHandler
    {
        public static List<Product> RetrieveInventory(string fileName)
        {
            List<Product> retrievedInventory = new List<Product>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] productData = line.Split(',');

                        Category category = new Category(productData[3]);
                        Product product = new Product(productData[0], int.Parse(productData[1]), double.Parse(productData[2]), category, int.Parse(productData[4]));

                        retrievedInventory.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving inventory data: {ex.Message}");
            }

            return retrievedInventory;
        }


        public static void SearchProductByName(string productName, string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] productData = line.Split(',');

                        if (productData.Length >= 1 && productData[0] == productName)
                        {
                            Console.WriteLine($"Product Found: {line}");
                            return;
                        }
                    }

                    Console.WriteLine($"Product with name '{productName}' not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching for product: {ex.Message}");
            }
        }
        public static void StoreInventory(List<Product> inventory, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (var product in inventory)
                    {
                        string productData = $"{product.GetName},{product.GetQuantity},{product.GetPrice},{product.GetCategory.GetName},{product.GetID}";
                        writer.WriteLine(productData);
                    }
                }
                Console.WriteLine("Inventory data stored successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error storing inventory data: {ex.Message}");
            }
        }
    }
}
