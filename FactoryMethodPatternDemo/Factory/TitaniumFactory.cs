using FactoryMethodPatternDemo.Classes;
using FactoryMethodPatternDemo.Interfaces;

namespace FactoryMethodPatternDemo.Factory
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard creditCard = new Titanium();
            return creditCard;
        }
    }
}
