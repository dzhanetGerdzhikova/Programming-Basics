﻿using System;

namespace WhileLoopLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}