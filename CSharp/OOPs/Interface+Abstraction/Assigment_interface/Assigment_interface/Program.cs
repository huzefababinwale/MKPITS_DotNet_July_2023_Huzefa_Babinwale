using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_interface
{
    interface ILogger
    {
        string LogMessage(string message);
        string LogError(string errorMessage);
        
    }
    class ConsoleLogger : ILogger
    {
        public string LogMessage(string message)
        {
            Console.WriteLine(message); 
            return ""+message;
        }
        public string LogError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            return ""+errorMessage;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            ConsoleLogger cl=   new ConsoleLogger();
            string a=cl.LogMessage("Today is good day ");
            string b=cl.LogError("Today is Error Day ");
            
            Console.ReadKey();
        }
    }
}
