using System;
using System.Diagnostics;

namespace laba2._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product cake = new Cake("Chocolate","fresh", 1653);
            Item flower = new Flower("Rose", "Red", 240);
            Product candies = new Candies("Lollipop","Step",  9);
            Item watch = new Watch("Rolex","SilverEdition", 43999);

            Object[] objects = {cake, flower, candies, watch};

            foreach (var i in objects)
            {
                Console.WriteLine(i);
            }

        }
    }
}