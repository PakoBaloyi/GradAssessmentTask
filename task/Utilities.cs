using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Utilities
    {
        public static void Q1()
        {
            Console.WriteLine("Enter a string");
            var input = Console.ReadLine();
            var convertedText = input.ToCharArray();
            Array.Reverse(convertedText);
            Console.WriteLine($"Input : {input}");
            Console.WriteLine($"Output :" + new string(convertedText));
        }
        public static void Q2()
        {
            Console.WriteLine("Enter a string");
            var input = Console.ReadLine();
            var convertedText = input.ToCharArray();
            Array.Reverse(convertedText);

            if (input.Equals(new string(convertedText)))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine(" is not Palindrome");

            }

        }
        public static string ReversedWordsInSentence(string input)
        {
            string[] convertedString = input.Split(' ');
            Array.Reverse(convertedString);
            string newSentence = string.Join(" ", convertedString);
            return newSentence;
        }
        public static void Q4()
        {
            Console.WriteLine("Enter a string");
            var input = Console.ReadLine();
            var convertedText = input.ToCharArray();
            Array.Reverse(convertedText);
            Console.WriteLine(ReversedWordsInSentence(new String(convertedText)));
        }

        
    }
}
