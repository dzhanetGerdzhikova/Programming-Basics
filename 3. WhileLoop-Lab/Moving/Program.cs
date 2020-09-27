using System;

namespace Moving
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hidht = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int freeSpace = weight * lenght * hidht;

            while (command != "Done")
            {
                int box = int.Parse(command);
                if (freeSpace >= box)
                {
                    freeSpace -= box;
                }
                else
                {
                }
                command = Console.ReadLine();
            }

            int neededSpace = freeSpace - sumBox;
            Console.WriteLine(neededSpace);

            if (command == "Done")
            {
                if (freeSpace > sumBox)
                {
                    Console.WriteLine($"{freeSpace - sumBox} Cubic meters left");
                }
                else
                {
                }
            }
        }
    }
}