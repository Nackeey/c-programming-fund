using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surfacePattern = @"[^A-Za-z0-9]+";
            string mantlePattern = @"[0-9_]+";
            string corePattern = @"[A-Za-z]+";
            string midlePart = @"^[^A-Za-z0-9]+[0-9_]+((?<core>)[A-Za-z]+)[0-9_]+[^A-Za-z0-9]+$";
            bool isValid = false;
            int count = 0;
            string core = string.Empty;
            int coreLength = 0;

            string input = Console.ReadLine();

            if (Regex.IsMatch(input, surfacePattern))
            {
                input = Console.ReadLine();
                if (Regex.IsMatch(input, mantlePattern))
                {
                    input = Console.ReadLine();
                    if (Regex.IsMatch(input, midlePart))
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (char.IsLetter(input[i]))
                            {
                                count++;
                            }
                        }
                        input = Console.ReadLine();
                        if (Regex.IsMatch(input, mantlePattern))
                        {
                            input = Console.ReadLine();
                            if (Regex.IsMatch(input, surfacePattern))
                            {
                                isValid = true;
                            }
                        }
                    }
                }
            }
            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine($"{count}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
