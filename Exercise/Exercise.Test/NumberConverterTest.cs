using FluentAssertions;
using Xunit;

namespace Exercise.Test
{
    public class NumberConverterTest
    {
        private NumberConverter subject;
        public NumberConverterTest()
        {
            subject = new NumberConverter();
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XIV", 14)]
        [InlineData("XIX", 19)]
        [InlineData("XXXIV", 34)]
        [InlineData("XXXIX", 39)]
        [InlineData("XLIV", 44)]
        [InlineData("XC", 90)]
        [InlineData("CD", 400)]
        //[InlineData("CMXLIX", 949)]

        public void ConvertToNumber_RomanNumber_ShouldReturnsValue(string romanNumber, int expected)
        {
            int result = subject.ConvertToNumber(romanNumber);
            result.Should().Be(expected);
        }
    }
}
