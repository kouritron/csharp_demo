using System;

namespace ReverseIntsApp
{
    class Program
    {
        public static bool IsReverseInteger(int A, int B)
        {
            int rev_A = ReverseInteger(A);
            int rev_B = ReverseInteger(B);

            if (rev_A == B || rev_B == A)
            {
                return true;
            }

            return false;
        }

        public static int ReverseInteger(int input)
        {
            // Assert is reversible, see discussion.txt
            if (input < 0)
            {
                throw new IrreversibleInt32Exception("Reversing negative number is not supported");
            }

            // reverse
            long result = 0;
            while (0 != input)
            {
                int digit = input % 10;
                input = input / 10;
                result *= 10;
                result += digit;
            }

            // check to see if result will fit in an int.
            if (result > int.MaxValue)
            {
                throw new IrreversibleInt32Exception($"{result} is too large to be stored in an int");
            }

            return (int)result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"int.MaxValue: {int.MaxValue}");

            int input = 1234;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");

            input = 3450;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");

            input = 98321;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");

            input = 111000;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");

            // should be ok.
            input = 1000090001;
            Console.WriteLine($"{input} --> {ReverseInteger(input)}");

            // see discussion.txt
            try
            {
                input = 2147483647;
                Console.WriteLine($"{input} --> {ReverseInteger(input)}");
            }
            catch
            {
                Console.WriteLine($"good catch for: {input}");
            }

            try
            {
                input = 1000000003;
                Console.WriteLine($"{input} --> {ReverseInteger(input)}");
            }
            catch (IrreversibleInt32Exception ex)
            {
                Console.WriteLine($"good catch for: {input} --- exception message: {ex}");
            }

            // ----- 2nd func
            if (IsReverseInteger(14, 41000))
            {
                Console.WriteLine("check");
            }

            if (IsReverseInteger(14, 41))
            {
                Console.WriteLine("check");
            }

            if (! IsReverseInteger(98321, 1000000001))
            {
                Console.WriteLine("check");
            }
            
            // IsReverseInteger(1000000003, 11);
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
