using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_10numbers_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=0,num2=0, num3 = 0,num4 = 0,num5 = 0,num6 = 0,num7 = 0,num8 = 0,num9 = 0,num10 = 0;
            float sum=0, div=10;
            float avg=0;

            Console.WriteLine("Enter Number: ");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num7 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num9 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num10 = Convert.ToInt32(Console.ReadLine());

            sum = num1+num2+num3+num4+num5+num6+num7+num8+num9+num10;
            Console.WriteLine("The Sum of Numbers is "+sum);
            avg = sum / div;

            while (avg<sum)
            {
                Console.WriteLine(avg);
                avg=avg+120000;
            }
            Console.ReadKey();
        }
    }
}
