using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating..... ");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread...");
        }
    }
    public class Cat:Animal 
    {
        public override void eat()
        {
            Console.WriteLine("Eating Fish... ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal aa= new Animal();
            aa.eat();
            Animal a = new Dog();
            a.eat();
            Animal b= new Cat();
            b.eat();

            b.GetType();
            Console.ReadKey();
        }
    }
}
