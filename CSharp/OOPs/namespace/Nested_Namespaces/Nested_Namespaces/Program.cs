using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First;
using First.Second;

namespace First
{
    public class Hellow
    {
        public Hellow() { Console.WriteLine("Hellow from outer class and First Namespace"); }
    }
    namespace Second 
    {
        public class Welcome
        {
            public Welcome() { Console.WriteLine("These is from Second Namespace and it is inside the first one"); }
        }
    }
}

namespace Nested_Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First.Second.Welcome h2 = new Welcome();
            First.Hellow h1 = new Hellow();
            
            Console.ReadKey();
        }
    }
}
