using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Doc_Interface_basics
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

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform rf=new registerform();
            rf.MdiParent = this;
            rf.Show();
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform af=new accountform();
            af.MdiParent = this;
            af.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform rf = new registerform();
            rf.MdiParent=this;
            rf.Show();
        }

        private void accountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            accountform af = new accountform();
            af.MdiParent = this;
            af.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            registerform rf = new registerform();
            rf.MdiParent = this;
            rf.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            accountform af = new accountform();
            af.MdiParent = this;
            af.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
