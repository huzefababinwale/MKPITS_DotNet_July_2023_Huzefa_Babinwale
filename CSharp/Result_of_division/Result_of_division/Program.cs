using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_of_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, div;
            Console.WriteLine("Enter first Num : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Num: ");
            num2=Convert.ToInt32(Console.ReadLine());
            div = num1 / num2;
            Console.WriteLine("Division of number= " + div);
            Console.ReadKey();
        }
    }
}
