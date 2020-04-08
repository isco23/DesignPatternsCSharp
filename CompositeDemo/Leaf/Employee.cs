using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(string name , string dept)
        {
            this.Name = name;
            this.Department = dept;
        }
        public void GetDetials(int indentation)
        {
            Console.WriteLine(string.Format("{0}- Name: {1}  , Dept: {2} (Leaf) ",new String('-',indentation), this.Name, this.Department ));
        }
    }
}
