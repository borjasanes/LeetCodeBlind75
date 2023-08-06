namespace Blind75.Arrays.ContainsDuplicates;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var tmp = new HashSet<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!tmp.Contains(nums[i]))
            {
                tmp.Add(nums[i]);
                continue;
            }
            return true;

        }

        return false;
    }
}