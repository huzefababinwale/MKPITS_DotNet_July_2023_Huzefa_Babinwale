using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server=.\\SQLEXPRESS; integrated security=true; database=Studentconnection";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(str);
                conn.Open();//in connected env. you have to explicitly open the connection using open method
                MessageBox.Show("Connected Successfully student");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mkpit = "server=.\\sqlexpress; integrated security=true; database=mkpits1";
            SqlConnection sqlmkpit = null;
            try
            {
                sqlmkpit = new SqlConnection(mkpit);
                sqlmkpit.Open();
                MessageBox.Show("connected Successfully MKPIT");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
