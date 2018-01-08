using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', '?', '!', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));
        }

        static bool IsPalindrome(string word)
        {
            if (word.SequenceEqual(word.Reverse()))
            {
                return true;
            }
            else
            {
                return false;
            }
            //StringBuilder builder = new StringBuilder();
            //for (int i = word.Length - 1; i >= 0; i--) 
            //{
            //    builder.Append(word[i]);
            //}
            //string reversed = builder.ToString();
            //if (word == reversed)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
