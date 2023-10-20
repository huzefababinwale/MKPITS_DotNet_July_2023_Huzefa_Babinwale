using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt;
            int num = 10;
            for(cnt=1;cnt<=num; cnt++)
            {
                Console.Write(cnt+ "\t");
            }
            Console.ReadKey();
        }
    }
}
