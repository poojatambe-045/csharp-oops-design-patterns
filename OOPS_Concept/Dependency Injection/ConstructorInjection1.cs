using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.Dependency_Injection
{
    public interface text
    {
        void print();
    }
    class format : text
    {
        public void print()
        {
            Console.WriteLine("sample text");
        }
    }
    // constructor injection
    public class ConstructorInjectionClass
    {
        private text _text;
        public ConstructorInjectionClass(text t1)
        {
            this._text = t1;
        }
        public void print()
        {
            _text.print();
        }
    }
    class ConstructorInjection1
    {
        static void Main(string[] args)
        {
            ConstructorInjectionClass cs = new ConstructorInjectionClass(new format());
            cs.print();
            Console.ReadKey();
        }
    }
}
