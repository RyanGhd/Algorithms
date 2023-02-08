// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Add_Two_Numbers_Tests
{
    [TestCase(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
    [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
    [TestCase(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [TestCase(new int[] { 9 }, new int[] { 9 }, new int[] { 8, 1 })]
    [TestCase(new int[] { 0 }, new int[] { 7, 3 }, new int[] { 7, 3 })]
    public void Tests(int[] l1Input, int[] l2Input, int[] outputArray)
    {
        var l1 = Convert(l1Input);
        var l2 = Convert(l2Input);
        var output = Convert(outputArray);

        var sut = new Add_Two_Numbers();

        var result = sut.AddTwoNumbers(l1, l2);

        Assert.IsTrue(Compare(result, output));
    }

    private Add_Two_Numbers.ListNode Convert(int[] input)
    {
        Add_Two_Numbers.ListNode? node = null, root = null;

        for (int i = 0; i < input.Length; i++)
        {
            var prev = node;
            node = new Add_Two_Numbers.ListNode(input[i]);

            if (prev != null)
                prev.next = node;

            if (i == 0)
                root = node;
        }

        return root;
    }

    private bool Compare(Add_Two_Numbers.ListNode l1, Add_Two_Numbers.ListNode l2)
    {
        Add_Two_Numbers.ListNode n1 = l1, n2 = l2;

        while (n1 != null || n2 != null)
        {
            if (n1 != null && n2 == null) return false;
            else if (n1 == null && n2 != null) return false;
            else if (n1.val != n2.val) return false;

            n1 = n1.next;
            n2 = n2.next;
        }

        return true;
    }
}