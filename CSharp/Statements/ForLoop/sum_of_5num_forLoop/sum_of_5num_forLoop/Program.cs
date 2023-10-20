using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_5num_forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int cnt = 0;
            int sum= 0; 
            for (cnt = 1; cnt <= 5; cnt++)
            {
                Console.WriteLine("Enter number: ");
                num = Convert.ToInt32(Console.ReadLine());
                sum = num + sum;
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();


        }
    }
}
