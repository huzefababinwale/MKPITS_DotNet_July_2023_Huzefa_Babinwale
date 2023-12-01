using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_outofmemory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "bobbey";
            string subject = "Devalejk";
            Console.WriteLine("Length= "+name.Length);

            StringBuilder sb= new StringBuilder(name.Length, name.Length);

            try
            {
                sb.Append(subject);
            }
            catch(ArgumentOutOfRangeException e) 
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}
