using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];

            int i;
            char ch;
            for (i = 0, ch = 'a'; i < arr.Length; i++, ch++)
            {
                arr[i] = ch;
            }
            string input = Console.ReadLine();
            for (i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (input[i] == arr[j])
                    {
                        Console.WriteLine(input[i] + " -> " + j);
                    }
                }
            }


            //string letters = Console.ReadLine();

            //for (int i = 0; i < letters.Length; i++)
            //{
            //    var currentNum = (int)letters[i] - 97;
            //    Console.WriteLine("{0} -> {1}", letters[i], currentNum);
            //}


        }
    }
}
