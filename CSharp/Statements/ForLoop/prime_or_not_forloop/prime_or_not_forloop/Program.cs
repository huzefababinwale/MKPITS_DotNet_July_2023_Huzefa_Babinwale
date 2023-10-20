using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_or_not_forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Enter Number to check whether it is prime or not : ");
            num=Convert.ToInt32(Console.ReadLine());
            /*for (cnt=1; cnt<=num)*/
            if(num %2== 0)
            {
                Console.WriteLine("It is not a prime no.");

            }
            else
            {
                Console.WriteLine("It is prime number ");
            }
            Console.ReadKey();
        }
    }
}
