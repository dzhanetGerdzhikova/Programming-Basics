using System;

namespace Cake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int volume = width * lenght;

            string input = Console.ReadLine();
            int sumCountPieces = 0;

            while (input != "STOP")
            {
                int countPiece = int.Parse(input);
                sumCountPieces += countPiece;

                if (sumCountPieces > volume)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (sumCountPieces >= volume)
            {
                Console.WriteLine($"No more cake left! You need {sumCountPieces - volume} pieces more.");
            }
            else
            {
                Console.WriteLine($"{volume - sumCountPieces} pieces are left.");
            }
        }
    }
}