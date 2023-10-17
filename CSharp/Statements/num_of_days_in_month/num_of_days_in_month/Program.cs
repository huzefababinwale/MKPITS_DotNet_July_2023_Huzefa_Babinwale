using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_of_days_in_month
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 0;

            Console.WriteLine("Enter Month Num");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("January having 31 days");
                    break;
                case 2:
                    Console.WriteLine("February having 28 days");
                    break;
                case 3:
                    Console.WriteLine("March having 31 days");
                    break;
                case 4:
                    Console.WriteLine("April having 30 days");
                    break;
                case 5:
                    Console.WriteLine("May having 31 days");
                    break;
                case 6:
                    Console.WriteLine("June having 31 days");
                    break;
                case 7:
                    Console.WriteLine("July having 30 days");
                    break;
                case 8:
                    Console.WriteLine("August having 31 days");
                    break;
                case 9:
                    Console.WriteLine("September having 30 days");
                    break;
                case 10:
                    Console.WriteLine("Octomber having 31 days");
                    break;
                case 11:
                    Console.WriteLine("November having 30 days");
                    break;
                case 12:
                    Console.WriteLine("December having 31 days");
                    break;
                default:
                    Console.WriteLine("No Month Exists...");
                    break;
            }
            Console.ReadKey();

        }
    }
}
