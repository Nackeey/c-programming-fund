using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                var commandArgs = command.Split();
                string comm = commandArgs[0];

                switch (comm)
                {
                    case "exchange":
                        int index = int.Parse(commandArgs[1]);
                        if (index < 0 || index > arr.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            var rem = arr.Take(index + 1).ToArray();
                            arr.RemoveRange(0, index + 1);
                            arr.AddRange(rem);
                        }
                        break;

                    case "max":
                        if (commandArgs[1] == "even")
                        {
                            if (arr.Any(x => x % 2 == 0))
                            {
                                Console.WriteLine(arr.LastIndexOf(arr.Where(x => x % 2 == 0).Max()));
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        if (commandArgs[1] == "odd")
                        {
                            if (arr.Any(x => x % 2 != 0))
                            {
                                Console.WriteLine(arr.LastIndexOf(arr.Where(x => x % 2 != 0).Max()));
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;

                    case "min":
                        if (commandArgs[1] == "even")
                        {
                            if (arr.Any(x => x % 2 == 0))
                            {
                                Console.WriteLine(arr.LastIndexOf(arr.Where(x => x % 2 == 0).Min()));
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }

                        if (commandArgs[1] == "odd")
                        {
                            if (arr.Any(x => x % 2 != 0))
                            {
                                Console.WriteLine(arr.LastIndexOf(arr.Where(x => x % 2 != 0).Min()));
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }

                        break;

                    case "first":
                        if (commandArgs[2] == "even")
                        {
                            int count = int.Parse(commandArgs[1]);
                            if (count > arr.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", arr.Where(x => x % 2 == 0).Take(count))}]");
                            }
                        }
                        if (commandArgs[2] == "odd")
                        {
                            int count = int.Parse(commandArgs[1]);
                            if (count > arr.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", arr.Where(x => x % 2 != 0).Take(count))}]");
                            }
                        }
                        break;

                    case "last":
                        if (commandArgs[2] == "even")
                        {
                            int count = int.Parse(commandArgs[1]);
                            if (count <= 0 || count > arr.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                arr.Reverse();
                                Console.WriteLine($"[{string.Join(", ", arr.Where(x => x % 2 == 0).Take(count).Reverse())}]");
                                arr.Reverse();
                            }
                        }
                        if (commandArgs[2] == "odd")
                        {
                            int count = int.Parse(commandArgs[1]);
                            if (count <= 0 || count > arr.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                arr.Reverse();
                                Console.WriteLine($"[{string.Join(", ", arr.Where(x => x % 2 != 0).Take(count).Reverse())}]");
                                arr.Reverse();
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
    }
}
