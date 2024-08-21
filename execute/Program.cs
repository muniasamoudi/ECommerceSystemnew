using System;
using BussniseTier;
using DataTier.Entity;


namespace ECommerceSystem2presntation.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreatObj obj2 = new CreatObj();

            var customer1 = obj2.customer1;
            //     var paymentMethod = obj2.paymentMethod;
            var order = obj2.order;

            order.SaveOrderToFile("order.json");
            Order loadedOrder = Order.LoadOrderFromFile("order.json");

            double totalAmounts = customer1.ShoppingCart.totalQuantity();
            //  paymentMethod.PaymentProcess(totalAmounts);

            Console.WriteLine($"Customer : {customer1.GetPersonInfo()}");

            foreach (var item in order.productList)
                Console.WriteLine(item.GetProductInfo());

            double totalWithDiscount = order.applyDiscounts(totalAmounts, 0.5);

            Console.WriteLine($"Total Amount : {totalAmounts}");
            Console.WriteLine($"Total Amount after discount (5%) is : {totalWithDiscount}");

            Console.ReadLine();
        }
    }
}
