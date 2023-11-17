using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_User_input
{
    class Account
    {
        public long actno;
        public int balance = 1000;
        public virtual string deposit(int actno, int amount)
        {
            balance = amount + balance;
            return "Money deposited ";
        }
        public virtual string withdrawl(int actno,int amount)
        {
            balance = amount - balance;
            return "Money Withdrawl Successfully";
        }
        public void showbalance()
        {
            Console.WriteLine("Main Branch Balance : "+balance);
        }
    }
    class Saving:Account 
    {
        public override string deposit(int actno, int amount)
        {
            int intrest = 100;
            balance=balance+amount+intrest;
            return "Amount deposited in Saving Account";
        }
        public override string withdrawl(int actno, int amount)
        {
            balance=balance-amount;
            return "Ammount Withdrawl from Saving Account";
        }
    }
    class Current : Account
    {
        public override string deposit(int actno, int amount)
        {
            balance=balance+amount;
            return "Amount deposited in Current Account ";
        }
        public override string withdrawl(int actno, int amount)
        {
            balance = balance - amount;
            return "Ammount Withdrawl from Current Account";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = null;
            Console.WriteLine("Enter Account Type saving or current ");
            string a = Console.ReadLine();
            if (a=="saving")
            {
                act = new Saving();
            }
            else if(a=="current")
            {
                act = new Current();
            }


            Console.WriteLine("Enter Account Number ");
            int actno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press \t w -withdrawl\t d -deposit");
            string method=Console.ReadLine();

            Console.WriteLine("Enter Amount ");
            int b = Convert.ToInt32(Console.ReadLine());
            string with;
            string depo;
            if (method == "w")
            {
                with = act.withdrawl(actno, b);
                Console.WriteLine(with);
            }
            else if(method =="d")
            {
                depo = act.deposit(actno, b);
                Console.WriteLine(depo);
            }
                        
            
            act.showbalance();

            
            Console.ReadKey();
        }
    }
}
