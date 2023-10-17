using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Geometry_Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            float radius, Area=0, l, b;

            Console.WriteLine("Enter Your Shape Choice \n 1.Circle \n 2.Square \n 3.Rectangle");
            choice=Convert.ToInt32( Console.ReadLine());
            

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter Radius of Circle: ");
                    radius= Convert.ToInt32( Console.ReadLine());
                    Area = 3.14f * radius * radius;
                    break;
                case 2:
                    Console.WriteLine("Enter Length of a Side: ");
                    l = Convert.ToInt32( Console.ReadLine());
                    Area = l * l;
                    break;
                case 3:
                    Console.WriteLine("Enter Lenth of Rec.:");
                    l=Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter Breadth of Rec.:");
                    b=Convert.ToSingle(Console.ReadLine());
                    Area = l * b;
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Option...");
                    break;

            }
            Console.WriteLine("Area of Provided Shape is {0} ", Area);
            Console.ReadKey();


        }
    }
}
