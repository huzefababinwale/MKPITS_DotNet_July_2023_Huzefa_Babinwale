using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sqr;
            Console.WriteLine("Enter Value to get Square : ");
            num=Convert.ToInt32(Console.ReadLine());
            sqr = num * num;
            Console.WriteLine("square = " + sqr);
            Console.ReadKey();
        }
    }
}
