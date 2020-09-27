using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countSeason = int.Parse(Console.ReadLine());
            int countEpisode = int.Parse(Console.ReadLine());
            double timeForOneEp = double.Parse(Console.ReadLine());

            timeForOneEp *= 1.2;
            double moreTimeSpecEp = countSeason * 10;
            double totalTime = Math.Round(timeForOneEp * countEpisode * countSeason + moreTimeSpecEp);

            Console.WriteLine($"Total time needed to watch the {name} series is {totalTime} minutes.");
        }
    }
}