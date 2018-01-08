using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Football_Standing
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            var scoreboard = new Dictionary<string, List<long>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "final")
            {
                var tokens = input.Split(' ');
                string cryptedHomeTeam = tokens[0];
                int startIndex = cryptedHomeTeam.IndexOf(key);
                int endIndex = cryptedHomeTeam.LastIndexOf(key);
                string homeTeam = cryptedHomeTeam.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] homeTeamArray = homeTeam.ToUpper().ToCharArray();
                Array.Reverse(homeTeamArray);
                homeTeam = new string(homeTeamArray);

                string cryptedAwayTeam = tokens[1];
                startIndex = cryptedAwayTeam.IndexOf(key);
                endIndex = cryptedAwayTeam.LastIndexOf(key);
                string awayTeam = cryptedAwayTeam.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] awayTeamArray = awayTeam.ToUpper().ToCharArray();
                Array.Reverse(awayTeamArray);
                awayTeam = new string(awayTeamArray);

                long[] goals = tokens[2].Split(':').Select(long.Parse).ToArray();
                long homeTeamGoals = goals[0];
                long awayTeamGoals = goals[1];

                long homeTeamPoints;
                long awayTeamPoints;

                if (homeTeamGoals > awayTeamGoals)
                {
                    homeTeamPoints = 3;
                    awayTeamPoints = 0;
                }
                else if (homeTeamGoals < awayTeamGoals)
                {
                    homeTeamPoints = 0;
                    awayTeamPoints = 3;
                }
                else
                {
                    homeTeamPoints = 1;
                    awayTeamPoints = 1;
                }

                if (scoreboard.ContainsKey(homeTeam))
                {
                    scoreboard[homeTeam][0] += homeTeamPoints;
                    scoreboard[homeTeam][1] += homeTeamGoals;
                }
                else
                {
                    scoreboard[homeTeam] = new List<long>();
                    scoreboard[homeTeam].Add(homeTeamPoints);
                    scoreboard[homeTeam].Add(homeTeamGoals);
                }

                if (scoreboard.ContainsKey(awayTeam))
                {
                    scoreboard[awayTeam][0] += awayTeamPoints;
                    scoreboard[awayTeam][1] += awayTeamGoals;
                }
                else
                {
                    scoreboard[awayTeam] = new List<long>();
                    scoreboard[awayTeam].Add(awayTeamPoints);
                    scoreboard[awayTeam].Add(awayTeamGoals);
                }
            }
            Console.WriteLine("League standings:");
            int counter = 1;

            foreach (var pair in scoreboard.OrderByDescending(t => t.Value[0]).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{counter}. {pair.Key} {pair.Value[0]}");
                counter++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in scoreboard.OrderByDescending(t => t.Value[1]).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value[1]}");
            }
        }
    }
}
