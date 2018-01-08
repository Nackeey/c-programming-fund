using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();
            char[] arr = words[0].ToCharArray().Distinct().ToArray();      
            char[] arr2 = words[1].ToCharArray().Distinct().ToArray();

            if (arr.Length == arr2.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
