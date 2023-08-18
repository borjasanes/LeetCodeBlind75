namespace Blind75.Arrays.TopKFrecuentElements;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequency = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (frequency.TryGetValue(num, out int count))
            {
                frequency[num] = count + 1;
            }
            else
            {
                frequency[num] = 1;
            }
        }
        var sortedList = new List<KeyValuePair<int, int>>(frequency);
        sortedList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

        var result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = sortedList[i].Key;
        }

        return result;
    }
}