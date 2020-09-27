using System;

namespace Combination
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combination = 0;

            for (int x = 0; x <= n; x++)
            {
                for (int y = 0; y <= n; y++)
                {
                    for (int z = 0; z <= n; z++)
                    {
                        int result = x + y + z;
                        if (result == n)
                        {
                            combination++;
                        }
                    }
                }
            }
            Console.WriteLine(combination);
        }
    }
}