using System;

namespace Graduation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double countEvaluation = 12;
            double sumEvaluation = 0.00;
            double averageGrade = 0.00;

            while (countEvaluation > 0)
            {
                double evaluation = double.Parse(Console.ReadLine());
                if (evaluation >= 4)
                {
                    countEvaluation--;
                    sumEvaluation += evaluation;
                }
            }
            averageGrade = sumEvaluation / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}