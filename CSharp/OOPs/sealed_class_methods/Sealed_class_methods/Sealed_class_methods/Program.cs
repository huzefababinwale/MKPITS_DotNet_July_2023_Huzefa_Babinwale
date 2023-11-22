using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class_methods
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("I can Eat Now in Animal class");
        }
    }
    class Mammals : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("I like Bread to eat");
        }
        public void run()
        {
            Console.WriteLine("I can Eat, walk and Run because I am Mammal");
        }
    }
    sealed class Dog:Mammals
    {
        public void Eat()
        {
            Console.WriteLine("Dog  eat Chicken with bread");
        }
        public void run()
        {
            Console.WriteLine("I can run more faster than you");
        }
    }
    class BabyDog : Mammals //we can not inheritate Dog here because Dog is sealed so let us continue with mammal
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
