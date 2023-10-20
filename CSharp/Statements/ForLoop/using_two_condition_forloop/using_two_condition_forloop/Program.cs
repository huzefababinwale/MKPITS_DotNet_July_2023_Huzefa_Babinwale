using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_two_condition_forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int outer=0; int inner=0;

            for(outer=1,inner=1; inner<=10 && outer<=10; outer++) 
            {
                
                    Console.Write("   "+inner+"*");
                    Console.Write(outer);
                    Console.WriteLine(" ="+inner * outer);
                    if (outer == 10)
                {
                    inner++;
                    outer = 1;
                }
                
            }
            Console.ReadKey();
        }
    }
}
