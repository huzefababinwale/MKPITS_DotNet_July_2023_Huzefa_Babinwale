using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_method
{
    class Company
    {
        string name = "MKCL";
        public void display()
        {
            Console.WriteLine(  "Name of company is in base class "+ name);
        }
    }
    class Sisterbranch : Company
    {
        string name = "MKPITS";
        public void display()
        {
            base.display();
            Console.WriteLine("Here we got Company from Sister Branch " + name);
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sisterbranch sis=new Sisterbranch();
            sis.display();
            Console.ReadKey();
        }
    }
}
