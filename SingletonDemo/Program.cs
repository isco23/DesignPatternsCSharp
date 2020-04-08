using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintDetails1(),
                () => PrintDetails2()
                );
            Console.ReadLine();
        }

        private static void PrintDetails2()
        {
            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("This is second message from S2");
        }

        private static void PrintDetails1()
        {
            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("This is first message from S1");
        }
    }
}
