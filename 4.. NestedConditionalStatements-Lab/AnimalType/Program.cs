using System;

namespace AnimalType
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string nameOfAnimal = Console.ReadLine();
            //if(nameOfAnimal=="dog")
            //{
            //    Console.WriteLine("mammal");
            //}
            //else if(nameOfAnimal=="crocodile"||nameOfAnimal=="tortoise"||nameOfAnimal=="snake")
            //{
            //    Console.WriteLine("reptile");
            //}
            //else
            //{
            //    Console.WriteLine("unknown");
            //}

            switch (nameOfAnimal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;

                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}