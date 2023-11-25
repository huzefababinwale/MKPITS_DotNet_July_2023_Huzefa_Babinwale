using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedList_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sr = new SortedList();
            sr.Add(1, "a");
            sr.Add(2, "b");
            sr.Add(3, "c");
            sr.Add(4, "d");
            sr.Add(5, "e");

            StringBuilder sb= new StringBuilder();
            ICollection key = sr.Keys;
            foreach(int k in key )
            {
                sb.Append("Key: "+k +"\tValue: " + sr[k]+"\n");
            }
            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
