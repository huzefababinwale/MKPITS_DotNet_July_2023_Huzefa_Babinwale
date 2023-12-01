using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Exception
{

    internal class Calculator
    {
        float n1, n2, res;
        public float Addition(float n1, float n2)
        {
            this.n1 = n1; this.n2 = n2;
            res = n1 + n2;
            return res;
        }
        public float Substraction(float n1, float n2)
        {
            this.n1 = n1; this.n2 = n2;
            res = n1 - n2;
            return res;
        }
        public float Multiplication(float n1, float n2)
        {
            this.n1 = n1; this.n2 = n2;
            res = n1 * n2;
            return res;
        }
        public float Division(float n1, float n2)
        {
            this.n1 = n1; this.n2 = n2;
            
            res = n1 / n2;
            return res;
        }
    }
}
