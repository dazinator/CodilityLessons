using System;
using Xunit;
using Xunit.Abstractions;

namespace CyclicRotation.Tests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;
        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        // [InlineData(null, 1, null)]
        // [InlineData(new int[] { }, 1, new int[] { })]
        // [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
        // [InlineData(new int[] { 1, 2 }, 0, new int[] { 1, 2 })]
        // [InlineData(new int[] { 1, 2 }, 2, new int[] { 1, 2 })]
        // [InlineData(new int[] { 1, 2, 3 }, 1, new int[] { 3, 1, 2 })]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]

        public void Test(int[] array, int numberOfRotations, int[] expected)
        {
            var solution = new Solution();
            var answer = solution.solution(array, numberOfRotations);
            Assert.Equal(expected, answer);
        }

        private void WriteOutput(string binary)
        {
            this.output.WriteLine(binary);
        }
    }
}
