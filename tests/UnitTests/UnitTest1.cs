using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           double a = 70;
           double b = 10;
           double expected = 7;
           double actual = percent(a,b);
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(10,100,10)]
        [InlineData(2,100,2)]
        [InlineData(25, 50, 50)]

        public void Test(double expected, double a,double b)
        {
            Assert.Equal(expected, percent(a, b));
        }
        public double percent(double input, double percentage)
        {
            return (input*(percentage/100));
        }
    }
}
