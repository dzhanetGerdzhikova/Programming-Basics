using System;

namespace LunchBreak
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double timeForEp = double.Parse(Console.ReadLine());
            double timePause = double.Parse(Console.ReadLine());

            double timeForLunch = (double)1 / 8 * (timePause);
            double timaForFreetime = (double)1 / 4 * (timePause);
            timePause -= timeForLunch + timaForFreetime;

            if (timePause >= timeForEp)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timePause - timeForEp)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeForEp - timePause)} more minutes.");
            }
        }
    }
}