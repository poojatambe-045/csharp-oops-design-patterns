using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Properties
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Pooja";
            Console.WriteLine(myObj.Name);
        }
    }
}


//Pooja