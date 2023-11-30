using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace throw_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new Exception("Age is below 18 from 'Throw' class");
                }
                else
                {
                    Console.WriteLine("Code Completed");
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter Age above 18: ");
                age=Convert.ToInt32(Console.ReadLine());
            }
            finally 
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("Age = " + age);
            }
            Console.WriteLine("Have a Nice Day");
            Console.ReadKey();

        }

    }
}
