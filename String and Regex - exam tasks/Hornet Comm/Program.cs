using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string broadcastPattern = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";
            string messagePattern = @"^([0-9]+) <-> ([A-Za-z0-9]+)$";

            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (text != "Hornet is Green")
            {
                var privateMessage = Regex.Match(text, messagePattern);
                var broadcast = Regex.Match(text, broadcastPattern);

                if (privateMessage.Success)
                {
                    string recipient = privateMessage.Groups[1].ToString();
                    recipient = string.Join("", recipient.ToCharArray().Reverse().ToArray());
                    messages.Add(recipient + " -> " + privateMessage.Groups[2].ToString());
                }
                if (broadcast.Success)
                {
                    string frequency = broadcast.Groups[2].ToString();
                    string frequencyResult = "";
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLower(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToUpper();
                        }
                        else if (char.IsUpper(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToLower();
                        }
                        else
                        {
                            frequencyResult += frequency[i].ToString();
                        }
                    }
                    broadcasts.Add(frequencyResult + " -> " + broadcast.Groups[1].ToString());
                }
                text = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in messages)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
