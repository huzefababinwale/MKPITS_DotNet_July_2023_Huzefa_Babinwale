using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Table_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            int j = 1;
            int num;
            Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());

           
                while(i<=num)
                {
                j = 1;
                while(j<=10)
                {
                    Console.Write("{0}*{1}={2}", i,j, (j * i));
                    Console.Write("\t");
                    j++;
                }
                    
                    i++;
                Console.WriteLine();
                }
            
            Console.ReadKey();
        }
    }
}
