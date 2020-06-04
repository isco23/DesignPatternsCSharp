using FactoryPatternDemo.Classes;
using FactoryPatternDemo.Factory;
using FactoryPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Money Back");
            
            if(cardDetails != null)
            {
                Console.WriteLine("Card Type: " + cardDetails.GetCardType());
                Console.WriteLine("Credit Limit " + cardDetails.GetCreditLimit());
                Console.WriteLine("Annual Charge: " + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
