using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_class
{
    internal class Program
    {
        class Rectangle
        {
            int width;
            int height;
            public int area(int width, int height)
            {
                this.width = width;
                this.height = height;
                int area=width*height;
                return area;
            }
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            int area=rect.area(5, 10);
            Console.WriteLine("Area of given Rectangle is: "+area);

            Console.ReadKey();
        }
    }
}
