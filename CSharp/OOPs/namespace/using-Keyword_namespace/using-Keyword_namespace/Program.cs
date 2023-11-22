using System;
using First;
using Second;
using Third;

namespace First
{
    public class SayHello
    {
        public SayHello()//these is a constructor
        {
            Console.WriteLine("These belongs to First Namespace ");
        }
    }
}
namespace Second
{
    public class sayBy
    {
        public sayBy()
        {
            Console.WriteLine("These belongs to Second Namespace ");
        }
    }
}
namespace Third
{
    public class Priyanka
    {
        public Priyanka()
        {
            Console.WriteLine("Hello dear");
        }
    }
}
namespace using_Keyword_namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello f= new SayHello(); //Because of constructor we do not need to call any function or method to print results
            sayBy by = new sayBy();
                Priyanka oj=new Priyanka();//
            Console.ReadKey();
        }
    }
}
