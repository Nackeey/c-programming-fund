using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercises_03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToSkip = data[0];
            int elementsToTake = data[1];

            string text = Console.ReadLine();

            Regex cameraGroups = new Regex(@"\|<(\w{" + elementsToSkip + @"})(\w{0," + elementsToTake + @"})");
            MatchCollection result = cameraGroups.Matches(text);

            List<string> pics = new List<string>();

            foreach (Match camera in result)
            {
                pics.Add(camera.Groups[2].Value.ToString());
            }
            Console.WriteLine(string.Join(", ", pics));
        }
    }
}
