using System;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            bool isNumberMagic = false;
            for (int x = startNumber; x <= finalNumber; x++)
            {
                for (int y = startNumber; y <= finalNumber; y++)
                {
                    int result = x + y;
                    combination++;

                    if (result == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({x} + {y} = {magicNumber})");
                        isNumberMagic = true;
                        break;
                    }
                }

                if (isNumberMagic)
                {
                    break;
                }
            }
            //if (!isNumberMagic)
            //{
            //    Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            //}
        }
    }
}