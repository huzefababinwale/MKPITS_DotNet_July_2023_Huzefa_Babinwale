using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_Basics
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);
            int c = Convert.ToInt32(TextBox3.Text);
            int total=a+b+c;
            float per = total / 3;
            string grade;

            if(per > 90)
            {
                grade = "A+";
            }
            else if (per > 80)
            {
                grade = "A";
            }
            else if (per > 70)
            {
                grade = "B+";
            }
            else if (per > 80)
            {
                grade = "B";
            }
            else if (per > 70)
            {
                grade = "C+";
            }
            else if (per > 60)
            {
                grade = "C";
            }
            else 
            {
                grade = "Fail";
            }
            TextBox4.Text= grade.ToString();
            TextBox5.Text = total.ToString();
            TextBox6.Text = per.ToString();
        }

    }
}