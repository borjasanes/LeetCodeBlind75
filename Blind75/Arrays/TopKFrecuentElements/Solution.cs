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

        var pq = new PriorityQueue<int, int>();
        foreach (int key in frequency.Keys)
        {
            pq.Enqueue(key, frequency[key]);

            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        var result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}