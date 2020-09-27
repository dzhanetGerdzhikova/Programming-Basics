using System;

namespace DanceHall
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Double L = double.Parse(Console.ReadLine());//50
            Double W = double.Parse(Console.ReadLine());//25
            Double A = double.Parse(Console.ReadLine());//2

            double hallArea = (L * 100) * (W * 100);
            double wardrobеArea = (A * 100) * (A * 100);
            double benchArea = hallArea / 10;
            double freeSpace = hallArea - wardrobеArea - benchArea;
            double dancer = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(dancer));
        }
    }
}