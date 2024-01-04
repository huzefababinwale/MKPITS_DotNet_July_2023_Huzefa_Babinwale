using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentsInfoTracking
{
    internal class StudentClass
    {
        

        string strcon = "server=.\\sqlexpress; integrated security =true; database=studentconnection;";
        public string insertstudent(int rollno, string studname, string gender, string hobby, string city, string dob)
        {
            using( SqlConnection con = new SqlConnection(strcon)) 
            {
                con.Open();
                string str= "insert into studCollection values(@rollno,@studname,@gender,@hobby,@city,@dob)";
                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    cmd.Parameters.AddWithValue("@rollno",rollno);
                    cmd.Parameters.AddWithValue("@studname", studname);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@hobby", hobby);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "record Saved Successfully";
                }
            }
        }


        public string updatestudent(int rollno, string studname, string gender, string hobby, string city, string dob)
        {
            string strcon = "server=.\\sqlexpress; integrated security =true; database=studentconnection;";
            using (SqlConnection cmd = new SqlConnection(strcon)) 
            {
                cmd.Open();
                string str = "update studCollection set studname=@studname, gender= @gender,hobby=@hobby, city=@city, dob= @dob where rollno= @rollno";
                using (SqlCommand c = new SqlCommand(str, cmd))
                {
                    c.Parameters.AddWithValue("@studname", studname);
                    c.Parameters.AddWithValue("@gender", gender);
                    c.Parameters.AddWithValue("@hobby", hobby);
                    c.Parameters.AddWithValue("@city", city);
                    c.Parameters.AddWithValue("@dob", dob);
                    c.Parameters.AddWithValue("@rollno", rollno);
                    c.ExecuteNonQuery();
                    cmd.Close();
                    return "Update Successfully!!!";
                }
            }
        }

        public string deletestudent(int rollno, string studname)
        {
            using (SqlConnection c= new SqlConnection(strcon))
            {
                c.Open();
                string str = "delete from studCollection where rollno=@rollno or studname=@studname";
                using (SqlCommand cmd = new SqlCommand(str, c))
                {
                    cmd.Parameters.AddWithValue("@rollno", rollno);
                    cmd.Parameters.AddWithValue("@studname", studname);
                    cmd.ExecuteNonQuery();
                    c.Close();
                    return "record deleted successfully";
                }   
            }
        }

        public List<Class1> Searchstudent(int rollno) 
        {
            using (SqlConnection c = new SqlConnection(strcon)) 
            {
                c.Open();
                string str = "select * from studCollection where rollno =@rollno";
                using(SqlCommand cmd=new SqlCommand(str,c))
                {
                    cmd.Parameters.AddWithValue("@rollno", rollno);
                   
                    SqlDataReader dr = cmd.ExecuteReader();

                    List<Class1> li = new List<Class1>();
                    while (dr.Read())
                    {
                        li.Add( Class1(Convert.ToInt32(dr["rollno"].ToString())), dr["studname"].ToString(), dr["gender"].ToString(), dr["hobby"].ToString(), dr["city"].ToString(), dr["DOB"].ToString());
                    }
                    dr.Close();
                    c.Close();
                    return li;
                }
            }
        }

        
    }
}
