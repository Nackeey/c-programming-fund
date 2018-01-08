using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$";
            Regex regex = new Regex(pattern);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Over!")
            {
                Match match = regex.Match(input);
                int m = int.Parse(Console.ReadLine());
                StringBuilder sb = new StringBuilder();
                if (match.Success)
                {
                    string groups = match.Groups[1].Value + match.Groups[3].Value;
                    string digits = string.Empty;
                    foreach (var ch in groups)
                    {
                        if (char.IsDigit(ch))
                        {
                            digits += ch;
                        }
                    }
                    string secondGroup = match.Groups[2].Value;

                    if (secondGroup.Length == m)
                    {
                        for (int i = 0; i < digits.Length; i++)
                        {
                            int index = int.Parse(digits[i].ToString());

                            if (index < secondGroup.Length && index >= 0)
                            {
                                sb.Append(secondGroup[index]);
                            }
                            else
                            {
                                sb.Append(" ");
                            }
                        }
                        Console.WriteLine($"{secondGroup} == {sb}");
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
                
            }

        }
    }
}
