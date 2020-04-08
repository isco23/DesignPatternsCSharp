using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int count = 0;
        //private static readonly object obj = new object(); // for Lock to access via Multi Thread

        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        //private static readonly Singleton instance = new Singleton();
        public static Singleton GetInstance
        {
            get
            {
                #region To Prevent MultiThread
                // MultiThread Lock
                //if (instance == null)
                //{
                //    lock (obj)
                //    {
                //        if(instance == null)
                //        {
                //            instance = new Singleton();
                //        }                        
                //    }
                //}
                // End of MultiThread Lock
                #endregion
                return instance.Value;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine("Counter Value " + count.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
