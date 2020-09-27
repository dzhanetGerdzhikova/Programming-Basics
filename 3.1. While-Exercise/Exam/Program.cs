using System;

namespace WhileExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int countBadGreat = 0;
            double sumGrade = 0;
            int countGrade = 0;
            string nameGrade = "";

            while (name != "Enough")
            {
                nameGrade = name;
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    countBadGreat++;
                }

                if (countBadGreat >= badGrade)
                {
                    Console.WriteLine($"You need a break, {countBadGreat} poor grades.");
                    break;
                }
                sumGrade += grade;
                countGrade++;
                name = Console.ReadLine();
            }

            if (name == "Enough")
            {
                Console.WriteLine($"Average score: {(sumGrade / countGrade):f2}");
                Console.WriteLine($"Number of problems: {countGrade}");
                Console.WriteLine($"Last problem: {nameGrade}");
            }
        }
    }
}