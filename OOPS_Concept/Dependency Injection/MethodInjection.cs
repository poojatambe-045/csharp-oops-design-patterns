using OOPS_Concept.Dependency_Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.Dependency_Injection
{
    public interface IMethodInjectionService
    {
        void Serve();
    }

    public class MethodInjectionService1 : IMethodInjectionService
    {
        public void Serve()
        {
            Console.WriteLine("Service1 Called");
        }
    }

    public class MethodInjectionService2 : IMethodInjectionService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 Called");
        }
    }

    public class MethodInjectionClient
    {
        public void ServeMethod(IMethodInjectionService service)
        {
            service.Serve();
        }
    }

    class MethodInjection
    {
        static void Main(string[] args)
        {
            MethodInjectionClient client = new MethodInjectionClient();

            // Creating object
            MethodInjectionService1 s1 = new MethodInjectionService1();
            MethodInjectionService2 s2 = new MethodInjectionService2();

            // Passing dependency
            client.ServeMethod(s1); // Calls Service1.Serve(), outputs: "Service1 Called"

            client.ServeMethod(s2); // Calls Service2.Serve(), outputs: "Service2 Called"
        }
    }
}


//Service1 Called
//Service2 Called