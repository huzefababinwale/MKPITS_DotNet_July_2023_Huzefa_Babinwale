using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i= 32;
            
            try
            {
                Console.WriteLine("Enter number");
                i = Convert.ToInt32(Console.ReadKey());
            }
            catch(InvalidCastException inv) 
            {
                Console.WriteLine(inv.ToString());
            }
            
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
