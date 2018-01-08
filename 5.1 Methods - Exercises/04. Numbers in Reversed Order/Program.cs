using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();
            var commands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(Reverse(words[commands[3]]));


             
        }

        static string Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
