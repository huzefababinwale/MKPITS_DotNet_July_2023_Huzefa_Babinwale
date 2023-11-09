using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class_method
{

    internal class Program
    {
        static class Math
        {
            public static float pi = 3.14f;
            public static int cube (int n){ int f=n*n*n; return f; }
            public static void display() { Console.WriteLine("cube of number: " +f); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int c=Convert.ToInt32(Console.ReadKey());
            int r=Math.cube(c);
            Console.ReadKey();
        }
    }
}
