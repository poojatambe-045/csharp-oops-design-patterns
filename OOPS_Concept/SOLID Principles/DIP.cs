using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.SOLID_Principles
{

    //High-level modules should not depend on low-level modules.Both should depend on abstractions.
    public interface IEmployee  //Low level class
    {
        void CalculateNewSalary(int salary);
    }

    public class Employee4 : IEmployee
    {
        public void CalculateNewSalary(int salary)
        {
            Console.WriteLine("Salary of Permanant Employee :" + (salary + 500));
        }
    }

    //High leve; class
    public class DIP
    {
        private IEmployee emp;

        public DIP(IEmployee emp)
        {
            this.emp = emp;
        }
        public void CalculateSalary(int salary)
        {
            emp.CalculateNewSalary(salary);
        }
        static void Main(string[] args)
        {
            var empObj = new Employee4(); 

            var dip = new DIP(empObj);

            dip.CalculateSalary(100);
        }
    }
}



//Salary of Permanant Employee :600