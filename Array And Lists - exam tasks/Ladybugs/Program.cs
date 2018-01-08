    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Ladybugs
    {
        class Program
        {
            static void Main(string[] args)
            {
                int fieldLenght = int.Parse(Console.ReadLine());
                var field = new int[fieldLenght];
                var ladybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int i = 0; i < field.Length; i++)
                {
                    for (int j = 0; j < ladybugs.Length; j++)
                    {
                        if (i == ladybugs[j])
                        {
                            field[i] = 1;
                        }
                    }
                }

                string commands = string.Empty;
                while ((commands = Console.ReadLine()) != "end")
                {
                    var commandArgs = commands.Split().ToArray();
                    int index = int.Parse(commandArgs[0]);
                    string direction = commandArgs[1];
                    long flyLength = long.Parse(commandArgs[2]);

                    if (index < 0 || index > field.Length - 1
                        || field[index] == 0 || flyLength == 0)
                    {
                        continue;
                    }
                    
                    field[index] = 0;

                    if (direction == "right")
                    {
                        FlyRight(field, index, flyLength);
                    }
                    else if (direction == "left")
                    {
                        FlyLeft(field, index, flyLength);
                    }
                }
                Console.WriteLine(string.Join(" ", field));
            }

            private static void FlyLeft(int[] field, int index, long flyLength)
            {
                for (int i = 1; i <= index + 1; i++)
                {
                    var flightDistance = i * flyLength;
                    if (index - flightDistance < 0)
                    {
                        break;
                    }
                    if (field[index - flightDistance] == 0)
                    {
                        field[index - flightDistance] = 1;
                        break;
                    }
                }
            }

            private static void FlyRight(int[] field, int index, long flyLength)
            {
                for (int i = 1; i < field.Length - index; i++)
                { 
                    var flightDistance = i * flyLength;
                    if (index + flightDistance > field.Length - 1)
                    {
                        break;
                    }
                    if (field[index + flightDistance] == 0)
                    {
                        field[index + flightDistance] = 1;
                        break;
                    }
                }
            }
        }
    }
