using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_of_no_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            int cnt = 1;
            Console.WriteLine("Enter Number to print Table: ");
            num=Convert.ToInt32(Console.ReadLine());
            for (cnt=1; cnt<=10;cnt++)
            {
                Console.WriteLine("{0}*{1}={2}",num, cnt,(cnt * num));
            }
            Console.ReadLine();
        }
    }
}
