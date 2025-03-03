using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    abstract class AbstarctBaseClass
    {
        public abstract void getName(string name);
        public void displayMessage()
        {
            Console.WriteLine("Non abtract method");
        }
    }

    class AbstarctDerivedClass : AbstarctBaseClass
    {
        public override void getName(string name)
        {
            Console.WriteLine(name);
        }
    }

    class AbstractClass
    {
        static void Main(string[] args)
        {
            AbstarctDerivedClass myObj = new AbstarctDerivedClass();
            myObj.getName("Abstract method");
            myObj.displayMessage(); 
        }
    }
}



//Abstract method
//Non abtract method