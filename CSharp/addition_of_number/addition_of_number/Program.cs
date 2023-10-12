using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, addition;
            Console.WriteLine("Enter num 1: ");
            num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            addition = num1 + num2;
            Console.WriteLine("addition of two numbers is = " + addition);
            Console.ReadKey();

        }
    }
}
