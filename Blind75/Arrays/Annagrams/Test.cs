using Blind75.Arrays.Annagrams;

public class Test
{
    [Fact]
    public void TestGroupAnagrams()
    {
        // Arrange
        var solution = new Solution();
        var input = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        var result = solution.GroupAnagrams(input);

        // Assert
        Assert.Equal(3, result.Count); // There are three groups

        // Each group's contents
        var group1 = new HashSet<string>(new[] { "eat", "tea", "ate" });
        var group2 = new HashSet<string>(new[] { "tan", "nat" });
        var group3 = new HashSet<string>(new[] { "bat" });

        foreach (var group in result)
        {
            if (group1.SetEquals(group)) continue;
            if (group2.SetEquals(group)) continue;
            if (group3.SetEquals(group)) continue;

            Assert.True(false, "Unexpected group found");
        }
    }
}
