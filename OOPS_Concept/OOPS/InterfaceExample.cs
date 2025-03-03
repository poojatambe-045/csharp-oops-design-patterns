using OOPS_Concept.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    interface IDemoInterface1
    {
        void displayMessage1(); 
    }
    interface IDemoInterface2
    {
        void displayMessage2();
    }

    class DemoClass : IDemoInterface1, IDemoInterface2
    {
        public void displayMessage1()
        {
            Console.WriteLine("IDemoInterface1 - displayMessage1");
        }
        public void displayMessage2()
        {
            Console.WriteLine("IDemoInterface2 - displayMessage2");
        }
    }

    class InterfaceExample
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.displayMessage1();
            myObj.displayMessage2();
        }
    }
}

//output

//IDemoInterface1 - displayMessage1
//IDemoInterface2 - displayMessage2