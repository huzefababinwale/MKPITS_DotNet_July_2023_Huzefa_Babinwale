using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ass2_Customer_Queue
{
   
    public class Customer
    {
        public int Id;
        public string CustomerName;
        public string CustomerEmail;
        public long CustomerMobile;
        public Customer(int id, string customerName, string customerEmail, long customerMobile)
        {
            this.Id = id;
            this.CustomerName = customerName;
            this.CustomerEmail = customerEmail;
            this.CustomerMobile = customerMobile;
        }
    }
}
