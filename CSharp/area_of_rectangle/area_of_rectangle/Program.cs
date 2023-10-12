using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, breadth, area;
            Console.WriteLine("Enter Length of Rectangle: ");
            length =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle: ");
            breadth=Convert.ToInt32( Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("Area of Rectangle is = " + area+"sq.ft.");
            Console.ReadKey();
        }
    }
}
