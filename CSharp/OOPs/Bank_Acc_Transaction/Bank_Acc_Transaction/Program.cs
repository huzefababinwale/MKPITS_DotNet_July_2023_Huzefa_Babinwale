using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Acc_Transaction
{
    internal class Program
    {
        class Bank
        {
            int Acc_no;
            string Acc_name;
            int Balance;


            public void get_data(int Acc_no, string Acc_name, int Balance)
            {
                this.Acc_no = Acc_no;
                this.Acc_name = Acc_name;
                this.Balance = Balance;

            }
            public void transfer()
            {
                Console.WriteLine(" Balance \t"+Balance + "Account no. \t "+Acc_no +" Account Holder Name:   "+Acc_name);               
            }
            public int deposit(int d)
            {
                Balance = Balance - d;
                return Balance;
            }
            public void withdrawl(int ch)
            {
                Balance = Balance + ch;
            }
            
           
        }
        static void Main(string[] args)
        {
            Bank[] bank = new Bank[2];
            bank[0]= new Bank();
            bank[1]= new Bank();
            

            for (int i = 0; i < bank.Length; i++)
            {
                Console.WriteLine("Enter Acc_no ");
                int num = Convert.ToInt32(Console.ReadLine());                
                Console.WriteLine("Enter Name ");
                string name = (Console.ReadLine());                
                Console.WriteLine("Enter Initial Balance ");
                int bal = Convert.ToInt32(Console.ReadLine());

                bank[i].get_data(num, name, bal);
            }
            for(int i = 0;i < bank.Length;i++)
            {
                bank[i].transfer();
            }
            Console.WriteLine("Press 1- for 1st account to second \n 2- for 2nd account to first");
            int ch = 0;
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter Ammount to be transfered: ");
                ch= Convert.ToInt32(Console.ReadLine());
                int ll=bank[0].deposit(ch);
                Console.WriteLine("Remaining Balance: " + ll);
                bank[1].withdrawl(ch);
                bank[0].transfer();
            }
            else if(choice==2)
            {
                Console.WriteLine("Enter Ammount to be transfered: ");
                ch=Convert.ToInt32(Console.ReadLine());
                bank[1].deposit(ch);
                bank[0].withdrawl(ch);
                bank[1].transfer();
            }

            Console.ReadKey();

        }
    }
}
