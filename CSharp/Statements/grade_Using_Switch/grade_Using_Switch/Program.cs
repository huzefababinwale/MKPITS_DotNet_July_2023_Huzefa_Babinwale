using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_Using_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;

            Console.WriteLine("Enter Grade: ");
            grade = Console.ReadLine();

            switch (grade)
            {
                case "E":
                case "e":
                    Console.WriteLine("Excellent");
                    break;
                case "V":
                case "v":
                    Console.WriteLine("Very Good");
                    break;
                case "G":
                case "g":
                    Console.WriteLine("Good");
                    break;
                case "A":
                case "a":
                    Console.WriteLine("Average");
                    break;
                case "F":
                case "f":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Grade");
                    break;
            }
            Console.ReadLine();
        }
    }
}
