﻿using System;

namespace SimpleOperation_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bg = usd * 1.79549;
            Console.WriteLine($"{bg:F2}");

        }
    }
}
