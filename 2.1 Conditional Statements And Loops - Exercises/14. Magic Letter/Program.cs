using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var thirdLetter = char.Parse(Console.ReadLine());

            for (int i = firstLetter; i <= secondLetter; i++)
            {
                for (char k = firstLetter; k <= secondLetter; k++)
                {
                    for (int j = firstLetter; j <= secondLetter; j++)
                    {
                        if (i != thirdLetter && k != thirdLetter && j != thirdLetter)
                        {
                            Console.Write($"{(char)i}{(char)k}{(char)j}" + " ");
                        }
                    }
                }
            }

        }
    }
}
