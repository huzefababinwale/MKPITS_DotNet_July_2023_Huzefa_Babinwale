using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temprature_class_excp
{
    public class Temprature
    {
        int Temp= 0;
        public void ShowTemp()
        {
            if(Temp == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temprature = {0}", Temp);
            }   
        }
    }
    public class TempIsZeroException : ApplicationException
    {
        public TempIsZeroException(string message):base(message) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Temprature temp = new Temprature();
            try
            {
                temp.ShowTemp();
            }
            catch (TempIsZeroException to)
            {
                Console.WriteLine(to.ToString());
            }
            Console.ReadKey();
        }
    }
}
