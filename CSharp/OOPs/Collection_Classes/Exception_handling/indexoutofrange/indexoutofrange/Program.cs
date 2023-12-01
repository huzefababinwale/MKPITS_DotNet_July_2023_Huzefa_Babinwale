using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutofrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arg=new int[4];
            arg[0] = 1;
            arg[1] = 2;
            arg[2] = 3;
            arg[3] = 4;

            try
            {
                for(int i=0; i<=arg.Length;i++)
                {
                    Console.WriteLine(arg[i]);
                }
                /*Console.WriteLine(arg[5]);*/
            }
            catch(IndexOutOfRangeException io)
            {
                Console.WriteLine(io.Message);
            }

            Console.ReadKey();
            
        }
    }
}
