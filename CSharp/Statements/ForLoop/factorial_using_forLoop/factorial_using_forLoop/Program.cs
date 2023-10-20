using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_using_forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fact = 1;
            int cnt = 1;
            int num = 1;
            Console.WriteLine("Enter Number to print Factorial: ");
            num=Convert.ToInt32(Console.ReadLine());

            for (cnt=1;cnt<=num; cnt++)
            {
                fact = fact * cnt;
            }
            Console.WriteLine(fact);
            Console.ReadKey();
        }
    }
}
