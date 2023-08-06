namespace Blind75.LinkedLists.MergeTwoSortedLists;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null) return list2;
        else if (list2 == null) return list1;

        ListNode head = list1;
        if (list1.val > list2.val)
        {
            head = list2;
            list2 = list2.next;
        }
        else list1 = list1.next;

        ListNode tail = head;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }
        tail.next = list1 ?? list2;
        return head;
    }
}