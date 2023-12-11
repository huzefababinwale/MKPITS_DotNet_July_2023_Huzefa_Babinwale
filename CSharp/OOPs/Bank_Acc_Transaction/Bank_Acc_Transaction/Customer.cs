using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Acc_Transaction
{
    public class Customer
    {
        public string CustomerId { get; }
        public List<Account> Accounts { get; } = new List<Account>();

        public Customer(string customerId)
        {
            CustomerId = customerId;
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public decimal GetTotalBalance()
        {
            decimal totalBalance = 0;

            foreach (Account account in Accounts)
            {
                totalBalance += account.Balance;
            }

            return totalBalance;
        }

    }
}
