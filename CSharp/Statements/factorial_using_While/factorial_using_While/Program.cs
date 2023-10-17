using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_using_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0, fact=1;

            Console.WriteLine("Enter Number : ");
            num= Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                fact = fact* num;
                num--;
            }
            Console.WriteLine("{0} ", fact);
            Console.ReadKey();
        }
    }
}
