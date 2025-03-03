using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    class BaseClass1
    {
        public BaseClass1()
        {
            //Console.WriteLine("Base class constructor.");
        }
        public virtual void Method()
        {
            Console.WriteLine("Base class method.");
        }
    }

    class DerivedClass1 : BaseClass1
    {
        public DerivedClass1()
        {
            //Console.WriteLine("Derived class constructor.");
        }
        public override void Method()
        {
            Console.WriteLine("Derived class method.");
        }
    }

    class MethodOverriding
    {
        static void Main()
        {
            BaseClass1 b = new BaseClass1();
            b.Method();

            DerivedClass1 d = new DerivedClass1();
            d.Method();

            BaseClass1 d1 = new DerivedClass1();
            d1.Method();

        }
    }

}


//output
//Base class method.
//Derived class method.
//Derived class method.