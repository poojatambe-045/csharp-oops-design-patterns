using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    internal class MethodOverloading
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static double Sum(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myNum1 = Sum(8, 5);
            double myNum2 = Sum(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}

//Int: 13
//Double: 10.559999999999999
