using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.SOLID_Principles
{
    //Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program.
    public abstract class Employee3
    {
        public abstract void CalculateNewSalary(int salary);
    }

    public class Permanant3 : Employee3
    {
        public override void CalculateNewSalary(int salary)
        {
            Console.WriteLine("Salary of Permanant Employee :" + (salary + 500));
        }
        public void Bonus(int amount)
        {
            Console.WriteLine("Bonus: " + amount);
        }
    }
    public class Contractual3 : Employee3    //if we inherit Permanant3 class here then we will violate LSP
    {
        public override void CalculateNewSalary(int salary)
        {
            Console.WriteLine("Salary of Contractual Employee :" + salary);
        }
    }

    public class LSP
    {
        static void Main(string[] args)
        {
            Employee3 emp = new Permanant3();
            emp.CalculateNewSalary(300);

            Employee3 emp2 = new Contractual3();
            emp2.CalculateNewSalary(400);
        }
    }
}


//Salary of Permanant Employee :800
//Salary of Contractual Employee :400