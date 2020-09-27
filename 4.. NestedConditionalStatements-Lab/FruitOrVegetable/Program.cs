using System;

namespace FruitOrVegetable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string product = Console.ReadLine();

            //switch (product)
            //{
            //    case "banana":
            //    case "apple":
            //    case "kiwi":
            //    case "cherry":
            //    case "lemon":
            //    case "grapes":
            //        Console.WriteLine("fruit");
            //        break;
            //    case "tomato":
            //    case "cucumber":
            //    case "pepper":
            //    case "carrot":
            //        Console.WriteLine("vegetable");
            //        break;
            //    default:
            //        Console.WriteLine("unknown");
            //        break;

            //}
            if (product == "banana" || product == "apple" || product == "cherry" || product == "lemon" || product == "grapes" || product == "kiwi")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}