using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    { 
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string didimonPattern = @"[^A-Za-z-]+";
            string bojoPattern = @"[A-Za-z]+\-[A-Za-z]+";

            while (true)
            {
                Match didiMatches = Regex.Match(text, didimonPattern);

                if (didiMatches.Success)
                {
                    Console.WriteLine(didiMatches.Value);
                    text = text.Substring(text.IndexOf(didiMatches.Value) + didiMatches.Value.Length);
                }
                else
                {
                    break;
                }
                Match bojoMatches = Regex.Match(text, bojoPattern);

                if (bojoMatches.Success)
                {
                    Console.WriteLine(bojoMatches.Value);
                    text = text.Substring(text.IndexOf(bojoMatches.Value) + bojoMatches.Value.Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
