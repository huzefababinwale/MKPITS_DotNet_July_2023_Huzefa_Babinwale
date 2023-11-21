using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_using_interface
{
    interface Bank
    {
        
        void showdetails();
        void deposit(int acno, int amount);
        void withdrawl(int acno, int amount);
        
    }
    class saving : Bank
    {
        int acno;
        int bal = 1000;
        int intrest = 252;

        public void showdetails()
        {
            Console.WriteLine("account number= "+acno+" \n Previous Balance was 1000 & Current Balance= "+bal);
        }
        public void deposit(int acno, int amount)
        {
            this.acno = acno;
            bal=this.bal+amount+intrest;
        }
        public void withdrawl(int acno, int amount)
        {
            this.acno = acno;
            bal=this.bal-amount;
        }
    }
    class current:Bank
    {
        int acno;
        int bal = 1000;

        public void showdetails()
        {
            Console.WriteLine("account number= " + acno + " Balance= " + bal);
        }
        public void deposit(int acno, int amount)
        {
            this.acno=acno;
            bal = this.bal + amount ;
        }
        public void withdrawl(int acno, int amount)
        {
            this.acno = acno;
            bal = this.bal - amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string bt;
            Console.WriteLine("Write type of account saving or current");
            bt=Console.ReadLine();
            Bank b = null;

            switch(bt)
            {
                case "saving":
                    b = new saving();
                    break;
                case "current":
                    b= new current();
                    break;
                default:
                    Console.WriteLine("Please Enter valid type in string formate...");
                    break;
            }
            Console.WriteLine("Enter w-Withdrawl \t d-deposit the amount: ");
            string tt=Console.ReadLine() ;
            Console.WriteLine("Enter Amount: ");
            int amt =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account number: ");
            int acn = Convert.ToInt32(Console.ReadLine());
            if (tt=="w")
            {
                b.withdrawl(acn, amt);
            }
            else if (tt=="d")
            {
                b.deposit(acn, amt);
            }

            b.showdetails();
            Console.ReadKey();
        }
    }
}
