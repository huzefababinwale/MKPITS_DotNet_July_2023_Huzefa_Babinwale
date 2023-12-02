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

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<int> l1= new LinkedList<int>();
            LinkedList<int> l2= new LinkedList<int>();
            LinkedList<int> l3= new LinkedList<int>();
            l1.AddFirst(2);
            l1.AddLast(4);
            l2.AddFirst(5); 
            l2.AddLast(6);
            int res = 0;
            StringBuilder sb=new StringBuilder();
            if(l1.Count ==l2.Count )
            {
                var node1 = l1.First;
                var node2=l2.First;

                while(node1!=null && node2!=null)
                {
                    res = node1.Value + node2.Value;
                    l3.AddLast(res);
                    node1 = node1.Next;
                    node2=node2.Next;
                }
            }
            StringBuilder sb3 = new StringBuilder();
            foreach(int third  in l3)
            {

                sb3.Append(third+"\t");

            }
            label1.Text= sb3.ToString();



            /*foreach (int l in l1)
            {

                foreach (int t in l2)
                {

                    res = l + t;
                    l3.AddLast(res);
                }
            }*/


        }
    }
}
