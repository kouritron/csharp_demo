using System;

namespace LangBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- do some string manipulation
            string sentence = "red plus green is yellow";
            StringReversor sr = new StringReversor(sentence);
            Console.WriteLine($"Original: {sentence}");
            Console.WriteLine($"Reversed: {sr.getReverse()}");

            // another one
            sentence = "Does polynomial time verifiability mean polynomial solutions exists also?? unlikely";
            sr = new StringReversor(sentence);
            Console.WriteLine($"Original: {sentence}");
            Console.WriteLine($"Reversed: {sr.getReverse()}");

            // ---------- TODO implement BFS and DFS, how would we represent adjacency list in C# ....
            

        }
    }
}
