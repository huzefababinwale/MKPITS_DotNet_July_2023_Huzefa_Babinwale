using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_Collection_LIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            st.Push(6);

            Console.WriteLine("Current Stack");
            StringBuilder sb= new StringBuilder();
            foreach(int i in st)
            {
                sb.Append(i+"\n");
            }
            Console.WriteLine(sb.ToString());
            st.Pop();   //these functions will remove Latest updated itom ;
            
            foreach (int i in st)   //these allows us to reprint updates stack
            {
                sb.Append(i + "\n");
            }
            Console.WriteLine(sb.ToString());

            Console.WriteLine("The next poppable value in stack:{0}", st.Peek());
            //st.Peek() func allow us to know top most element of stackwe can also use it see last added value
            Console.ReadKey();

        }
    }
}
