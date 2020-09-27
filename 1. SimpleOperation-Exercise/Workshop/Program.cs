using System;

namespace Workshop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int table = int.Parse(Console.ReadLine());//5
            Double lenght = double.Parse(Console.ReadLine());//1.00
            double width = Double.Parse(Console.ReadLine());//0.50

            Double tableClothArea = table * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            double quadsArea = table * (lenght / 2) * (lenght / 2);
            double priceUSD = tableClothArea * 7 + quadsArea * 9;
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine($"{priceUSD:f2} USD");
            Console.WriteLine($"{priceBGN:f2} BGN");
        }
    }
}