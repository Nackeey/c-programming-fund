using System;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}
