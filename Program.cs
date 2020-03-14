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

            string[] allWords = words[..];
            string[] firsPhrase = words[..4];
            string[] lastPhrase = words[6..];
            
            Console.WriteLine();
            foreach(var word in allWords)
                Console.WriteLine($"< {word} >");
            Console.WriteLine();
            foreach(var word in firsPhrase)
                Console.WriteLine($"< {word} >");
            Console.WriteLine();
            foreach(var word in lastPhrase)
                Console.WriteLine($"< {word} >");

            Console.WriteLine();
            Index the = ^3;
            Console.WriteLine(words[the]);
            Range phrase = 6..;
            foreach(var word in words[phrase])
                Console.WriteLine($"< {word} >");
        }
    }
}
