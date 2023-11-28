using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_console
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddLast(4);
            

            list.AddBefore(list.Find(4),8);
            list.Remove(4);
            string li;
           

            Console.WriteLine("Full list ");
            foreach (int n in list)
            {
                Console.WriteLine(n + "\n");
            }

            
            
            Console.ReadKey();
            
        }
    }
}
