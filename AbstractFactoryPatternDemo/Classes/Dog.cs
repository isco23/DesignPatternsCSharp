using AbstractFactoryPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo.Classes
{
    public class Dog : Animal
    {
        public string speak()
        {
            return "Bark bark";
        }
    }
}
