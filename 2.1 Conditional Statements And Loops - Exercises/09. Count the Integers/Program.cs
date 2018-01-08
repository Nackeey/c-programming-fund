using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = 0;
            while (true)
            {
                var input = Console.ReadLine();
                int number;

                var isParsed = Int32.TryParse(input, out number);

                if (isParsed)
                {
                    integers++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(integers);
        }
    }
}
