using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bank_Acc_Transaction
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank();

            // Create customers and accounts
            Customer customer1 = new Customer("C1");
            Account account1 = new Account("A1", 1000);
            Account account2 = new Account("A2", 500);

            

            customer1.AddAccount(account1);
            customer1.AddAccount(account2);

            Customer customer2 = new Customer("C2");
            Account account3 = new Account("A3", 1500);

            customer2.AddAccount(account3);

            // Add customers to the bank
            bank.AddCustomer(customer1);
            bank.AddCustomer(customer2);

            // Display account details for a customer
            bank.DisplayCustomerAccountDetails("C1");
            bank.DisplayCustomerAccountDetails("C2");

            // Perform transactions
            account1.Deposit(200);
            account2.Withdraw(300);
            account3.Withdraw(200);

            // Display updated account details
            bank.DisplayCustomerAccountDetails("C1");
            bank.DisplayCustomerAccountDetails("C2");
            Console.ReadLine();
        }

    }
}


