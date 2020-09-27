using System;

namespace Spaceship
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double hidhtAstronaft = double.Parse(Console.ReadLine());

            double volumeRacket = widht * lenght * hight;
            double volumeRoom = (hidhtAstronaft + 0.40) * 2 * 2;//1
            double countRooms = Math.Floor(volumeRacket / volumeRoom);

            if (countRooms >= 3 && countRooms <= 10)
            {
                Console.WriteLine($"The spacecraft holds {countRooms} astronauts.");
            }
            else if (countRooms < 3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}