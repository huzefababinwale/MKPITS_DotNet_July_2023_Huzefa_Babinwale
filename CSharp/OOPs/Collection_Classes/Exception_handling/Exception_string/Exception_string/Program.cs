using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("amitabh");
            sb.Append("bachan");
            Console.WriteLine("sb= "+sb.ToString());
            object obj = sb;

            Console.WriteLine("obj= "+obj.ToString());

            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("it is near to end, Good by....");
            }
            Console.ReadKey();
        }
    }
}
