using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_numbers_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            while(i<=10)
            {
                Console.Write(i + "\t");
                i++;
            }


            i = 1;
            int res = 0;
            while (i<=10)
            {
                res= i + res;
                i++;
            }
            Console.WriteLine("Result of Sum = "+res);

            
            Console.ReadKey();
        }
    }
}
