using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_n_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int num=0, res=0;
            Console.WriteLine("Enter Number: ");
            num =Convert.ToInt32( Console.ReadLine());
            while (i <= num)
            {
                Console.WriteLine(i);
                res = i + res;
                i++;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
