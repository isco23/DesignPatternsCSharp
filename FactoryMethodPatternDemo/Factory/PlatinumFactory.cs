using FactoryMethodPatternDemo.Classes;
using FactoryMethodPatternDemo.Interfaces;

namespace FactoryMethodPatternDemo.Factory
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard creditCard = new Platinum();
            return creditCard;
        }
    }
}
