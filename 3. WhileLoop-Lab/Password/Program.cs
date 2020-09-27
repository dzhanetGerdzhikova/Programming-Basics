using System;

namespace Password
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            string typedPassword = Console.ReadLine();
            while (typedPassword != password)
            {
                typedPassword = Console.ReadLine();
            }
            Console.WriteLine("Welcome " + name + "!");
        }
    }
}