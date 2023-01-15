namespace Algorithms;

public class Linked_List_Remove_Duplicates_from_Sorted_List_II
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;
        else if (head.next == null)
            return head;
        else if (head.val == head.next.val && head.next.next == null)
            return null;

        ListNode prevNode = null;
        var node = head;
        ListNode headNode = head;


        while (node != null)
        {
            var subNode = node;
            while (subNode.next != null && subNode.val == subNode.next.val)
            {
                subNode = subNode.next;
            }

            if (node == subNode)
            {
                // set the head node in case the first nodes are duplicate
                if (headNode == null)
                    headNode = node;

                prevNode = node;

                node = node.next;
            }
            else // duplicate 
            {
                if (prevNode==null) // head node is duplicate
                {
                    headNode = subNode.next;
                    node = headNode;
                }
                else
                {
                    prevNode.next = subNode.next;
                    node = prevNode;
                }
            }
        }

        return headNode;
    }
}

public class ListNode
{
    public int val { get; private set; }
    public ListNode next { get; set; }

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}



