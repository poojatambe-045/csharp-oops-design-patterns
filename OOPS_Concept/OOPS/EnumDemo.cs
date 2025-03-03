using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    class EnumDemo
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

            int myNum = (int)Level.Medium;
            Console.WriteLine(myNum);
        }
    }
}

//oput

//Medium
//1