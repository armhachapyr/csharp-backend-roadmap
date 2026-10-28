using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Lesson2
{
    internal class Order
    {
        private readonly DateTime _dateCreate;
        private readonly List<Product> _items = new List<Product>();
        public Order()
        {
            this._dateCreate = DateTime.UtcNow;
        }
        public IReadOnlyList<Product> Items
        {
            get
            {
                return _items.AsReadOnly();
            }
        }
        public DateTime CreatedAt
        {
            get
            {
                return _dateCreate;
            }
        }
      
        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in _items)
                {
                    total += item.Price;
                }
                return total;
            }
        }
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null");
            }
            if(product.IsInStock == false)
            {
                throw new InvalidOperationException("Product is out of stock");

            }
            _items.Add(product);
        }
    }
}
