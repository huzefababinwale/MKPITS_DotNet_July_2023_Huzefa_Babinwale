using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radius_to_calc_area_circumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float pi = 3.14f;
            float radius, circum, area;
            Console.WriteLine("Enter Radius of Circle: ");
            radius = Convert.ToInt32(Console.ReadLine());
            area = pi * radius * radius;
            circum = 2 * pi* radius;
            Console.Write("area= "+area);
            Console.Write("circumference= " + circum);
            Console.ReadKey();

        }
    }
}
