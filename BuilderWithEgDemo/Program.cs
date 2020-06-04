using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithEgDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();

            TeaBuilder tea = new TeaBuilder();
            beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());
            CoffeeBuilder coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            Console.WriteLine(beverage.ShowBeverage());
            Console.ReadKey();
        }
    }
}
