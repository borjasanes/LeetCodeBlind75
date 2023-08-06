using Xunit;

namespace Blind75.Arrays.ValidAnagram;

public class Test
{
    [Fact]
    public void Should_ReturnTrue_When_IsAnagram()
    {
        var solution = new Solution();
        var str1 = "anagram";
        var str2 = "nagaram";

        var result = solution.IsAnagram(str1, str2);

        Assert.True(result);
    }

    [Fact]
    public void Should_ReturnFalse_When_IsNotAnagram()
    {
        var solution = new Solution();
        var str1 = "hello";
        var str2 = "world";

        var result = solution.IsAnagram(str1, str2);

        Assert.False(result);
    }

    [Fact]
    public void Should_ReturnFalse_When_DifferentLengths()
    {
        var solution = new Solution();
        var str1 = "abc";
        var str2 = "abcd";

        var result = solution.IsAnagram(str1, str2);

        Assert.False(result);
    }

    [Fact]
    public void Should_ReturnTrue_When_EmptyStrings()
    {
        var solution = new Solution();
        var str1 = "";
        var str2 = "";

        var result = solution.IsAnagram(str1, str2);

        Assert.True(result);
    }
}
