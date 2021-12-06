using System;
using Xunit;

// TODO the unit test orgnaziation (folder hierarchy, namespaces, ...) is work in progress.
// I am not sure if this has to in the same namespace or some other way of referencing it.
namespace ReverseIntsApp
{
    // 1st method: int ReverseInteger(int input)
    public class TestReverseInteger
    {
        [Fact]
        public void Test1()
        {
            // static method cant be accessed thru an object in C# (but it can in python)
            // Program p = new Program();

            int input = 1234;
            int expected = 4321;

            int actual = Program.ReverseInteger(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int input = 111;
            int expected = 111;

            int actual = Program.ReverseInteger(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test30()
        {
            int input = 111000;
            int expected = 111;

            int actual = Program.ReverseInteger(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test40()
        {
            int input = 1000090001;
            int expected = 1000900001;
            // 1000090001
            // 1000900001

            int actual = Program.ReverseInteger(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test41()
        {
            int input = 0;
            int expected = 0;

            int actual = Program.ReverseInteger(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test50()
        {
            // expecting exception
            int input = 2147483647;

            Assert.Throws<IrreversibleInt32Exception>(() => Program.ReverseInteger(input));
        }

        [Fact]
        public void Test60()
        {
            // expecting exception for 1_999_999_999
            int input = 1_999_999_999;

            Assert.Throws<IrreversibleInt32Exception>(() => Program.ReverseInteger(input));
        }

        [Fact]
        public void Test70()
        {
            // expecting exception for 1_999_999_999
            int input = 1000000003;

            Assert.Throws<IrreversibleInt32Exception>(() => Program.ReverseInteger(input));
        }

        [Fact]
        public void Test80()
        {
            // expecting exception for negative inputs
            int input = -324;

            Assert.Throws<IrreversibleInt32Exception>(() => Program.ReverseInteger(input));
        }

        [Fact]
        public void Test90()
        {
            // expecting exception for negative inputs
            int input = -1;

            Assert.Throws<IrreversibleInt32Exception>(() => Program.ReverseInteger(input));
        }
    }


    // 2nd method: int IsReverseInteger(int A, int B)
    public class TestIsReverseInteger
    {
        [Fact]
        public void Test1()
        {
            int a = 14;
            int b = 41;
            bool expected = true;
            bool actual = Program.IsReverseInteger(a, b);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test20()
        {
            int a = 14;
            int b = 4100;

            Assert.True(Program.IsReverseInteger(a, b));
        }

        [Fact]
        public void Test30()
        {
            int a = 12345;
            int b = 54321;

            Assert.True(Program.IsReverseInteger(a, b));
        }


        [Fact]
        public void Test40()
        {
            int a = 12345;
            int b = 99999;

            Assert.False(Program.IsReverseInteger(a, b));
        }

        [Fact]
        public void Test50()
        {
            // expecting exception for negative inputs
            int a = 12345;
            int b = -232;

            Assert.Throws<IrreversibleInt32Exception>(() => Program.IsReverseInteger(a, b));
        }

        [Fact]
        public void Test60()
        {
            // expecting exception for negative inputs
            int a = -12345;
            int b = -232;

            Assert.Throws<IrreversibleInt32Exception>(() => Program.IsReverseInteger(a, b));
        }
    }
}
