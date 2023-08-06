namespace Blind75.LinkedLists.LinkedListCycle;

public class Test
{
    /// <summary>
    /// 
    /// </summary>
    [Theory]
    [InlineData(1, new int[] { 3, 2, 0, -4 })]
    [InlineData(0, new int[] { 1, 2 })]
    [InlineData(-1, new int[] { 1 })]
    public void Should_DetectCycle(int pos, int[] nodes)
    {
        // seed the list nodes with the values of nodes array, and set the next node
        // to the next value in the array until the end of the array is reached

        if (nodes.Length == 0)
        {
            return;
        }

        var head = new ListNode(nodes[0]);
        var current = head;
        ListNode? cycleNode = null;
        for (int i = 1; i < nodes.Length; i++)
        {
            if (i == pos)
            {
                cycleNode = current;
            }
            current.next = new ListNode(nodes[i]);
            current = current.next;
        }

        if (cycleNode != null)
        {
            current.next = cycleNode;
        }

        var hasCycle = new Solution().HasCycle(head);
        Assert.Equal(pos > 0, hasCycle);
    }
}
