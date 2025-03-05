using OOPS_Concept.Dependency_Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.Dependency_Injection
{

    public interface IService
    {
        void Serve();
    }
    public class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service1 Called");
        }
    }
    public class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 Called");
        }
    }
    public class Client
    {
        private IService _service;
        public Client(IService service)
        {
            this._service = service;
        }
        public void ServeMethod()
        {
            this._service.Serve();
        }
    }
    class ContructorInjection
    {
        static void Main(string[] args)
        {
            //creating object
            Service1 s1 = new Service1();
            Service2 s2 = new Service2();

            //passing dependency
            Client c1 = new Client(s1);
            c1.ServeMethod();
         
            c1 = new Client(s2);
            c1.ServeMethod();
        }
    }

}

//Service1 Called
//Service2 Called