using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_sum_two_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, add;
            Console.WriteLine("Enter Number one: ");
            num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("ENter Number two: ");
            num2= Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("Addition = " + add);
            Console.ReadKey();
        }
    }
}
