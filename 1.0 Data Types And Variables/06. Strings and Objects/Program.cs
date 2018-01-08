using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordOne = Console.ReadLine();
            string wordTwo = Console.ReadLine();
            object greetings = wordOne + " " + wordTwo;
            string sentence = (string)greetings;

            Console.WriteLine(sentence);
        }
    }
}
