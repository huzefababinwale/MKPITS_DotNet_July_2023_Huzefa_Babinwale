using System;
using NumberToWords;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit_to_word_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit (0-9): ");
            int digit;
            if (int.TryParse(Console.ReadLine(), out digit))
            {
                if (digit >= 0 && digit <= 9)
                {
                    string word = NumberToWordsConverter.ConvertToWords(digit);
                    Console.WriteLine("Word representation: " + word);
                }
                else
                {
                    Console.WriteLine("Invalid digit. Please enter a digit (0-9).");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a digit (0-9).");
            }
        }
    }
}
