using System;

namespace Graduation2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countYears = 0;
            int yearStudy = 12;
            int countExcluded = 0;
            double sumEvaluation = 0;
            while (countYears < yearStudy)
            {
                double evaluation = double.Parse(Console.ReadLine());
                if (evaluation >= 4)
                {
                    sumEvaluation += evaluation;
                    countYears++;
                }
                else if (evaluation < 4)
                {
                    countExcluded++;
                    if (countExcluded > 1)
                    {
                        break;
                    }
                }
            }

            double averageEvaluation = sumEvaluation / yearStudy;
            if (countExcluded < 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageEvaluation:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {countYears + 1} grade");
            }
        }
    }
}