using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_number_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter number to get Even Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            int counter=1;

            while ( counter<=num)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter +" is even");
                }
                counter++;
            }
            Console.ReadKey();

        }
    }
}
