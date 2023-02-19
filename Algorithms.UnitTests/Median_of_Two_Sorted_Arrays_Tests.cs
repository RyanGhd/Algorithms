// ReSharper disable All
using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Median_of_Two_Sorted_Arrays_Tests
{
    [TestCase(new int[]{ 1, 3 },new int[]{ 2 }, 2.00000)]
    [TestCase(new int[]{ 1, 2 },new int[]{ 3, 4 }, 2.50000)]
    public void Tests(int[] nums1, int[] nums2, double output)
    {
        var sut = new Median_of_Two_Sorted_Arrays();
        var result = sut.FindMedianSortedArrays(nums1, nums2);

        Assert.AreEqual(output, result);
    }
}