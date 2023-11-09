using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    internal class Program
    {
        void display()
        {
            Console.WriteLine("Normal Void Called, it need to create an instance of a class ");
        }
        static void fisplay()
        {
            Console.WriteLine("Static voidfisplay called successfully, here we do not have created instance.\nrather than that we can directly call class.function() to execute static method and function all over the program.");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.display();
            Program.fisplay();
            Console.ReadKey();
        }
    }
}
