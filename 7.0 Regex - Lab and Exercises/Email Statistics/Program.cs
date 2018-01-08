using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(?<username>[A-Za-z]{5,}(?=[@]))@(?<domain>(?<=[@])[a-z]{3,}[.](com|bg|org))$");

            Dictionary<string, HashSet<string>> data = new Dictionary<string, HashSet<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string email = Console.ReadLine();
                Match match = regex.Match(email);
                if (match.Success)
                {
                    string user = match.Groups["username"].Value;
                    string domain = match.Groups["domain"].Value;
                    if (!data.ContainsKey(domain))
                    {
                        data.Add(domain, new HashSet<string>());
                    }
                        data[domain].Add(user);
                }
            }
            foreach (var domain in data.OrderByDescending(d => d.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");
                foreach (var user in domain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
