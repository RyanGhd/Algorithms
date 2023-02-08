// ReSharper disable All
namespace Algorithms;

/// <summary>
/// question: https://leetcode.com/problems/add-two-numbers/description/
/// solution: https://leetcode.com/problems/add-two-numbers/solutions/127833/add-two-numbers/
/// Time complexity : O(max⁡(m,n))
/// Space complexity : O(max⁡(m,n))
/// </summary>
public class Add_Two_Numbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var resultRoot = new ListNode();

        if (l1 == null && l2 == null) return resultRoot;
        else if (l1 == null) return l2;
        else if (l2 == null) return l1;

        ListNode? n1 = l1, n2 = l2, result = resultRoot;

        int extra = 0;
        while (n1 != null || n2 != null || extra > 0)
        {
            result.val = (n1 != null ? n1.val : 0) + (n2 != null ? n2.val : 0) + extra;

            if (result.val >= 10)
            {
                extra = 1;
                result.val = result.val - 10;
            }
            else
                extra = 0;

            if (n1?.next != null || n2?.next != null || extra > 0)
            {
                result.next = new ListNode();
                result = result.next;
            }

            if (n1 != null)
                n1 = n1.next;

            if (n2 != null)
                n2 = n2.next;

        }

        return resultRoot;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}