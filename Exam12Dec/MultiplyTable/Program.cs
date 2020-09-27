using System;

namespace MultiplyTable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = 1; i <= int.Parse(number[2].ToString()); i++)
            {
                for (int j = 1; j <= int.Parse(number[1].ToString()); j++)
                {
                    for (int k = 1; k <= int.Parse(number[0].ToString()); k++)
                    {
                        int result = k * j * i;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }
                }
            }
        }
    }
}