using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lesson2
{
    internal class Product
    {
        public string Name { get;}
        public int Id { get;}
        public int Stock { get; private set; }
        public decimal Price { get; private set; }

        public bool IsInStock
        {
            get
            {
                return this.Stock > 0;
            }
        }
        public decimal TotalPrice
        {
            get
            {
                return Price * Stock;
            }
        }
        public Product(string name, int id, decimal price)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace", nameof(name));
            }
            if(price < 0)
            {
                throw new ArgumentException("Price cannot be negative", nameof(price));
            }
            this.Name = name;
            this.Id = id;
            this.Price = price;
        }
        public void ChangePrice(decimal newPrice)
        {
            if (newPrice <= 0)
            {
                throw new ArgumentException("Price cannot be zero or negative");
            }
            this.Price = newPrice;
        }
        public void AddStock(int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero");
            }
            Stock += quantity;
        }
        public void Sell(int quanity)
        {
           if(quanity<=0)
           {
                throw new ArgumentException("Quanity must be greater than zero");
           }
           if(quanity>Stock)
           {
                throw new InvalidOperationException("Not enough stock to sell");
           }
           Stock -= quanity;
        }
        public string GetInfo()
        {
            return $"Product Name: {Name}, ID: {Id}, Stock: {Stock}, Price: {Price:C}";
        }
    }
}
