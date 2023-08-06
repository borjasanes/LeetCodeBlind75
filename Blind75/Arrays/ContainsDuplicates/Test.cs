namespace Blind75.Arrays.ContainsDuplicates;

public class Test
{
    [Fact]
    public void Should_ReturnFalse_When_NoDuplicatesInArray()
    {
        var solution = new Solution();
        int[] nums = new[] { 1, 2, 3, 4, 5 };

        bool result = solution.ContainsDuplicate(nums);

        Assert.False(result);
    }

    [Fact]
    public void Should_ReturnTrue_When_DuplicatesInArray()
    {
        var solution = new Solution();
        int[] nums = new[] { 1, 2, 2, 3, 4 };

        bool result = solution.ContainsDuplicate(nums);

        Assert.True(result);
    }

    [Fact]
    public void Should_ReturnFalse_When_ArrayIsEmpty()
    {
        var solution = new Solution();
        int[] nums = new int[0];

        bool result = solution.ContainsDuplicate(nums);

        Assert.False(result);
    }

    [Theory]
    [InlineData(new[] { 1, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, false)]
    public void Should_ReturnExpected_When_VariousArrays(int[] nums, bool expected)
    {
        var solution = new Solution();

        bool result = solution.ContainsDuplicate(nums);

        Assert.Equal(expected, result);
    }
}
