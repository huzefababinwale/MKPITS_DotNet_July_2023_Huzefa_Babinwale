using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass_Demo
{
    abstract class Shape
    {
        public abstract string shape();
        public abstract void draw();
    }
    class Circle : Shape
    {
        public override string shape()
        {
            return "These is Circle Shape in shape function";
        }
        public override void draw() 
        {
            Console.WriteLine("Here we are in Draw Method for Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any number");
            Shape s=new Circle();
            /*s.shape();*/
            string sr = s.shape();
            Console.WriteLine(sr);
            
            s.draw();
            Console.ReadKey();
        }
    }
}
