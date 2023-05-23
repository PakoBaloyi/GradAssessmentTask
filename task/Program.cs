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
            Console.WriteLine("Select 1: Q1"+"\n"+"2: Q2" + "\n" +  "3: Q3" + "\n" + "4: Q4" + "\n" + "5: Q5");
            int response= int.Parse(Console.ReadLine());
            
            switch (response)
            {
                case 1:
                      Utilities.Q1();
                      break;
                case 2:
                      Utilities.Q2();
                      break;
                case 3:
                    break;
                case 4:
                    Utilities.Q1();
                    break;
                case 5:
                    Utilities.Q1();
                    break;
            }
            
        }
    }
}
