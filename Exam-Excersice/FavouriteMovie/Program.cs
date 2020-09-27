using System;

namespace FavouriteMovie
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string nameMovie = Console.ReadLine();

            int counter = 0;
            int max = int.MinValue;
            string bestMovie = "";

            while (nameMovie.ToUpper() != "STOP")
            {
                counter++;
                int totalSum = 0;

                for (int i = 0; i < nameMovie.Length; i++)
                {
                    int sumNumber = 0;
                    if (nameMovie[i] >= 'A' && nameMovie[i] <= 'Z')
                    {
                        sumNumber = (int)nameMovie[i] - nameMovie.Length;
                    }
                    else if (nameMovie[i] >= 'a' && nameMovie[i] <= 'z')
                    {
                        sumNumber = (int)nameMovie[i] - (2 * nameMovie.Length);
                    }
                    else
                    {
                        sumNumber = (int)nameMovie[i];
                    }
                    totalSum += sumNumber;
                }
                if (totalSum > max)
                {
                    max = totalSum;
                    bestMovie = nameMovie;
                }
                if (counter >= 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
                nameMovie = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {max} ASCII sum.");
        }
    }
}