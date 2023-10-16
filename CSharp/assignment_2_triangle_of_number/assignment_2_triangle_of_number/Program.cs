using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_triangle_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a, b;
            Console.WriteLine("Enter num to print: ");
            a=Convert.ToInt16(Console.ReadLine());  

            Console.WriteLine("Enter Times to print Triangle: ");
            b=Convert.ToInt16(Console.ReadLine());

            short j,i;
            for(i=b; i>=1; i--)
            {
                for (j=i; j>=1; j--)
                {
                    Console.Write(a);
                    //Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();

        }
    }
}
