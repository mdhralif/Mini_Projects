using System;
using System.Collections.Generic;

namespace Inventory_Management_System_Console_App
{
    public class Category : ICloneable
    {
        private string name;
        private List<string> subCategories;
        private int categoryID;
        private static int nextCategoryID = 1;

        public Category(string name)
        {
            this.name = name;
            this.categoryID = nextCategoryID;
            this.subCategories = new List<string>();
            nextCategoryID++;
        }

        // Copy constructor for cloning
        private Category(Category category)
        {
            this.name = category.name;
            this.categoryID = category.categoryID;
            this.subCategories = new List<string>(category.subCategories);
        }

        // Property for retrieving category name
        public string GetName
        {
            get { return name; }
        }

        // Property for retrieving category ID
        public int GetCategoryID
        {
            get { return categoryID; }
        }

        // Method to add a subcategory
        public void AddSubCategory(string subCategoryName)
        {
            this.subCategories.Add(subCategoryName);
        }

        // Method to remove a subcategory
        public void RemoveSubCategory(string subCategoryName)
        {
            this.subCategories.RemoveAll(o => o == subCategoryName);
        }

        // Clone method for ICloneable interface
        public object Clone()
        {
            return new Category(this);
        }

        // Method to get a list of subcategories
        public List<string> GetSubCategories()
        {
            return new List<string>(subCategories);
        }
    }
}
