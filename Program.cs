using System;

namespace IndicesRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new String[]
            {
                "the",
                "quick",
                "brown",
                "fox",
                "jumped",
                "over",
                "the",
                "lazy",
                "dog"
            };

            Console.WriteLine(words[^1]);
            string[] quickBrownFox = words[1..4];
            foreach(var word in quickBrownFox)
                Console.WriteLine($"< {word} >");

            Console.WriteLine();
            string[] lazyDog = words[^2..^0];
            foreach(var word in lazyDog)
                Console.WriteLine($"< {word} >");
        }
    }
}
