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
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XIV", 14)]
        [InlineData("XIX", 19)]
        [InlineData("XX", 20)]
        public void ConvertToNumber_RomanNumber_ShouldReturnsValue(string romanNumber, int expected)
        {
            int result = subject.ConvertToNumber(romanNumber);
            result.Should().Be(expected);
        }
    }
}
