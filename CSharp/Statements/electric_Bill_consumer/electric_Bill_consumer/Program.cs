using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electric_Bill_consumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string customer_name;
            short customer_id;
            short unit_consumed=0;
            short total_amount_due;
            float total_amount=1;
            float surcharge=0;

            Console.WriteLine("Enter Customer Name: ");
            customer_name = Console.ReadLine();

            Console.WriteLine("Enter Cussrtomer ID: ");
            customer_id=Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Unit Consumed: ");
            unit_consumed = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Total amount Due: ");
            total_amount_due = Convert.ToInt16(Console.ReadLine());

            if (unit_consumed > 0 && unit_consumed <= 199)
            {
                total_amount= unit_consumed * 1.20f;
            }
            else if(unit_consumed>200 &&  unit_consumed <=400)
            {
                total_amount=unit_consumed *1.50f;
            }
            else if(unit_consumed>400 && unit_consumed <=600)
            {
                total_amount = unit_consumed * 1.80f;
            }
            else if(unit_consumed>600)
            {
                total_amount = unit_consumed * 2.0f;
            }

            if (total_amount<100)
            {
                total_amount+=100;
            }
            else if (total_amount > 400)
            {
                surcharge = 15 * total_amount / 100;
                total_amount = surcharge + total_amount;

            }

            
            
            Console.WriteLine("customer ID: " + customer_id);
            Console.WriteLine("customer Name: " + customer_name);
            Console.WriteLine("unit consumed: " + unit_consumed);
            Console.WriteLine("amount charges: "+ total_amount );
            Console.WriteLine("surcharge amount: " + surcharge);

            Console.WriteLine("Net amount " + total_amount);
            total_amount =total_amount_due + total_amount ;

            Console.WriteLine("Total amount+ due" + total_amount);
            Console.ReadKey();

        }
    }
}
