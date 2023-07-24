using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace SET1
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordType = "whats";
            int lineNumber;
            lineNumber = 3;

            Console.WriteLine("1 When I wonder why,");
            Console.WriteLine("2 " + wordType + " never been's never been so");
            Console.WriteLine("" + lineNumber + " We would lie when we say 'yes you know we all love you'");
            wordType = "whos";
            Console.WriteLine("4 " + wordType + " never been's never been so");
            Console.WriteLine("5 hell we're nowhere now.");

            string phrase = "set2" + "set3";
            char grade = 's';
            int age = 16;
            double speed = 20.2;
            bool isMale = true;

            Console.WriteLine(phrase.Length);

            Console.ReadLine();
        }
    }
}
