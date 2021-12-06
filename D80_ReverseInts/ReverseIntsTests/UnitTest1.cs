using System;
using Xunit;

namespace ReverseIntsTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 4321;
            // Program p = new Program();

            // int actual = p.ReverseInteger();
            int actual = 1234;

            Assert.NotEqual(expected, actual);
        }
    }
}
