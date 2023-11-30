using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 10;
            int s = 0;
            /*int rs = r / s;*///these will through error in runtime 'Divided by zero'
            int rs = 0;
            try
            {
                rs = r / s;
            }
            catch(Exception ee)
            {
                Console.WriteLine("Can not Divided by Zero");
            }
            Console.WriteLine("result "+rs);
            Console.WriteLine("by");
            Console.ReadKey();

        }
    }
}
