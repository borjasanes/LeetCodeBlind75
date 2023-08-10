
namespace Blind75.Arrays.TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j) continue;

                if (nums[i] + nums[j] == target)
                {
                    return new int[2] { i, j };
                }
            }
        }
        return Array.Empty<int>();
    }
}