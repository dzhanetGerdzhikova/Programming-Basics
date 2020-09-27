using System;

namespace LoopExcersices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumSteps = 0;

            while (input != "Going home")
            {
                int steps = int.Parse(input);
                sumSteps += steps;
                if (sumSteps >= 10000)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (sumSteps < 10000)
            {
                int stepsHome = int.Parse(Console.ReadLine());
                sumSteps += stepsHome;

                if (sumSteps < 10000)
                {
                    int moreSteps = 10000 - sumSteps;
                    Console.WriteLine($"{moreSteps} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}