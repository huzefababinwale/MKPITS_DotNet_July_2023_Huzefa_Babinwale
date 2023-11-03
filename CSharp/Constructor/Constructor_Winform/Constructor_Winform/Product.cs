using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Winform
{
    internal class Product
    {
        public int ProductID{ get; set; }
        public string ProductName{ get; set; }
        public int ProductPrice{ get; set; }
        public int ProductQty{ get; set; }

        public Product()
        {
            ProductID = 0;
            ProductName = "ChuaMaar";
            ProductPrice = 20;
            ProductQty = 7;
        }
        public void display()
        {
            Console.WriteLine("Product ID: "+ProductID);
            Console.WriteLine("Product Name: "+ProductName);
            Console.WriteLine("Product Price: "+ProductPrice);
            Console.WriteLine("Product Quantity: "+ProductQty);
            Console.WriteLine("Total Cost: "+ProductPrice*ProductQty);
        }

    }
}
