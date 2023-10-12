using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_print_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter Your Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello! ");
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
