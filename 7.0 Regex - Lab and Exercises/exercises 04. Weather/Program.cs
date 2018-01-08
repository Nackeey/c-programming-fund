using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercises_04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<city>[A-Z]{2})(?<degree>\d*\.\d*)(?<type>[A-z]{1,})\|";
            Dictionary<string, Dictionary<double, string>> info = new Dictionary<string, Dictionary<double, string>>();

            string input = Console.ReadLine();
            while (input != "end")
            {

                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match data in matches)
                {
                    var city = data.Groups["city"].Value.ToString();
                    double degrees = double.Parse(data.Groups["degree"].Value);
                    var wheather = data.Groups["type"].Value.ToString();

                    if (info.ContainsKey(city))
                    {
                        info.Remove(city);
                    }
                    if(!info.ContainsKey(city))
                    {
                        info.Add(city, new Dictionary<double, string>());
                    }
                        info[city].Add(degrees, wheather);

                }
                input = Console.ReadLine();
            }

            foreach (var data in info.OrderBy(x => x.Value.Keys.Average()))
            {
                var city = data.Key;
                Dictionary<double, string> moreData = data.Value;

                foreach (var item in moreData)
                {
                    double degree = item.Key;
                    var wheatherType = item.Value;

                    Console.WriteLine("{0} => {1:f2} => {2}", city, degree, wheatherType);
                }
            }
        }
    }
}
