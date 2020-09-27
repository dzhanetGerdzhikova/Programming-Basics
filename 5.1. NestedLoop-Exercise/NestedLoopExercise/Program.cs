using System;

namespace NestedLoopExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int colums = 1; colums <= rows; colums++)
                {
                    Console.Write(num + " ");

                    num++;

                    if (num > n)
                    {
                        break;
                    }
                }
                if (num > n)
                {
                    break;
                }
                Console.WriteLine("");
            }
        }
    }
}