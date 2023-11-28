
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("a");
            li.Add("b");
            li.Add("c");
            li.Add("d");

            Console.WriteLine(li.Contains("a"));
            Console.WriteLine(li[0]);
            Console.WriteLine(li.Remove("a"));
            Console.WriteLine(li[0]);
            li.Insert(0, "a");
            Console.WriteLine(li[0]);

            li.Sort();
            Console.WriteLine();
            Console.WriteLine("Full List");
            foreach(string s in li)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();

        }
    }
}
