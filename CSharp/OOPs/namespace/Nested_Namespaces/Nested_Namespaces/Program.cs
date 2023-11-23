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
            //as we can see by creating object we can call the classes and functionalities(methods) using '.' indicator
            
            First.Hellow h1 = new Hellow();
            First.Second.Welcome h2 = new Welcome();
            Console.ReadKey(); 
        }
    }
}
