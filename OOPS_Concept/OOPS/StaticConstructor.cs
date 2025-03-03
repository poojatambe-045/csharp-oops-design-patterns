using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    class StaticConstructor
    {
        int i;
        static int j;
        //Default Constructor
        public StaticConstructor()
        {
            Console.WriteLine("Default Constructor Executed");
            i = 100;
        }
        //static Constructor
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Executed");
            j = 100;
        }
        public void Increment()
        {
            i++;
            j++;
        }
        public void Display()
        {
            Console.WriteLine("Value of i : " + i);
            Console.WriteLine("Value of j : " + j);
        }

        static void Main(string[] args)
        {
            StaticConstructor e1 = new StaticConstructor();
            e1.Increment();
            e1.Display();
            e1.Increment();
            e1.Display();
            StaticConstructor e2 = new StaticConstructor();
            e2.Increment();
            e2.Display();
            e2.Increment();
            e2.Display();
            Console.ReadKey();
        }
    }
}



//Static Constructor Executed
//Default Constructor Executed
//Value of i : 101
//Value of j : 101
//Value of i : 102
//Value of j : 102
//Default Constructor Executed
//Value of i : 101
//Value of j : 103
//Value of i : 102
//Value of j : 104