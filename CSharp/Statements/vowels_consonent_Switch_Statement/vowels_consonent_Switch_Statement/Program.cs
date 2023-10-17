using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels_consonent_Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char word;
            Console.WriteLine("Enter Character: ");
            word=Convert.ToChar( Console.ReadLine());

            switch (word)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("It is Vowel ");
                    break;
                default: 
                    Console.WriteLine("It is Consonent ");
                    break;
            }
            Console.ReadKey();
            

        }
    }
}
