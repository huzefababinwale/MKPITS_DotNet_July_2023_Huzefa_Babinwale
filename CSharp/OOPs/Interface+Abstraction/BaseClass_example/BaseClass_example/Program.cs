using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_example
{
    class Animal
    {
        public string Color="Red";
    }
    class Dog: Animal 
    {
        public string Color = "Green";
    }
    class Cat : Animal
    {
        public string Color = "Black";
        public void display()
        {
            Console.WriteLine("Cat Color is " + Color + " Base class Color is " + base.Color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            Cat b= new Cat();
            b.display();
            Console.ReadKey();
        }
    }
}
