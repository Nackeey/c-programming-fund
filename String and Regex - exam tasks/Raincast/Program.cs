using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePattern = "^Type: (Normal|Warning|Danger)$";
            string sourcePattern = "^Source: ([a-zA-Z0-9]+)$";
            string forecastPattern = "^Forecast: ([^!.,?]+)$";

            var forecasts = new List<string>();

            string currentForecast = string.Empty;
            string currentSearch = "type";

            string input = Console.ReadLine();

            while (input != "Davai Emo")
            {
                switch (currentSearch)
                {
                    case "type":
                        if (Regex.IsMatch(input, typePattern))
                        {
                            currentForecast = $"({Regex.Match(input, typePattern).Groups[1]})";
                            currentSearch = "source";
                        }
                        break;
                    case "source":
                        if (Regex.IsMatch(input, sourcePattern))
                        {
                            currentForecast += " " + "***" + " ~ " + $"{Regex.Match(input, sourcePattern).Groups[1]}";
                            currentSearch = "forecast";
                        }
                        break;
                    case "forecast":
                        if (Regex.IsMatch(input, forecastPattern))
                        {
                            currentForecast = currentForecast.Replace("***", Regex.Match(input, forecastPattern).Groups[1].Value);
                            forecasts.Add(currentForecast);
                            currentSearch = "type";
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var forecast in forecasts)
            {
                Console.WriteLine(forecast);
            }
        }
    }
}
