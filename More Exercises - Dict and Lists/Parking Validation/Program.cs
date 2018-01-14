using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                var tokens = input.Split();
                string command = tokens[0];
                string user = string.Empty;
                string ticket = string.Empty;

                string pattern = @"(\b[A-Z]{2}[0-9]{4}[A-Z]{2}\b)";
                if (command == "register")
                {
                    user = tokens[1];
                    ticket = tokens[2];
                    if (Regex.IsMatch(ticket, pattern))
                    {
                        if (!data.ContainsKey(user) && !data.ContainsValue(ticket))
                        {
                            data[user] = ticket;
                            Console.WriteLine($"{user} registered {ticket} successfully");
                        }
                        else if (data.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {ticket}");
                        }
                        else if (data.ContainsValue(ticket))
                        {
                            Console.WriteLine($"ERROR: license plate {ticket} is busy");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {ticket}");
                    }
                }
                else if (command == "unregister")
                {
                    user = tokens[1];
                    if (!data.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        data.Remove(user);
                        Console.WriteLine($"user {user} unregistered successfully");
                    }
                }
            }
            foreach (var user in data)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
