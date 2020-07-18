using System;
using Xunit;
using Xunit.Abstractions;

namespace BinaryGap.Tests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;
        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        [InlineData(1041, 5)]
        [InlineData(328, 2)]
        public void Can_Calculate_Longest_Binary_Gap(int n, int expected)
        {
            var solution = new Solution();
            var answer = solution.solution(n);
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData("100", 0)]
        [InlineData("101", 1)]
        [InlineData("111", 0)]
        [InlineData("101001000", 2)]
        [InlineData("1010010001", 3)]
        [InlineData("000", 0)]
        public void Can_Calculate_Longest_Binary_Gap_From_BinaryString(string binary, int expected)
        {
            var solution = new Solution();
            var answer = solution.GetLongestBinaryGap(binary);
            Assert.Equal(expected, answer);
        }

        private void WriteOutput(string binary)
        {
            this.output.WriteLine(binary);
        }
    }
}
