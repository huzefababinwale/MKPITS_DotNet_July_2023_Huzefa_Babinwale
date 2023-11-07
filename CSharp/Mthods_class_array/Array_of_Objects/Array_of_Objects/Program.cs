using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_Objects
{
    internal class Program
    {
        class Car
        {
            public string Model;
            public Car(string Model)
            {
                this.Model = Model;
            }
            public void display()
            {
                Console.WriteLine(Model);
            }
        }

        static void Main(string[] args)
        {
            Car[] car = new Car[3];

            car[0] = new Car();
            string[] guarage = {"Lambo","Mustang","Tesla"};

            for(int i=0;i< guarage.Length;i++)
            {
                Console.WriteLine("Write {0} number object name",i+1);
                
                guarage[i]= Console.ReadLine();
            }
            Console.WriteLine("Saving the data Written Down Below.....");
            for (int i = 0; i < guarage.Length; i++) 
            {
                Console.WriteLine(guarage[i]);
            }
            Array.Sort(guarage);

            Console.WriteLine("Applying Sorting Algorithms........");
            for (int i=0;i<guarage.Length; i++)
            {
                Console.WriteLine(guarage[i]);
            }

            
            
            Console.ReadKey();
        }
    }
}
