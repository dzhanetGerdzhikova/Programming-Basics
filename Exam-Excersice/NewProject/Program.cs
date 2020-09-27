using System;

namespace NewProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int points = 0;
            int sumPoints = 0;
            int max = int.MinValue;
            string winner = "";
            string name = Console.ReadLine();

            while (name != "Stop")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num == (int)name[i])
                    {
                        points = 10;
                    }
                    else
                    {
                        points = 2;
                    }
                    sumPoints += points;
                }

                if (sumPoints >= max)
                {
                    max = sumPoints;
                    winner = name;
                }
                sumPoints = 0;
                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winner} with {max} points!");
        }
    }
}