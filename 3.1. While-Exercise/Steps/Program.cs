using System;

namespace OldLibrary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sumSteps = 0;

            while (sumSteps < 10000)
            {
                string comand = Console.ReadLine();
                if (comand == "Going home")
                {
                    int stepsHome = int.Parse(Console.ReadLine());
                    sumSteps += stepsHome;

                    if (sumSteps < 10000)
                    {
                        Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
                        break;
                    }
                }
                else
                {
                    int comandSteps = int.Parse(comand);
                    sumSteps += comandSteps;
                }
            }

            if (sumSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}