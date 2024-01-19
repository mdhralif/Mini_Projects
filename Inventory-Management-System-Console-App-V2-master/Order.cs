using System;
using System.Collections.Generic;

namespace Inventory_Management_System_Console_App
{
    public class Order : ICloneable
    {
        private Product product;
        private Customer customer;
        private int quantity;
        private double price;
        private int orderID;
        private static int nextOrderID = 1;

        private List<Product> listOfProducts = new List<Product>();

        public Order(Product product, Customer customer, int quantity, double price)
        {
            this.product = product;
            this.customer = customer;
            this.quantity = quantity;
            this.price = this.quantity * price;
            this.orderID = nextOrderID;
            nextOrderID++;

            this.listOfProducts.Add(this.product);
            product.GetQuantity -= quantity;
        }

        // Copy constructor for cloning
        private Order(Order order)
        {
            this.product = order.product;
            this.customer = order.customer;
            this.quantity = order.quantity;
            this.price = order.price;
            this.orderID = order.orderID;
            this.listOfProducts.AddRange(order.listOfProducts);
        }

        public void AddProduct(Product newProduct)
        {
            listOfProducts.Add(newProduct);
        }

        public void RemoveProduct(Product productToRemove)
        {
            listOfProducts.Remove(productToRemove);
        }

        public void UpdateQuantity(int additionalQuantity)
        {
            this.quantity += additionalQuantity;
            this.price = this.quantity * product.GetPrice;
        }

        public void UpdatePrice(double newPrice)
        {
            this.price = this.quantity * newPrice;
        }

        public Product GetProduct => product;
        public Customer GetCustomer => customer;
        public int GetQuantity => quantity;
        public double GetPrice => price;
        public int GetID => orderID;

        public List<Product> GetListOfProducts => new List<Product>(listOfProducts);

        public object Clone()
        {
            return new Order(this);
        }
    }
}
