using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Series_of_number
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int i = 1;
            StringBuilder sb = new StringBuilder();
            for (i= 0; i <= a; i++)
            {
                sb.Append("        "+i.ToString());
            }
            Label2.Text= sb.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {   
            int a = Convert.ToInt32(TextBox2.Text);
            int i = 1;
            int j;
            StringBuilder sb = new StringBuilder();

            for(i= 1; i <= a;i++)
            {
                for(j= 1; j <= i;j++)
                {
                    sb.Append(j + "     ");
                }
                sb.Append("<br>");
            }
            Label4.Text = sb.ToString();
        }


        
protected void Button3_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(TextBox3.Text);
            float b = Convert.ToSingle(TextBox4.Text);
            float c = a * b;
            Label7.Text = c.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(TextBox5.Text);
            float b = 2*3.14f*(a * a); //area 
            float c = 3.14f*(a * a); //Circumference
            Label9.Text = "Area of Circle : " + b.ToString() + "<br>" + "Circumference :" + c.ToString();
        }
    }
}