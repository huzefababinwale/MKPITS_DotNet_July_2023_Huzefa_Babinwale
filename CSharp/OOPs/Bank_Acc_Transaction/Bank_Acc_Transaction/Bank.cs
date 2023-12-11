using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Acc_Transaction
{
    public class Bank
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void DisplayCustomerAccountDetails(string customerId)
        {
            Customer customer = customers.Find(c => c.CustomerId == customerId);

            if (customer != null)
            {
                Console.WriteLine($"Customer ID: {customer.CustomerId}");
                Console.WriteLine("Account Details:");

                foreach (Account account in customer.Accounts)
                {
                    Console.WriteLine($"Account ID: {account.AccountId}, Balance: {account.Balance}");
                }

                Console.WriteLine($"Total Balance: {customer.GetTotalBalance()}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
    }

}

