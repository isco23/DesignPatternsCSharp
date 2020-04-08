using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment order = new CardPayment();
            order._IPaymentSystem = new AyaPaymentSystem();
            order.MakePayment();
            Console.ReadKey();
        }
    }
}
