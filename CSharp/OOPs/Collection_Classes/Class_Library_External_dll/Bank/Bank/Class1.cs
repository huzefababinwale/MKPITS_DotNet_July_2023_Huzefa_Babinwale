using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class bank
    {
        public int accountnum;
        public int bal;
        public abstract string deposit(int amount);
        public string withdrawl(int amount)
        {
            string res = null;
            if (bal<amount)
            {
                res = "insuficient Fund, Can not withdrawl amount";
            }
            else
            {
                bal=bal-amount;
                res = "amount withdrawl successfully, Current Balance is " + bal.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "balance amount is: " + bal.ToString();
        }
    }
    public class saving : bank
    {
        public override string deposit(int amount)
        {
            int interest = 300;
            bal = bal + amount + interest;
            return "amount deposit successfully,bal is: "+bal.ToString();
        }
    }
    public class current :bank 
    {
        public override string deposit(int amount)
        {
            bal = bal + amount;
            return "amount deposited Successfully,bal is: " + bal.ToString();
        }
    }
}
