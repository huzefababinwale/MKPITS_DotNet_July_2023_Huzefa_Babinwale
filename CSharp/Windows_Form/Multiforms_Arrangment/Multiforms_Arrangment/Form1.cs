using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiforms_Arrangment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string uname=textBox3.Text;
            string pass=textBox4.Text;
            if (uname != "admin" || uname != null)
            {
                if (pass != "admin" && pass != null)
                {
                    MessageBox.Show("updated succesfully" + uname);
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Password");
                }
            }
            else if (uname == "admin" && pass == "admin") 
            {
                MessageBox.Show("Already Existn please Login");
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform af=new accountform();
            af.MdiParent = this;
            panel1.Visible = false;
            af.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform rf=new registerform();
            rf.MdiParent = this;
            panel1.Visible = false;
            rf.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string uname = textBox3.Text;
            string pass = textBox4.Text;
            if (uname == "admin" || pass == "admin")
            {
                accountform af = new accountform();
                panel1.Visible = false;
                af.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text="";
        }
            
    }
}
