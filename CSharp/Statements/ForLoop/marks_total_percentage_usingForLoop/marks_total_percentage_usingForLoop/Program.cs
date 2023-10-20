using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marks_total_percentage_usingForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt;
            int mark;
            int total=0;

            for (cnt=1;cnt<=5;cnt++)
            {
                Console.WriteLine("Enter Marks for Subject " + cnt + ": ");
                mark=Convert.ToInt32(Console.ReadLine());
                total = total + mark;
            }
            Console.WriteLine("Total of 3 subjects is: " + total);
            int per = total / 5;
            Console.WriteLine("Percentage : " + per+"%");
            while(true)
            {
                if(per>80)
                {
                    Console.WriteLine("A Grade");
                    break;
                }
                else if(per>60)
                {
                    Console.WriteLine("B Grade");
                    break;
                }
                else if (per>40)
                {
                    Console.WriteLine("C Grade");
                    break;
                }
                else
                {
                    Console.WriteLine("Grade: Mujhe Maaf Kro");
                    break;
                }
                    
            }

            Console.ReadKey();
        }
    }
}
