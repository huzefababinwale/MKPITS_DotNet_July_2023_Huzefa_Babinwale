using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_saving_current_override
{
    class Account
    {
        public long actno;
        public int balance = 1000;

        public virtual string deposit(long actno , int amount)
        {

            return "Deposit Method of Account class";
        }
        public string showbalance()
        {
            return "balance amount: " + balance;
        }
    }
    class Current : Account
    {
        public override string deposit(long actno, int amount)
        {
            this.actno = actno;
            balance = balance+amount;
            return "amount deposited Succesfully in Current Class";
        }
    }
    class Saving : Account
    {
        public override string deposit(long actno, int amount)
        {
            this.actno = actno;
            balance = balance+amount;
            return "amount deposited Succesfully in Saving Class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            string res= act.deposit(1, 200);

            Console.WriteLine("Account number: " + act.actno);
            Console.WriteLine("Balance: "+res);
            res=act.showbalance();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
