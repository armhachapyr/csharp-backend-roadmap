using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2Repeat
{
    internal class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public bool IsInStock
        {
            get { return Stock > 0; }
        }
        public decimal TotalValue
        {
            get { return Price * Stock; }
        }
        public Product(int id, string name, decimal price)
        {
          
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }
            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be greater than zero.");
            }
            Id = id;
            Name = name;
            Price = price;
            Stock = 0;

        }
        public void ChangePrice(decimal newPrice)
        {
            if (newPrice <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newPrice), "Price must be greater than zero.");
            }
            Price = newPrice;
        }
        public void AddStock(int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be a positive integer.");
            }
            Stock += quantity;
        }
        public void Sell(int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be a positive integer.");
            } if(quantity > Stock)
            {
                throw new InvalidOperationException( "Not enough stock available.");
            }
            Stock -= quantity;
        }
        public string GetInfo()
        {
            return $"Product ID: {Id}, Name: {Name}, Price: {Price:C}, Stock: {Stock}, Total Value: {TotalValue:C}";
        }
    }
}
