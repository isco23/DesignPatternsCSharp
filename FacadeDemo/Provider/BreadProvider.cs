using FacadeDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo.Provider
{
    public class BreadProvider : IBread
    {
        public void GetCheesyGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }

        public void GetGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
        }

        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
        }
    }
}
