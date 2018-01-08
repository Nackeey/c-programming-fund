using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            string input = Console.ReadLine();

            while (input != "Odd" && input != "Even")
            {
                string[] commandArgs = input.Split(' ');

                switch (commandArgs[0])
                {
                    case "Delete":
                        int numberToDelete = int.Parse(commandArgs[1]);

                        numbers.RemoveAll(x => x == numberToDelete);

                        break;
                    case "Insert":
                        int index = int.Parse(commandArgs[2]);
                        int element = int.Parse(commandArgs[1]);

                        numbers.Insert(index, element);
                        break;
                }
                input = Console.ReadLine();
            }
            if (input == "Odd")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
            }

            if (input == "Even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
        }
    }
}
