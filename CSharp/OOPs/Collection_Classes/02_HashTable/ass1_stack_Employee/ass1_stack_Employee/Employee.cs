using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_stack_Employee
{
    public  class Employee
    {
        public int empno;
        public string empname;
        public int salary;
        public string designation;
        public Employee(int empno, string empname, int salary, string designation)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
            this.designation = designation;
        }


    }
}
