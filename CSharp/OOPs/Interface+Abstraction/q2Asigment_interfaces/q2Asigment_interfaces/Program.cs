using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2Asigment_interfaces
{
    interface IReadable
    {
        void ReadData();
        void WriteData(string data);
    }
    interface IWritable
    {
        void ReadData();
        void WriteData(string data);
    }
    class FileHandler:IReadable, IWritable
    {
        public void ReadData()
        {
            Console.WriteLine("Reading the Data......");
        }
        public void WriteData(string data)
        {
            Console.WriteLine(data);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandler FH= new FileHandler();
            FH.ReadData();
            FH.WriteData("THese is my message");
            Console.ReadKey();
        }
    }
}
