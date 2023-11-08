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
            public string Color;
            public Car(string Model, string Color)
            {
                this.Model = Model;
                this.Color= Color;
            }
            ~Car()
            {
                Console.WriteLine("Mission Abort ");
            }
        }

        static void Main(string[] args)
        {
            Car[] guarage = new Car[3];
            string col,mod;
            for(int i=0;i< guarage.Length;i++)
            {
                Console.WriteLine("Write {0} number object name and color",i+1);
                mod=Console.ReadLine();
                col= Console.ReadLine();
                guarage[i] = new Car(mod, col);
            }
            Console.WriteLine("Saving the data Written Down Below.....");
            for (int i = 0; i < guarage.Length; i++) 
            {
                Console.WriteLine(guarage[i].Model);
                Console.WriteLine(guarage[i].Color);
            }
/*            Array.Sort(guarage);
*/
            Console.WriteLine("Applying Sorting Algorithms........");
            for (int i=0;i<guarage.Length; i++)
            {
                Console.WriteLine(guarage[i].Model);
                Console.WriteLine(guarage[i].Color);

            }

            
            
            Console.ReadKey();
        }
    }
}
