using System;

namespace ForLoopExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //for (int i = 7; i < 1000; i+=10)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 7; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}