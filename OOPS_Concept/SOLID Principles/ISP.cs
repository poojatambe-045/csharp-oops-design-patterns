using OOPS_Concept.SOLID_Principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.SOLID_Principles
{
    //Clients should not be forced to depend on interfaces they do not use.
    public interface IPermantEmployee
    {
        void CalculateNewSalary(int salary);
        void Bonus(int amount);
    }
    public interface IContractualEmployee
    {
        void CalculateNewSalary(int salary);
    }

    public class PermenantEmp : IPermantEmployee
    {
        public void CalculateNewSalary(int salary)
        {
            Console.WriteLine("Salary of Permant Employee :" + (salary + 500));
        }
        public void Bonus(int amount)
        {
            Console.WriteLine("Permant Employee Bonus: " + amount);
        }
    }
    public class ContractualEmp : IContractualEmployee
    {
        public void CalculateNewSalary(int salary)
        {
            Console.WriteLine("Salary of Contractual Employee :" + salary);
        }
    }

    public class ISP
    {
        static void Main(string[] args)
        {
            PermenantEmp e = new PermenantEmp();
            e.CalculateNewSalary(200);
            e.Bonus(100);

            ContractualEmp e2 = new ContractualEmp();
            e2.CalculateNewSalary(100);

            Console.WriteLine("");

            IPermantEmployee emp = new PermenantEmp();
            emp.CalculateNewSalary(300);
            emp.Bonus(100);

            IContractualEmployee emp2 = new ContractualEmp();
            emp2.CalculateNewSalary(400);
        }
    }
}



//Salary of Permant Employee :700
//Permant Employee Bonus: 100
//Salary of Contractual Employee :100

//Salary of Permant Employee :800
//Permant Employee Bonus: 100
//Salary of Contractual Employee :400