using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_Method
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
        public virtual void run() //we can not sealed on these method because its not override yet 
        {
            Console.WriteLine("I can Eat, walk and Run because I am Mammal");
        }
    }
    class Dog : Mammals
    {
        public override void Eat()
        {
            Console.WriteLine("Dog  eat Chicken with bread");
        }
        public override void run() //here we can see derived method is overrided and sealed so next class can not inheritate the property
        {
            Console.WriteLine("I can run more faster than you");
        }
    }
    class BabyDog : Mammals //we can not inheritate BabyDog method of run further more
    {
        sealed public override void run()
        {
            Console.WriteLine("I am slow in comapare of Dog");
        }
    }
    class animal : BabyDog
    {
        public override void run()//we are getting compile time error sealed method can not be inheritate
        {
            Console.WriteLine("Error");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BabyDog b=new BabyDog();
            b.run();
            b.Eat();


            Console.ReadKey();


        }
    }
}
