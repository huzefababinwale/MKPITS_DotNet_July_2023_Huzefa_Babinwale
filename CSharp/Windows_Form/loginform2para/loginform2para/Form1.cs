using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform2para
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS;integrated security=true;database=studentconnection";
        SqlConnection con = null;
        SqlCommand command = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string qr = "Select count(*) from login where username =@username and password=@password";
                command = new SqlCommand(qr, con);

                command.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = textBox1.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = textBox2.Text;
                con.Open();
                int cnt = Convert.ToInt32(command.ExecuteScalar());
                if (cnt > 0)
                    label3.Text = "login successfull";
                else
                    label3.Text = "invalid credentail , try again";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { con.Close(); }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        public class insertlogin
        {
            public string insert(string username, string password)
            {
                string str = "server=.\\SQLEXPRESS;integrated security=true;database=studentconnection";
                SqlConnection con = null;
                SqlCommand command = null;
                con = new SqlConnection(str);
                con.Open();
                string qr = "insert into login values(@username=username, @password=password)";
                command = new SqlCommand(qr, con);
                command.Parameters.Add("@username", username);
                command.Parameters.Add("@password", password);
                string s = "ok";
                con.Close();
                return s;
                
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string o = textBox1.Text;
                string t = textBox2.Text;

                insertlogin i = new insertlogin();
                string result=i.insert(o, t);
                label3.Text= result.ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            
        }
    }
}
