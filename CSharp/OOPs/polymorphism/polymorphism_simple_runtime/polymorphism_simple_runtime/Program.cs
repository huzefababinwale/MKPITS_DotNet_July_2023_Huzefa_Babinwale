using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_simple_runtime
{
    class baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("Hello from Base Class");
        }
    }
    class childclass : baseclass 
    {
        public override void show()
        {
            Console.WriteLine("Overrided_Succesfully --Hello from Child class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            childclass ch= new childclass();
            baseclass bs=new baseclass();

            bs.show();
            ch.show();
            Console.ReadKey();
        }
    }
}
