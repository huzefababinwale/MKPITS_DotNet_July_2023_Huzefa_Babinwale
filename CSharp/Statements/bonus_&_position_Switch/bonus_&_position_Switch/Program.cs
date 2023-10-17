using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus___position_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string i;
            int bonus = 0;
            Console.WriteLine("Enter Designation: ");
            i=Console.ReadLine();


            switch(i)
            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 1000;
                    break;
                default:
                    Console.WriteLine("please enter valid post: ");
                    break;
            }
            Console.WriteLine("Bonus is {0}", bonus);
            Console.ReadKey();
        }
    }
}
