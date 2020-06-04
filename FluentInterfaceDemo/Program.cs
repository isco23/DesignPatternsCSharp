using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();
            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");

            Console.Read();
        }
    }
}
