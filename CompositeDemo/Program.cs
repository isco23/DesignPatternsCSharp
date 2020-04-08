using CompositeDemo.Composite;
using CompositeDemo.Leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee John = new Employee("John", "IT");
            IEmployee Mike = new Employee("Mike", "IT");
            IEmployee Jason = new Employee("Jason", "HR");
            IEmployee Henry = new Employee("Henry", "HR");
            IEmployee Eric = new Employee("Eric", "HR");
            IEmployee James = new Manager("James", "IT")
            {
                SubOrdinates = { John, Mike }
            };

            IEmployee Philip = new Manager("Philip", "HR")
            {
                SubOrdinates = { Jason, Henry , Eric}
            };

            IEmployee Bob = new Manager("Bob", "Head")
            {
                SubOrdinates = { James, Philip }
            };

            Bob.GetDetials(1);           
            Console.ReadLine();
        }
    }
}
