using System;

namespace ExamExcersice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double baklavaPrice = double.Parse(Console.ReadLine());
            double muffinPrice = double.Parse(Console.ReadLine());
            double schtolenKg = double.Parse(Console.ReadLine());
            double bonbonKg = double.Parse(Console.ReadLine());
            double sweetsKg = double.Parse(Console.ReadLine());

            double schtolenPrice = baklavaPrice * 1.6;
            double bonbonPrice = muffinPrice * 1.8;
            double sweetsPrice = 7.50;

            double totalPrice = schtolenKg * schtolenPrice + bonbonKg * bonbonPrice + sweetsKg * sweetsPrice;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}