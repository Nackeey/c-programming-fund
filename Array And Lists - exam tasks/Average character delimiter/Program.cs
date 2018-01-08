using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_character_delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            int charCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    sum += input[i];
                    charCounter++;
                }
            }
            int num = sum / charCounter;
            char ch = Convert.ToChar(num);

            if (char.IsLetter(ch))
            {
                ch = char.ToUpper(ch);
            }
            string result = input.Replace(' ', ch);

            Console.WriteLine(result);
        }
    }
}
