
using System;

namespace HelloApp {
    public class HelloWorld {
        static void Main(string[] args) {
            Console.WriteLine("Hello Mono");
            Console.WriteLine("System.Environment.Version: " + System.Environment.Version);
            Console.WriteLine($"System.Environment.OSVersion: {System.Environment.OSVersion}");
        }
    }
}
