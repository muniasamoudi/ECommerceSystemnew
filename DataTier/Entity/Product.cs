using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniseTier
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(int productId, string name, double price, int quantity)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
        }

        public string GetProductInfo()
        {
            return $"Product ID:{ProductId} , Name : {Name},Price:{Price} Quantity: {Quantity}";

        }
    }
}
