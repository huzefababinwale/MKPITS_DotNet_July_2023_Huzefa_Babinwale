using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_integer_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num=0;
            Console.WriteLine("Enter number: ");
            num=Convert.ToInt32(Console.ReadLine());

            while (num >= 0)
            {
                Console.WriteLine("Number is " + num + " Cube is " + (num * num * num));
                num--;
            }
            Console.ReadKey();
        }
    }
}
