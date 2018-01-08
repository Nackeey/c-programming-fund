using System;
using System.Collections.Generic;
using System.Linq;

namespace exericises_03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] symbols = text.ToCharArray();
            string uniChars = string.Empty;
            foreach (var c in symbols)
            {
                uniChars += "\\u" + ((int)c).ToString("x4");
            }
            Console.WriteLine(uniChars);
        }
    }
}
