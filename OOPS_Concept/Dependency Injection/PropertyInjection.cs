using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.Dependency_Injection
{
    public interface IPropertyService
    {
        void Serve();
    }

    public class PropertyService1 : IPropertyService
    {
        public void Serve()
        {
            Console.WriteLine("Service1 Called");
        }
    }

    public class PropertyService2 : IPropertyService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 Called");
        }
    }

    public class PropertyClient
    {
        private IPropertyService _service;

        public IPropertyService Service
        {
            set { this._service = value; }
        }

        public void ServeMethod()
        {
            this._service.Serve();
        }
    }

    class PropertInjection
    {
        static void Main(string[] args)
        {
            PropertyClient client = new PropertyClient();

            // Creating object
            PropertyService1 s1 = new PropertyService1();
            PropertyService2 s2 = new PropertyService2();

            client.Service = s1; // Passing dependency
            client.ServeMethod();

            client.Service = s2; // Passing dependency
            client.ServeMethod();
        }
    }
}


//Service1 Called
//Service2 Called