using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace Machine_Test_practice
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\sqlexpress;integrated security=true; database=production";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Form1()
        {
            InitializeComponent();

        }
        public enum category { student, it_professional}
        public enum gender { male, female, other }
        public float fp;
        private void Form1_Load(object sender, EventArgs e)
        {
            getNation();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCity();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getState();
        }


        public void getNation()
        {
            try
            {
                con = new SqlConnection(strcon);
                adapter = new SqlDataAdapter("Select * from TableNation order by NationID", con);

                ds = new DataSet();
                adapter.Fill(ds, "TableNation");
                comboBox1.DataSource = ds.Tables["TableNation"];
                comboBox1.DisplayMember = "NationName";
                comboBox1.ValueMember = "NationID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void getState()
        {
            try
            {
                con = new SqlConnection(strcon);
                adapter = new SqlDataAdapter("Select * from TableState where NationID=@NationID", con);
                adapter.SelectCommand.Parameters.AddWithValue("@NationID", comboBox1.SelectedValue);
                ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds, "TableState");
                comboBox2.DataSource = ds.Tables["TableState"];
                comboBox2.DisplayMember = "StateName";
                comboBox2.ValueMember = "StateID";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void getCity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    adapter = new SqlDataAdapter("Select * from TableCity where StateID=@StateID", con);
                    adapter.SelectCommand.Parameters.AddWithValue("@stateID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    adapter.Fill(ds, "TableCity");
                    comboBox3.DataSource = ds.Tables["TableCity"];
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.ValueMember = "CityID";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
        public category ca;
        public gender ge;
        string FullName;
        decimal total;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Please fill Name First");
            }
            else
            {
                if (radioButton1.Checked) { ca = category.student; total = 1000;textBox2.Text = total.ToString(); }
                if (radioButton2.Checked) { ca = category.it_professional; total = 3000;textBox2.Text = total.ToString(); }
                if(textBox3.Text!=null)
                {
                    int paid=Convert.ToInt32(textBox3.Text);
                    MessageBox.Show("Paid " + paid);
                }
                if (radioButton3.Checked) { ge = gender.male; }
                if(radioButton4.Checked) { ge=gender.female; }
                if (radioButton5.Checked) {  ge=gender.other; }

                FullName=textBox1.Text;
                savecourse(ca, ge);
            }
        }


        public void savecourse(category c,gender g)
        {
            try
            {
                string str = "insert into Table TableCourseRegDetail values(CategoryID, FullName, GenderID)";
                SqlCommand command = new SqlCommand(strcon, con);
                command.Parameters.AddWithValue("@CategoryInd", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@FullName", textBox1.Text);
                command.Parameters.AddWithValue("@GenderInd", Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                //   MessageBox.Show("record saved");
                con.Close();
                insertRegAddress();
                insertFeesDetails();
            }
            catch(Exception ee)
            { 
                MessageBox.Show(ee.ToString()); 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text =  1000.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = 3000.ToString();
        }
        public void calculate()
        {

        }
        public void insertRegAddress()
        {
            con.Open();

            string str = "select max(CourseRegID) from TableCourseRegDetail";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());
            // MessageBox.Show(mcid.ToString());
            string s2 = "insert into TableRegAddress values(@CourseRegID,@NationID,@StateID,@CityID)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@NationID", SqlDbType.Int).Value = comboBox1.SelectedValue;
            cmd1.Parameters.Add("@StateID", SqlDbType.Int).Value = comboBox2.SelectedValue;
            cmd1.Parameters.Add("@CityID", SqlDbType.Int).Value = comboBox3.SelectedValue;
            cmd1.ExecuteNonQuery();
            // con.Close();
            MessageBox.Show("Stored TableRegAddress");


            con.Close();
            
        }
        public void insertFeesDetails()
        {
            con.Open();

            string str = "select max(CourseRegID) from TableCourseRegDetail";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());

            string s2 = "insert into TableFeeDetail values(@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = textBox2.Text;
            cmd1.Parameters.Add("@MinPer", SqlDbType.Int).Value = fp;
            cmd1.Parameters.Add("@PaidAmount", SqlDbType.Int).Value = textBox3.Text;
            cmd1.Parameters.Add("@BalAmount", SqlDbType.Int).Value = textBox4.Text;
            cmd1.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stored TableFeeDetail");
        }
    }
}
