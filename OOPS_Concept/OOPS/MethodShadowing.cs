using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    class BaseClass
    {
        public BaseClass()
        {
            //Console.WriteLine("Base class constructor.");
        }
        public void Method()
        {
            Console.WriteLine("Base class method.");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
           // Console.WriteLine("Derived class constructor.");
        }
        public void Method()
        {
            Console.WriteLine("Derived class method.");
        }
    }

    class MethodShadowing
    {
        static void Main()
        {
            BaseClass b = new BaseClass();
            b.Method();

            DerivedClass d = new DerivedClass();
            d.Method();

            BaseClass d1 = new DerivedClass();
            d1.Method();

        }
    }

}


//output
//Base class method.
//Derived class method.
//Base class method.