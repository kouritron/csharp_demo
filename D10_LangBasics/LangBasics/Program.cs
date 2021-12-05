using System;

namespace LangBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "red plus green is yellow";
            StringReversor sr = new StringReversor(sentence);
            Console.WriteLine($"Original: {sentence}");
            Console.WriteLine($"Reversed: {sr.getReverse()}");

            // another one
            sentence = "Does polynomial time verifiability mean polynomial solutions exists also?? unlikely";
            sr = new StringReversor(sentence);
            Console.WriteLine($"Original: {sentence}");
            Console.WriteLine($"Reversed: {sr.getReverse()}");

        }
    }
}
