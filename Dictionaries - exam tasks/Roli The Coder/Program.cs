using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Roli_The_Coder
{
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }

        public Event(string name, List<string> participants)
        {
            Name = name;
            Participants = participants;    
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Event> dict = new Dictionary<int, Event>();
            Regex regex = new Regex(@"^(?<id>\d+)\s*#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-z\d'-]+\s*)*)$");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }

                Match eventMatch = regex.Match(input);
                if (!eventMatch.Success)
                {
                    continue;
                }

                int id = int.Parse(eventMatch.Groups["id"].Value);
                string eventName = eventMatch.Groups["eventName"].Value;

                List<string> participants = eventMatch.Groups["participants"].Value
                    .Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (!dict.ContainsKey(id))
                {
                    dict.Add(id, new Event(eventName, participants));
                }
                else if (dict[id].Name == eventName)
                {
                    dict[id].Participants.AddRange(participants);
                    dict[id].Participants = dict[id].Participants.Distinct().ToList();
                }

            }
            foreach (var item in dict.OrderByDescending(e => e.Value.Participants.Count).ThenBy(e => e.Value.Name))
            {
                Console.WriteLine($"{item.Value.Name} - {item.Value.Participants.Count}");
                foreach (var p in item.Value.Participants.OrderBy(p => p))
                {
                    Console.WriteLine(p);  
                }
            }
        }
    }
}
