using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace train_ticket_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin, destination;
            string date, cl="sl";
            int train_no, km;
            int classe, total_fare=0;
            string passanger_name;

            Console.WriteLine("Enter Passanger name: ");
            passanger_name = Console.ReadLine();

            Console.WriteLine("Enter Train Number: ");
            train_no =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Origin: ");
            origin = Console.ReadLine();

            Console.WriteLine("Enter Destination: "); 
            destination = Console.ReadLine();
            
            Console.WriteLine("Enter Date of Journey: ");
            date= Console.ReadLine();

            Console.WriteLine("Enter class 1 = 1 AC, 2 = 2 AC, 3 = 3 AC, 4= SL ");
            classe=Convert.ToInt32(Console.ReadLine());

            if (classe==1)
            {
                cl="1 AC";
            }
            else if (classe==2)
            {
                cl="2 AC";
            }
            else if(classe==3)
            {
                cl= "3 AC";
            }
            else if (classe == 4)
            {
                cl = "SL";
            }

            Console.WriteLine("Enter KM of journey");
            km= Convert.ToInt32(Console.ReadLine());
            
            if (km == 0)
            {
                total_fare= 0;
            }
            else if(km<=100)
            {
                total_fare = 100;
            }
            else if(km>100 && km <500)
            {
                total_fare = 500;
            }
            else if( km>500)
            {
                total_fare = 800;
            }

            Console.WriteLine("passanger_name: "+ passanger_name);
            Console.WriteLine("train no.: " + train_no);
            Console.WriteLine("Origine: " + origin);
            Console.WriteLine("Destination: "+ destination);
            Console.WriteLine("Date of Journey: " + date);
            Console.WriteLine("class of Reservation: " + cl);
            Console.WriteLine("Total Fair: " + total_fare);

            Console.ReadKey();

        }
    }
}
