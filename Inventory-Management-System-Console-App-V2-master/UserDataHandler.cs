// UserDataHandler.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace Inventory_Management_System_Console_App
{
    public class UserDataHandler
    {
        public static List<User> RetrieveUsers(string fileName)
        {
            List<User> retrievedUsers = new List<User>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] userData = line.Split(',');

                        User user = new User(userData[0], userData[1], userData[2], userData[3], userData[4], (User.Role)Enum.Parse(typeof(User.Role), userData[5]));
                        retrievedUsers.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving user data: {ex.Message}");
            }

            return retrievedUsers;
        }

        public static void StoreUsers(List<User> users, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (var user in users)
                    {
                        string userData = $"{user.GetUsername},{user.GetPassword},{user.GetEmail},{user.GetPhoneNumber},{user.GetAddress},{user.GetRole},{user.GetUserID}";
                        writer.WriteLine(userData);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error storing user data: {ex.Message}");
            }
        }
    }
}
