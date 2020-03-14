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
        }
    }
}
