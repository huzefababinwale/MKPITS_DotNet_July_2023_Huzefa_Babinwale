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

namespace Cource_Registration_Fendahl
{

    public partial class Form1 : Form
    {
        string strcon = "server=.\\sqlexpress;integrated security=true;database=PracticeDB";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getNation();
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            if (radioButton1.Checked)
                textBox2.Text = "1000";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getState();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCity();
        }
        public void getNation()
        {
            try
            {
                con = new SqlConnection(strcon);
                adapter = new SqlDataAdapter("select * from TableNation order by NationID ", con);
                ds = new DataSet();
                adapter.Fill(ds, "TableNation");
                comboBox1.DataSource = ds.Tables["TableNation"];
                comboBox1.DisplayMember = "NationName";
                comboBox1.ValueMember = "NationID";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void getState()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
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
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
        public void getCity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    adapter = new SqlDataAdapter("Select * from TableCity where stateID=@stateID", con);
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

        public enum category { student, it_professional }
        public enum gender { male, female, other }
        category cat;
        gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            
            Time();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Full Name");
            }
            else
            {
                float amt = Convert.ToInt32(textBox3.Text);
                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.5f;
                if (radioButton1.Checked)
                {
                    cat = category.student;
                    if (amt < fp)
                    {
                        MessageBox.Show("Minimum 50 % Amount to be deposited to continue ");
                    }
                    else
                    {
                        float balamt = ta - amt;
                        textBox4.Text = balamt.ToString();
                    }
                }
                else if (radioButton2.Checked)
                {
                    cat = category.it_professional;
                }

                
                
                if (radioButton4.Checked) { gen = gender.male; }
                if (radioButton3.Checked) { gen = gender.female; }
                if (radioButton5.Checked) { gen = gender.other; }
                calculate();
                savecourseregdetail(cat, gen);
            }
        }
        public void Time()
        {
            // Validate that the selected date is not earlier than today
            DateTime selectedDate = dateTimePicker1.Value;
            if (selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a payment date that is on or after today's date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calculate()
        {
            if (cat == category.student)
            {
                textBox2.Text = "1000";
                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.5f;
                
                float amt = Convert.ToSingle(textBox3.Text);
                if (amt < fp)
                {
                    MessageBox.Show("Minimum 50 % Amount to be deposited to continue ");
                }
                else
                {
                    float balamt = ta - amt;
                    textBox4.Text = balamt.ToString();
                }
            }
            else if (cat == category.it_professional)
            {
                textBox2.Text = "3000";
                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);
                if (amt < fp)
                {
                    MessageBox.Show("Minimum 80 % Amount to be deposited to continue ");
                }
                else
                {
                    float balamt = ta - amt;
                    textBox4.Text = balamt.ToString();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "1000";
            float ta = Convert.ToSingle(textBox2.Text);
            float fp = ta * 0.5f;            
        }
        public float fp;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "3000";
            float ta = Convert.ToSingle(textBox2.Text);
            fp = ta * 0.8f;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void savecourseregdetail(category c, gender g)
        {
            try
            {
                string str = "insert into TableCourseRegDetail values(@CategoryInd,@FullName,@GenderInd)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@CategoryInd", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@FullName", textBox1.Text);
                command.Parameters.AddWithValue("@GenderInd", Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                //   MessageBox.Show("record saved");
                con.Close();
                insertRegAddress();

            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
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
            insertFeeDetail();
        }

        public void insertFeeDetail()
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

        public void clear()
        {
            
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}