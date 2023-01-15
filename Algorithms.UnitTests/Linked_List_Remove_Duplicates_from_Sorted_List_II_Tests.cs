using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Linked_List_Remove_Duplicates_from_Sorted_List_II_Tests
{
    [TestCase(new int[] { 1, 2, 3, 3, 4, 4, 5 }, new int[] { 1, 2, 5 })]
    [TestCase(new int[] { 1, 2, 3, 3, 4, 4, 5, 5 }, new int[] { 1, 2 })]
    [TestCase(new int[] { 1, 1, 2, 3, 3, 4, 4, 5, 5 }, new int[] { 2 })]
    [TestCase(new int[] { 1 }, new int[] { 1 })]
    [TestCase(new int[] { 1, 1 }, new int[] { })]
    [TestCase(new int[] { 1, 1, 1 }, new int[] { })]
    [TestCase(new int[] { 1, 1, 1 ,2}, new int[] { 2})]
    [TestCase(new int[] { 1, 1, 1, 2, 3 }, new int[] { 2,3})]
    [TestCase(new int[] { 1, 1, 1, 2,2}, new int[] { })]
    public void Tests(int[] inputs, int[] outputs)
    {

        var head = ConvertData(inputs);

        var sut = new Linked_List_Remove_Duplicates_from_Sorted_List_II();

        var result = sut.DeleteDuplicates(head);

        var resultArray = ConvertToArray(result);

        CollectionAssert.AreEqual(outputs, resultArray);
    }

    private ListNode ConvertData(int[] inputs)
    {

        ListNode prevNode = null;
        ListNode node = null;


        for (int i = inputs.Length - 1; i >= 0; i--)
        {
            node = new ListNode(inputs[i], prevNode);
            prevNode = node;
        }

        return node;
    }

    private int[] ConvertToArray(ListNode head)
    {
        ListNode node = head;

        var result = new List<int>();

        while (node != null)
        {
            result.Add(node.val);

            node = node.next;
        }

        return result.ToArray();
    }
}