using OOPS_Concept.SOLID_Principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.SOLID_Principles
{
    //Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
    public abstract class Employee1
    {
        public abstract void CalculateNewSalary(int salary);
    }

    public class Permanant : Employee1
    {
        public override void CalculateNewSalary(int salary)
        {
            Console.WriteLine("Salary of Permanant Employee :" + (salary + 500));
        }
        public void Bonus(int amount)
        {
            Console.WriteLine("Permanant Employee Bonus: " + amount);
        }
    }
    public class Contractual : Employee1
    {
        public override void CalculateNewSalary(int salary)
        {
            Console.WriteLine("Salary of Contractual Employee :" + salary);
        }
    }

    public class OCP
    {
        static void Main(string[] args)
        {
            Permanant emp = new Permanant();
            emp.CalculateNewSalary(300);
            emp.Bonus(100);

            Contractual emp2 = new Contractual();
            emp2.CalculateNewSalary(400);
        }
    }
}



//Salary of Permanant Employee :800
//Permanant Employee Bonus: 100
//Salary of Contractual Employee :400