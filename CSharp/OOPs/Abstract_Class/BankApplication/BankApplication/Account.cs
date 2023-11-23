using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    abstract class Account
    {        
            public int actno;
            public int bal = 1000;
        public int amt;
        public int intrest;
            public abstract string deposit(int amt);
            public abstract string withdrawl(int amt);
            public string ShowDetails(int actno)
        {
            return "Account num: "+actno +"\n Balance: "+ bal ;
        }
    }
    class Saving : Account
    {
        public override string deposit(int amt)
        {
            this.bal = bal + amt+intrest;
            return "balance is "+this.bal;
        }
        public override string withdrawl(int amt)
        {
            this.bal = bal - amt;
            return "balance is " + this.bal;
        }
    }
    class Current : Account
    {
        public override string deposit(int amt)
        {
            this.bal = bal + amt + intrest;
            return "balance is " + this.bal;
        }
        public override string withdrawl(int amt)
        {
            this.bal = bal - amt;
            return "balance is " + this.bal;
        }
    }
}
