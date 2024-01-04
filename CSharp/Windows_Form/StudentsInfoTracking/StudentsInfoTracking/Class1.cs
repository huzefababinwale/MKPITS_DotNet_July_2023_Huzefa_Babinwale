using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfoTracking
{
    internal class Class1
    {
        public int rollno { get; set; }
        public string studname { get; set; }
        public string gender { get; set; }
        public string hobby {  get; set; }
        public string city { get; set; }
        public string DOB { get; set; }
        public Class1(int rollno, string studname, string gender, string hobby, string city, string DOB)
        {
            this.rollno = rollno;
            this.studname = studname;
            this.gender = gender;
            this.hobby=hobby;
            this.city = city;
            this.DOB=DOB;
        }
    }
}
