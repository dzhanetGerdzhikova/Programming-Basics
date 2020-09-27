using System;

namespace Sectors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char firstSectors = 'A';

            char lastSectors = char.Parse(Console.ReadLine());
            int countRowsInFirstSector = int.Parse(Console.ReadLine());
            int countPlacesOddRows = int.Parse(Console.ReadLine());
            int place = 0;

            for (char sectors = firstSectors; sectors <= lastSectors; sectors++)
            {
                for (int startsRows = 1; startsRows <= countRowsInFirstSector; startsRows++)
                {
                    if (startsRows % 2 == 1)
                    {
                        place = countPlacesOddRows;
                    }
                    else if (startsRows % 2 == 0)
                    {
                        place = countPlacesOddRows + 2;
                    }
                    for (char numPlace = 'a'; numPlace < 'a' + place; numPlace++)
                    {
                        Console.WriteLine($"{sectors}{startsRows}{numPlace}");
                    }
                }
                countRowsInFirstSector++;
            }
        }
    }
}