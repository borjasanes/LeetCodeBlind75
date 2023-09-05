using Xunit;

namespace Blind75.TwoPointers.ValidPalindrome;

public class SolutionTests
{
    [Theory]
    [InlineData("racecar", true)] // Palindrome
    [InlineData("A man a plan a canal: Panama", true)] // Palindrome (ignores spaces and case)
    [InlineData("hello", false)] // Not a palindrome
    [InlineData("12321", true)] // Palindrome (numbers)
    [InlineData("race car", true)] // Palindrome (with space)
    [InlineData("Was it a car or a cat I saw?", true)] // Palindrome (ignores spaces and punctuation)
    [InlineData("No lemon, no melon", true)] // Palindrome (ignores spaces and punctuation)
    [InlineData("", true)] // Empty string is considered a palindrome
    [InlineData("0P", false)]
    public void IsPalindrome_ValidInput_ReturnsExpectedResult(string input, bool expectedResult)
    {
        // Arrange
        var solution = new Solution();

        // Act
        bool result = solution.IsPalindrome(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
