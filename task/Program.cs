using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task;

namespace AssessmentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Utilities.Q1();
            Utilities.Q2();
            Console.WriteLine("Q3 Enter a string");
            string input = Console.ReadLine();
            Utilities.ReversedWordsInSentence((input));
            Utilities.Q4();
            Utilities.Q5();

        }
    }
}
