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

namespace Disconnected_CRUD_operation
{
    public partial class Form1 : Form
    {
        public string Connectionstring { get; set; } = "server=.\\sqlexpress; integrated security =true; database=EmployeesWithConnection;";
        SqlDataAdapter adapter;
        DataSet dataset;
        SqlCommandBuilder scb;


        public Form1()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select * from EmployeeDetail", Connectionstring);
            dataset = new DataSet();
            scb = new SqlCommandBuilder(adapter);
            adapter.Fill(dataset, "Emp");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //steps to insert record in disconnected env
            //create a new row using datarow object
            DataRow dr = dataset.Tables["Emp"].NewRow();

            //add values to newly created datarow
            dr[0]=textBox1.Text;
            dr[1]=textBox2.Text;
            dr[2]=textBox3.Text;
            dr[3]=textBox4.Text;
            dr[4]=textBox5.Text;
            dr[5]=textBox6.Text;
            dr[6]=Convert.ToInt32(textBox7.Text);

            dataset.Tables["Emp"].Rows.Add(dr);
            //using new update add the new row to sql server data table,,

            adapter.Update(dataset.Tables["Emp"]);
            MessageBox.Show("Data Inserted Successfully");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataset.Tables["Emp"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in dataset.Tables["Emp"].Rows)
            {
                if (dr[0]==textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = textBox4.Text;
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        adapter.Update(dataset.Tables["Emp"]);
                        MessageBox.Show("Data Updated Successfully");
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show(ee.Message);    
                    }
                    break;
                }
            }
        }
    }
}
