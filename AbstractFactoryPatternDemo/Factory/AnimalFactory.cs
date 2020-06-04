﻿using AbstractFactoryPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo.Factory
{
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string AnimalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else
            {
                return new LandAnimalFactory();
            }
        }
    }
}
