using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Babin");
            ht.Add(2, "wale");
            ht.Add(3, "Front End");
            ht.Add(4, "Back End");

            if (ht.ContainsValue("habibi"))
            {
                Console.WriteLine("Matching Value found");
            }
            else
            {
                ht.Add(5, "habibi");
            }

            StringBuilder sb= new StringBuilder();
            
            ICollection key = ht.Keys;

            foreach(int k in key)
            {
                Console.WriteLine(k + ":" + ht[k] +"\n");
            }
            Console.ReadLine();
        }
    }
}
