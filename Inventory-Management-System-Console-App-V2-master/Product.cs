// Product.cs
using System;

namespace Inventory_Management_System_Console_App
{
    public class Product : ICloneable
    {
        private string name;
        private int quantity;
        private double price;
        private Category category;
        private int productID;
        private static int nextProductID = 1;

        public Product(string name, int quantity, double price, Category category)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.category = category;
            this.productID = nextProductID++;
        }

        // Copy constructor for cloning
        public Product(Product product)
        {
            this.name = product.name;
            this.quantity = product.quantity;
            this.price = product.price;
            this.category = product.category;
            this.productID = product.productID;
        }

        // Properties for retrieving product information
        public string GetName => name;
        public int GetQuantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double GetPrice
        {
            get { return price; }
            set { price = value; }
        }
        public Category GetCategory => category;
        public int GetID => productID;

        // Clone method for ICloneable interface
        public object Clone()
        {
            return new Product(this);
        }

        // Override Equals method for proper comparison
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Product))
                return false;

            Product otherProduct = (Product)obj;
            return this.name == otherProduct.name &&
                   this.quantity == otherProduct.quantity &&
                   this.price == otherProduct.price &&
                   this.category == otherProduct.category &&
                   this.productID == otherProduct.productID;
        }

        // Override GetHashCode for consistent hashing
        public override int GetHashCode()
        {
            return HashCode.Combine(name, quantity, price, category, productID);
        }
    }
}
