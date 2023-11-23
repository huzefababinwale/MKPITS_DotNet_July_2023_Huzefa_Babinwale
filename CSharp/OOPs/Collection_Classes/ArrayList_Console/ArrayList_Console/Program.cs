using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayList_Console
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            Console.WriteLine("Enter Name to be stored in ArrayList: ");
            ar.Add("Raman");
            ar.Add("Suman");
            ar.Add("Niranjan");
            ar.Add("Manoranjan");
            ar.Sort();
           

            foreach(object obj in ar)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.ReadKey();
        }
    }
}
