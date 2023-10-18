using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_no_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            int i = 2;
            int flag = 0;
            /*Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());*/

            while (num <= 20)
            {
                flag = 0;
                i = 2;
                while (i < num)
                {
                    if (num % 2 == 0)
                    {
                        flag = 1;

                        break;
                    }
                    i++;
                }
                if (flag == 0)
                {
                    Console.WriteLine("prime no : {0}", num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
