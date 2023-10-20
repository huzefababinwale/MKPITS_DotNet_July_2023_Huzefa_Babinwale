using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_in_amount_till_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cnt;
            int sum = 1;
            Console.WriteLine("How Much odd no. you want: ");
            num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("From Which number you want to start: ");
            cnt= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");

            while (true)
            {
                if (sum <= num)
                {
                    if (cnt % 2 != 0)
                    {
                        Console.WriteLine(cnt);
                        sum++;
                    }
                }
                cnt++;
            }
        }
    }
}
