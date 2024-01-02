using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Database_Connect2
{

    public partial class Form1 : Form
    {
        static class DatabaseConnection
        {
            public static string strcon = "server=.\\sqlexpress; integrated security=true; database=studentconnection";
            public static SqlConnection getConnection()
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(strcon);
                    con.Open();
                    return con;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection can= DatabaseConnection.getConnection();
            if(can!=null)
            {
                can.Open();
                MessageBox.Show("Successfully Connected");
                can.Close();
            }
            else
            {
                MessageBox.Show("Could not Connect to sqlServer");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.getConnection();
            if(con!=null)
            {
                MessageBox.Show("Successfully Worked Button 2");
                con.Close();
            }
            else
            {
                MessageBox.Show("Could Not Connect to Sql Server");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "server=.\\sqlexpress; integrated security=true; database=studentconnection";
            SqlConnection con=new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd= "insert into student Values('" + textBox1.Text +"','"+textBox2.Text +"')";

                SqlCommand command= new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record updated successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "server=.\\sqlexpress; integrated security = true; database =studentconnection ";
            SqlConnection conn = new SqlConnection(str);
            try
            {
                conn.Open();
                string strcmd = "update student set Password='" + textBox2.Text + "'where username='" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, conn);
                command.ExecuteNonQuery();
                conn.Close();
                label3.Text = "record Updated Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error Encountered"+ee.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = "server=.\\sqlexpress; integrated security=true ;database=studentconnection";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd= "delete from student where username='"+ textBox1.Text+"'";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label3.Text = "record deleted Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "server=.\\sqlexpress; integrated security=true; database=studentconnection";
            SqlConnection con= new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "select * from student where username='"+textBox1.Text+"'";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                SqlDataReader dr;
                int flag = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["password"].ToString();
                }
                dr.Close();
                con.Close();
                if(flag==0)
                {
                    label3.Text = "No record Found";
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
