using System;

namespace ForLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countFilms = int.Parse(Console.ReadLine());

            double maxRating = double.MinValue;
            string nameMax = "";
            double minRating = double.MaxValue;
            string nameMin = "";
            double sumRating = 0;
            int countFilm = 0;

            for (int i = 1; i <= countFilms; i++)
            {
                string name = Console.ReadLine();
                countFilm++;
                double raiting = double.Parse(Console.ReadLine());
                sumRating += raiting;

                if (raiting > maxRating)
                {
                    maxRating = raiting;
                    nameMax = name;
                }
                else if (raiting < minRating)
                {
                    minRating = raiting;
                    nameMin = name;
                }
            }
            double averageRaiting = sumRating / countFilm;

            Console.WriteLine($"{nameMax} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{nameMin} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRaiting:f1}");
        }
    }
}