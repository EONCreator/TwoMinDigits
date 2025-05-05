namespace TwoMinDigits.Tests
{
    public class TwoMinDigitsTests
    {
        [Fact]
        public void TwoMin_WithValidArray_ReturnsCorrectMinValues()
        {
            var result = TwoMinCalculator.SumOfTwoMin(new [] { -4, 9, 1, 2, 6, 3, 7 });
            Assert.Equal(-3, result);
        }

        [Fact]
        public void TwoMin_WithDuplicates_ReturnsCorrectMinValues()
        {
            var result = TwoMinCalculator.SumOfTwoMin(new [] { 7, 1, 1, 7, 10 });
            Assert.Equal(2, result);
        }

        [Fact]
        public void TwoMin_WithAllPositiveNumbers_ReturnsCorrectMinValues()
        {
            var result = TwoMinCalculator.SumOfTwoMin(new [] { 3, 8, 5, 1, 4 });
            Assert.Equal(4, result);
        }

        [Fact]
        public void TwoMin_WithAllNegativeNumbers_ReturnsCorrectMinValues()
        {
            var result = TwoMinCalculator.SumOfTwoMin(new[] { -3, -8, -5, -1, -4 });
            Assert.Equal(-13, result);
        }

        [Fact]
        public void TwoMin_WithTwoElements_ReturnsSumOfTwoValues()
        {
            var result = TwoMinCalculator.SumOfTwoMin(new [] { 1, 2 });
            Assert.Equal(3, result);
        }

        [Fact]
        public void TwoMin_WithEmptyArray_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => TwoMinCalculator.SumOfTwoMin(new int[] { }));
        }
    }
}
