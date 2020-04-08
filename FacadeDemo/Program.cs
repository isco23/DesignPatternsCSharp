
using FacadeDemo.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
            Console.ReadLine();
        }
    }
}
