using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            int timeToFilterEvereyPicture = int.Parse(Console.ReadLine());
            int percentOfGoodPictures = int.Parse(Console.ReadLine());
            int timeForUploadAPicture = int.Parse(Console.ReadLine());

            var filteredPictures = Math.Ceiling(numberOfPictures * (percentOfGoodPictures / 100D));

            var timeFilter = numberOfPictures * (long)timeToFilterEvereyPicture;
            var timeUpload = filteredPictures * (long)timeForUploadAPicture;

            var totalTimeInSeconds = timeFilter + timeUpload;

            Console.WriteLine(TimeSpan.FromSeconds(totalTimeInSeconds).ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
