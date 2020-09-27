using System;

namespace NameWars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int sumNum = 0;
            int maxNum = int.MinValue;
            string nameMax = "";

            while (name != "STOP")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    sumNum += (int)name[i];
                }
                if (sumNum > maxNum)
                {
                    maxNum = sumNum;
                    nameMax = name;
                }
                sumNum = 0;
                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {nameMax} - {maxNum}!");
        }
    }
}