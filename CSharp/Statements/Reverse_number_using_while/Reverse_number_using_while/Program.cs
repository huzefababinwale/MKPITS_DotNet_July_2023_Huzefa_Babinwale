using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_number_using_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short num = 10;

            while (num > 0)
            {
                Console.WriteLine(num);
                num--;
            }
            Console.ReadKey();

        }
    }
}
