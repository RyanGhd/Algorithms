using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Merge_Sorted_Array_Tests
{
    [TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
    [TestCase(new int[] { 0 }, 0, new int[] { 1}, 1, new int[] { 1})]
    public void Tests(int[] a, int m, int[] b, int n, int[] output)
    {
        var sut = new Merge_Sorted_Array();

        sut.Merge(a, m, b, n);

        CollectionAssert.AreEqual(output, a);
    }
}