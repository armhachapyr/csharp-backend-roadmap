using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2Repeat
{
    internal class Order
    {
        private readonly List<Product> _items = new List<Product>();
        private readonly DateTime dateTime;

        public IReadOnlyList<Product> Items
        {
            get
            {
                return _items.AsReadOnly();
            }
        }
       

        public Order()
        {
            dateTime = DateTime.UtcNow;
        }
        public DateTime CreatedAt
        {
            get { return dateTime; }
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
                throw new ArgumentNullException(nameof(product));
            }
            if (!product.IsInStock)

            {
                throw new InvalidOperationException(nameof(product));
            }
            _items.Add(product);
        }
        


    }
}
