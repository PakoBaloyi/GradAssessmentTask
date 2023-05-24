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
            Console.WriteLine("Q1");
            Console.WriteLine("Enter a string");
            var input = Console.ReadLine();
            var convertedText = input.ToCharArray();
            Array.Reverse(convertedText);
            Console.WriteLine($"Input : {input}");
            Console.WriteLine($"Output :" + new string(convertedText));
        }
        public static void Q2()
        {
            Console.WriteLine("Q2");
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
            Console.WriteLine("Q4");
            Console.WriteLine("Enter a string");
            var input = Console.ReadLine();
            var convertedText = input.ToCharArray();
            Array.Reverse(convertedText);
            Console.WriteLine(ReversedWordsInSentence(new String(convertedText)));
        }
        public static void Q5()
        {
            Console.WriteLine("Q5");
            Console.Write("Enter a string:");
            string input = Console.ReadLine();
            while (input.Length > 0)
            {

                int numberOfChar = 0;
                Console.Write("{0}=", input[0]);
                for (int i = 0; i < input.Length; i++)
                {       
                    if (input[0] == input[i])
                    {
                        numberOfChar++;
                    }
                }

                Console.WriteLine("{0}", numberOfChar);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
        }
    }
}
