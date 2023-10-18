using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_of_number_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Enter Number for table: ");
            int tb=Convert.ToInt32(Console.ReadLine());

            while(num<=10)
            {

                Console.WriteLine("{0}*{1}= "+ num * tb,num,tb);
                num++;

            }
            Console.ReadKey();
        }
    }
}
