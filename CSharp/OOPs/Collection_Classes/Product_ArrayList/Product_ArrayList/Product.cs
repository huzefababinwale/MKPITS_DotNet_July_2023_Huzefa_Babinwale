using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_ArrayList
{
    public class Product
    {
        public int Product_ID;
        public string Product_Name;
        public int Product_Rate;
        public Product(int Product_ID, string Product_Name,int Product_Rate) 
        {
            this.Product_ID = Product_ID;
            this.Product_Name = Product_Name;
            this.Product_Rate = Product_Rate;
        }
    }
}
