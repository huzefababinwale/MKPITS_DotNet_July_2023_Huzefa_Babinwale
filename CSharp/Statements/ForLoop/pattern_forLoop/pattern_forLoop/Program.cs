using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int outer=0; int inner=0;
            int num = 5;
            for(outer=1;outer<=num; outer++)
            {
                for(inner=1;inner<=outer; inner++)
                {
                    Console.Write("\t"+inner);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
