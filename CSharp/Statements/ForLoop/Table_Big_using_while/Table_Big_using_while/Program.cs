using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Big_using_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("enter limit");
            flag = Convert.ToInt32(Console.ReadLine()); //3
            int counter = 1;
            int counter1 = 1;

            while (counter <= 10)
            {
                counter1 = 1;
                while (counter1 <= flag)
                {

                    Console.Write("{0}*{1}={2}", counter, counter1, (counter1 * counter));
                    Console.Write("\t");

                    counter1++;


                }
                counter++;
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
