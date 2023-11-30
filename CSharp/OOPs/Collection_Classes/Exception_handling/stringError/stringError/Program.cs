using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace stringError
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            
            catch(NullReferenceException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
