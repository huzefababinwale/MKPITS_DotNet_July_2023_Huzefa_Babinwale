using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            int num;
            Console.WriteLine("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());


                do
                {
                    j = 1;
                    do
                    {
                        Console.Write("{0}*{1}={2}", i, j, (j * i));
                        Console.Write("\t");
                        j++;
                    }
                    while (j <= 10) ;

                    i++;
                    Console.WriteLine();
                }
                while (i <= num) ;

                Console.ReadKey();
            }
        }
    }


