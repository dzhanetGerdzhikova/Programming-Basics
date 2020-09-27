using System;

namespace WhileExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string bookSearch = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int numBook = 0;
            bool bookIsFound = false;

            while (numBook < count)
            {
                numBook++;
                string bookName = Console.ReadLine();

                if (bookSearch == bookName)
                {
                    bookIsFound = true;
                    break;
                }
            }

            if (bookIsFound)
            {
                Console.WriteLine($"You checked {numBook - 1} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numBook} books.");
            }
        }
    }
}