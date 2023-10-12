using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_multiplication_of_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, res;
            Console.WriteLine("Enter Num 1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Enter Num 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            res = num1 * num2 * num3;
            Console.WriteLine("Result: " + res);
            Console.ReadKey();
        }
    }
}
