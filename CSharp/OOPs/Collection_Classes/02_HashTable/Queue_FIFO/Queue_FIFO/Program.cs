using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_FIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);
            qu.Enqueue(5);
            /*qu.Dequeue();*/
            StringBuilder sb = new StringBuilder();
            foreach(int i in qu)
            {
                sb.Append(i+"\n");
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Removing some values");
            
            int j=(int)qu.Dequeue();
            foreach (int i in qu)
            {
                sb.Append(i + "\n");
            }
            Console.WriteLine(sb.ToString());

            Console.ReadLine();

        }
    }
}
