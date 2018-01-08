using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstWord = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondWord = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var minLen = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLen; i++)
            {
                if (firstWord[i] < secondWord[i])
                {
                    foreach (char ch in firstWord)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    foreach (char ch in secondWord)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    return;
                }
                else if(secondWord[i] < firstWord[i])
                {
                    foreach (char ch in secondWord)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    foreach (char ch in firstWord)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    return;
                }
            }
            if (firstWord.Length < secondWord.Length)
            {
                Console.WriteLine(new string(firstWord));
                Console.WriteLine(new string(secondWord));
            }
            else
            {
                Console.WriteLine(new string(secondWord));
                Console.WriteLine(new string(firstWord));
            }
        }
    }
}

