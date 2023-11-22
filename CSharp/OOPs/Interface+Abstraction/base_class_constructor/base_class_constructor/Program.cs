using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_constructor
{
    class Company
    {
        public string name = "MKCL";
        public Company()
        {
            Console.WriteLine("these is from base class");
            Console.WriteLine("");
        }
    }
    class Frenchise: Company
    {
        public string name = "MKPITS";
        public Frenchise()
        {
            Console.WriteLine("These is from Dog Class");
            Console.WriteLine("These is from Dog Class  "+ base.name);
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Frenchise frenchise = new Frenchise();
            /*frenchise.frenchise();*/
            Console.ReadKey();

        }
    }
}
