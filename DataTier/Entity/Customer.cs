using BussniseTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataTier.Entity
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Customer(int customerID, string Name, string City) : base(Name, City)
        {
            CustomerID = customerID;
            ShoppingCart = new ShoppingCart();
        }
        public Order PlaceOrder(PaymentMethod paymentMethod)
        {
            Order order = new Order(this); // customer 
            order.CreatOrder(paymentMethod);
            return order;


        }
    }
}
/* 
namespace DataTier.Entity
{
    public class Customer : Person
      {
          public int CustomerID { get; set; }
          public ShoppingCart ShoppingCart { get; set; }

          public Customer(int customerID, string Name, string City) : base(Name, City)
          {
              CustomerID = customerID;
              ShoppingCart = new ShoppingCart();
          }

          public override string GetPersonInfo()
          {
              return base.GetPersonInfo() + ($"  CustomerID : {CustomerID}");
          }
          internal sealed class PremiumCustomer : Customer
          {
              public PremiumCustomer(int customid, string name, string city) : base(customid, name, city) { }
          }

          /*    ////////// بعتمد على الpaymentMethod?
              public Order PlaceOrder(PaymentMethod paymentMethod)
              {
                  Order order = new Order(this); // customer 
                  order.CreatOrder(paymentMethod);
                  return order;


        }  }  } */







