using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
namespace BussniseTier
{
    public abstract class PaymentMethod
    {
        public abstract void PaymentProcess(double Productsamount);
    }
    public class PayPalPayment : PaymentMethod
    {
        public double Balance1 { get; set; } = 2500.0;

        public override void PaymentProcess(double Productsamount)
        {
            if (Balance1 >= Productsamount)
            {
                Balance1 -= Productsamount;
                Console.WriteLine($"PayPal payment : {Productsamount} $");
            }
            else
            {
                Console.WriteLine($"don't have enough money credit card payment is : {Productsamount} the Balance is {Balance1} $");
            }
        }
    }
    public class CreditCardPayment : PaymentMethod //, IPayment
    {

        //IPayment interface
        public void Payment()
        {
            throw new NotImplementedException();
        }
        public double Balance2 { get; set; } = 200.0;
        public override void PaymentProcess(double Productsamount)
        {
            if (Balance2 >= Productsamount)
            {
                Balance2 -= Productsamount;
                Console.WriteLine($"credit card payment : {Productsamount} $");
            }
            else
            {
                Console.WriteLine($"don't have enough money credit card payment is : {Productsamount} the Balance is {Balance2} $");
            }

        }
    }
}
