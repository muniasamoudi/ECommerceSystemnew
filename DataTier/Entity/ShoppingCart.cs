using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniseTier
{
    public class ShoppingCart
    {

        public List<Product> Products = new List<Product>();
        public ShoppingCart()
        {
            Products = new List<Product>();

        }
        public void addProduct(Product product)
        {
            Products.Add(product);

        }
        public void removeProduct(Product product)
        {
            Products.Remove(product);
        }
        public double totalQuantity()
        {
            double totalPrice = 0;
            foreach (Product product in Products)
            {
                totalPrice += product.Price * (int)(product.Quantity);
            }
            return totalPrice;

        }



    }
}
