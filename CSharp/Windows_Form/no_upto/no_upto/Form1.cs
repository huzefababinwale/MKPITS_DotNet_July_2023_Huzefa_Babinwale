using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace no_upto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int carry = 0;
        int res = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<int> l1= new LinkedList<int>();
            LinkedList<int> l2= new LinkedList<int>();
            LinkedList<int> l3= new LinkedList<int>();
            l1.AddFirst(9);
            l1.AddLast(9);
            l1.AddLast(9);
            l1.AddLast(9);
            l1.AddLast(9);
            l1.AddLast(9);
            l1.AddLast(9);

            
            l2.AddLast(9);
            l2.AddLast(9);
            l2.AddLast(9);
            l2.AddLast(9);
            
            StringBuilder sb=new StringBuilder();
            if(l1.Count ==l2.Count || l1.Count!=l2.Count )
            {
                if(l1.Count>l2.Count)
                {
                    for (int count = 0; count <= l1.Count; count++)
                    {
                        l2.AddLast(0);
                    }
                }
                else if (l1.Count < l2.Count)
                {
                    for(int count=0;count<=l2.Count;count++)
                    {
                        l1.AddLast(0);
                    }
                }
                
                var node1 = l1.First;
                var node2=l2.First;

                while (node1 != null && node2 != null)
                {
                    
                    res = node1.Value + node2.Value + carry;
                    if (res > 9)
                    {
                        int d = res / 10;
                        int r = res % 10;
                        l3.AddLast(r);
                        
                        carry = d;
                    }
                    else
                    {
                        l3.AddLast(res);
                    }
                    
                    node1 = node1.Next;
                    
                    node2=node2.Next;
                }
                if(carry!=0)
                {
                    l3.AddLast(carry);
                }
            }
            StringBuilder sb3 = new StringBuilder();
            foreach(int third  in l3) //to print List
            {   
                sb3.Append(third+"\t");
            }
            richTextBox1.Text= sb3.ToString();

        }
    }
}
