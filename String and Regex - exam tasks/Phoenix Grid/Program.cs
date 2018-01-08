using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"^([^_\s]{3})(\.[^_\s]{3})*$";


            while (text != "ReadMe")
            {
                Match check = Regex.Match(text, pattern);

                if (check.Success)
                {
                    var reversed = string.Join("", text.ToCharArray().Reverse());
                    
                    if (reversed == text)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
                text = Console.ReadLine();
            }
        }
    }
}
