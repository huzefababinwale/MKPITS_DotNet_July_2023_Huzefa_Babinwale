using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_student_winform
{
    public class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name) 
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
}
