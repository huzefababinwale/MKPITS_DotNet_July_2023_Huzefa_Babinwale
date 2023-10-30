
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = { 1, 2, 3, 4, 5 };
            int length=arr.GetLength(0);
            *//*
            int length = arr.Length;
            *//*
            Console.WriteLine("Length= "+length);
            Console.ReadKey();

*/
            int[,] arr = { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9 },{ 1, 1, 1 } };
            int length=arr.GetLength(1);
            int breadth = arr.GetLength(0); 
            int total = arr.Length;
            Console.WriteLine("Length col by GetLength(1)= "+length);
            Console.WriteLine("Length row by GetLength(0)= "+breadth);
            Console.WriteLine("Total Elements counted by Length KeyWords= " + total);
            Console.ReadKey();
        }
    }
}
