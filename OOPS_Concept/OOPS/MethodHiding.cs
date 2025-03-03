using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    class BaseClass2
    {
        public BaseClass2()
        {
           // Console.WriteLine("Base class constructor.");
        }
        public virtual void Method()
        {
            Console.WriteLine("Base class method.");
        }
    }

    class DerivedClass2 : BaseClass2
    {
        public DerivedClass2()
        {
           // Console.WriteLine("Derived class constructor.");
        }
       
        public new void Method()
        {
            Console.WriteLine("Derived class method.");
        }
    }

    class MethodHiding
    {
        static void Main()
        {
            BaseClass2 b = new BaseClass2();
            b.Method();

            DerivedClass2 d = new DerivedClass2();
            d.Method();

            BaseClass2 d1 = new DerivedClass2();
            d1.Method();

        }
    }

}

//output
//Base class method.
//Derived class method.
//Base class method.
