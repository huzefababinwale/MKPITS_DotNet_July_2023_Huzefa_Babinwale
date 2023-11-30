using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, num, res;
            Console.WriteLine("Enter Number: ");
            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            num=Convert.ToInt32(Console.ReadLine());

            try
            {
                res = n / num;
            }
            catch
            {
                Console.WriteLine( "Can not divided by zero or negative numbers");
            }
            finally
            {
                Console.WriteLine("Have a good day");//these will definately get printed at any how
            }
            Console.ReadLine();
        }
    }
}
