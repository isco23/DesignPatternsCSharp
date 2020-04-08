using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo.Composite
{
    public class Manager : IEmployee
    {
        public List<IEmployee> SubOrdinates;
        public string Name { get; set; }
        public string Department { get; set; }
        public Manager(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
            SubOrdinates = new List<IEmployee>();
        }
        public void GetDetials(int indentation)
        {
            Console.WriteLine(string.Format("{0} + Name: {1} ," + " Dept: {2} - Manager(Composite) ",new String('-',indentation),this.Name, this.Department));
            foreach (var employee in SubOrdinates)
            {
                employee.GetDetials(indentation + 1);
            }
        }
    }
}
