using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_reverse_order_print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a; char b; char c;
            Console.WriteLine("Enter letter : ");
            a=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter letter : ");
            b=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter letter : ");
            c=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("char {2}, {1}, {0}",a,b,c);
            Console.ReadKey();

        }
    }
}
