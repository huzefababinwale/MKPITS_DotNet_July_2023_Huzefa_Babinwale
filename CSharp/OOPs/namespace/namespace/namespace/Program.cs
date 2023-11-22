using System;
namespace First //other namespaces are removed so that we can use custome namespace
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello First Namespace");
        }
    }
}
namespace Second
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello Second Namespace");
        }
    }
}



namespace @namespace
{
    class Program
    {
        public class TestNamespace
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello Namespace!");
                

                First.Hello h1=new First.Hello();
                Second.Hello h2=new Second.Hello();
                h1.sayHello();
                h2.sayHello();
                Console.ReadKey();
            }
        }
        
    }
}
