using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Simple_calculation_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, result=0;
            short choice;
            Console.WriteLine("Enter num1: ");
            num1=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Choose an Action to perform \n 1.Addition \n 2.Substraction \n 3.Multiplication \n 4.Division \n 5.Exit");
            choice= Convert.ToInt16(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    result =num1 + num2;
                    break;
                case 2:
                    result =num2 - num1;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result =num1 / num2;
                    break;
                case 5:
                    Environment.ExitCode = 0;
                    break;
                default:
                    Console.WriteLine("Please Write Valid Operator Option....");
                    break;
            }
            Console.WriteLine("Answer of your choice is {0} ", result);
            Console.ReadKey();

        }
    }
}
