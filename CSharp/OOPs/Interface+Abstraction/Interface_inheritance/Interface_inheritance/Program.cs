using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_inheritance
{
    interface IDrawable
    {
        void Draw();
    }
    class Circle: IDrawable
    {
        void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
