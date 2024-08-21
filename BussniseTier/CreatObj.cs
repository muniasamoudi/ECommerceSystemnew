using DataTier.Entity;

namespace BussniseTier
{
    public class CreatObj
    {
        public Customer customer1 { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        public Order order { get; set; }

        public CreatObj()
        {
            customer1 = new Customer(1, "Munia", "Jenin");
            paymentMethod = new CreditCardPayment();

            var product1 = new Product(1, "T-Shirt", 150.0, 2);
            var product2 = new Product(2, "Jeans", 100.0, 1);
            var product3 = new Product(3, "Shoes", 200.0, 2);

            customer1.ShoppingCart.addProduct(product1);
            customer1.ShoppingCart.addProduct(product2);
            customer1.ShoppingCart.addProduct(product3);

            order = customer1.PlaceOrder(paymentMethod);
        }
    }
}
