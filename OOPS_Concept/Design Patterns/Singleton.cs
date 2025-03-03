using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.Design_Patterns
{
    public sealed class SingletonDemo
    {
        private static int Counter = 0;
        private static SingletonDemo Instance = null;
        public static SingletonDemo GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonDemo();
            }
            return Instance;
        }
        private SingletonDemo()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
    class Signleton
    {
        static void Main(string[] args)
        {
            SingletonDemo obj1 = SingletonDemo.GetInstance();
            obj1.PrintDetails("first instance");

            SingletonDemo obj2 = SingletonDemo.GetInstance();
            obj2.PrintDetails("second instance");
            Console.ReadLine();
        }
    }
}


//Counter Value 1
//first instance
//second instance