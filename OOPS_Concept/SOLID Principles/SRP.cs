using OOPS_Concept.SOLID_Principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.SOLID_Principles
{
    //A class should have only one reason to change, meaning that it should have only one responsibility or purpose.
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class EmployeeService
    {
        public void RegisterUser(Employee emp)
        {
            SaveUSer(emp);

            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Welcome ", emp.Email);
        }
        public void SaveUSer(Employee emp)
        {
            Console.WriteLine($"Employee Registered");
        }
    }
    public class EmailSender
    {
        public void SendEmail(string message, string recipient)
        {
            // Email sending logic
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }

    public class SRP
    {
        public static void Main(string[] args)
        {
            EmployeeService empService = new EmployeeService();
            empService.RegisterUser(new Employee() { Name = "Pooja", Email = "pooja@gmail.com" });
        }
    }
}


//Employee Registered
//Sending email to pooja@gmail.com: Welcome