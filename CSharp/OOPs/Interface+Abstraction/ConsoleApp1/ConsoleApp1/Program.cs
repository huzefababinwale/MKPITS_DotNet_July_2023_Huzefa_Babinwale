using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Shape
    {
        void draw();
    }
    class Rectangle: Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle class printed ");
        }
    }
    class Circle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle initiated");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = null;
            Console.WriteLine("Please Choose between rectangle & circle: ");
            string st= Console.ReadLine();
               if (st=="rectangle")
            {
                s = new Rectangle();
            }
               else if (st=="circle")
            {
                s = new Circle();
            }
                s.draw();
            Console.ReadKey();
        }
    }
}
