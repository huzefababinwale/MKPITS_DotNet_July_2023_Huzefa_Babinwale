using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableby_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=1;
            int num2=4;
            Console.WriteLine("Enter Num");
            num2=Convert.ToInt32(Console.ReadLine());
            int i =1;

            while(num1<= num2)
            {
                while (i<=10)
                {
                    Console.Write("{0}*{1}= {2} ",i,num1,(i*num1));
                    Console.Write("\t");
                    i++;
                    
                }
                i = 1;
                num1++;
                Console.WriteLine("");
                
            }
            Console.ReadKey();
        }
    }
}
