using FactoryMethodPatternDemo.Classes;
using FactoryMethodPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternDemo.Factory
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard creditCard = new MoneyBack();
            return creditCard;
        }
    }
}
