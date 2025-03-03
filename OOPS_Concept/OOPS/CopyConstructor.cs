using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    class CopyConstructor
    {
        public int Id;
        public string Name;
        public CopyConstructor(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public CopyConstructor(CopyConstructor emp)
        {
            Id = emp.Id;
            Name = emp.Name;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + Id);
            Console.WriteLine("Employee Name is:  " + Name);
        }

        static public void Main()
        {
            CopyConstructor c1 = new CopyConstructor(1, "Pooja");
            CopyConstructor c2 = new CopyConstructor(c1);

            c2.Display();
            Console.ReadLine();
        }

    }
}

