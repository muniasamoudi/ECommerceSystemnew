using BussniseTier;
using DataTier.interFaces;
using System.Text.Json;

namespace DataTier.Entity
{
    public class Order : IDiscountable
    {
        public Customer Customer { get; set; }
        public List<Product> productList { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public enum orderStatus { Pending, Processing, Shipped, Delivered }
        public orderStatus Orderstatus { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
            OrderDate = DateTime.Now;
            Orderstatus = orderStatus.Pending;
            productList = new List<Product>(customer.ShoppingCart.Products);
        }

        public void CreatOrder(PaymentMethod paymentMethod)
        {
            Orderstatus = orderStatus.Shipped;
            double Productsamount = Customer.ShoppingCart.totalQuantity();
            paymentMethod.PaymentProcess(Productsamount);
        }

        public double applyDiscounts(double Productsamount, double discount)
        {
            return Productsamount * discount;
        }

        void IDiscountable.applyDiscounts(double Productsamount, double discount)
        {
            throw new NotImplementedException();
        }

        public void SaveOrderToFile(string filePath)
        {
            var jsonData = JsonSerializer.Serialize(this);
            File.WriteAllText(filePath, jsonData);
        }

        public static Order LoadOrderFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Order>(jsonData);
            }
            throw new FileNotFoundException("Order file not found.");
        }
    }
}
