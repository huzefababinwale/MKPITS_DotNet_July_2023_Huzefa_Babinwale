using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Member_Animal
{
    public class Animal
    {
        public string color = "Ameeridust";
    }
    public class Dog : Animal
    {
        public string color = "Red-Brown";
    }
    public class Cow : Animal
    {
        public string color = "White-Gray";
    }
                                                                                        
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            Console.WriteLine(d.color);
            Console.ReadKey();
        }
    }
}
