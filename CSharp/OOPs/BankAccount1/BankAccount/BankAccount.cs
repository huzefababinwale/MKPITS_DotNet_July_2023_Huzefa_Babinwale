using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    internal class BankAccount
    {
        public int BankAccountNumber {  get; set; }
        public string BankHolderName {  get; set; }
        public int Balance {  get; set; }

        public void display()
        {

            Console.WriteLine("Bank Account Number: " + BankAccountNumber);
        }
    }

}
