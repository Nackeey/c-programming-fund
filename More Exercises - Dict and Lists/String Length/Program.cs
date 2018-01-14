using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = input.Length >= 20 ? input.Substring(0, 20) : input + new string('*', 20 - input.Length);

            Console.WriteLine(result);
        }
    }
}
