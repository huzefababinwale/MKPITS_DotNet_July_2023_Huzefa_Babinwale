using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace static_Bank_intrest
{
    internal class Program
    {
        public int AccountNum;
        public string Name;
        public static float RateOfIntreset=8.8f;
        public static int count;

        public void Bank(int AccountNum, string Name)
        {
            this.AccountNum=AccountNum;
            this.Name=Name;
            count++;
        }
        public void display()
        {
            Console.WriteLine("Account Number "+AccountNum+"Name"+Name + "Rate of Intrest "+RateOfIntreset);
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            Program p1= new Program();
            p.Bank(13234, "Avantak");
            p1.Bank(12356, "Patel");
            p.display();
            p1.display();
            Console.WriteLine("Counting "+count);
            Console.ReadLine();
        }
    }
}
