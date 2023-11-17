using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Overriding_polymor
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Random one...");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
    internal class Program
    {
        public class TestPolymorphism
        {
            public static void Main(string[] args)
            {
                Shape s = new Shape();
                s.Draw();
                Shape c = new Circle();
                c.Draw();
                Shape r = new Rectangle();
                r.Draw();
                Console.ReadKey();
            }
        }
        
    }
}
