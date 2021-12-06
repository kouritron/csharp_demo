using System;

namespace ReverseIntsApp
{
    class Program
    {

        private static bool isReversible(int input)
        {
            return false;
        }

        // -------------------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------- exports
        public static bool IsReverseInteger(int A, int B)
        {
            return false;
        }

        public static int ReverseInteger(int input)
        {

            // TODO: assert is reversible


            // reverse
            int result = 0;
            while (0 != input)
            {
                int digit = input % 10;
                input = input / 10;
                result *= 10;
                result += digit;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int input = 1234;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");
            
            input = 3450;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");
            
            input = 98321;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");
            
            input = 111000;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");
        }
    }

    // -----------------------------------------------------------------------------------------------------------------
    // ------------------------------------------------------------------------------------------------------ exceptions
    public class IrreversibleInt32Exception : Exception
    {
        public IrreversibleInt32Exception()
        {
        }

        public IrreversibleInt32Exception(string message) : base(message)
        {
        }
    }


}
