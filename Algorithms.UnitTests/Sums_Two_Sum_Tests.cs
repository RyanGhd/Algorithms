using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Sums_Two_Sum_Tests
{
    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1,2 })]
    [TestCase(new int[] { 3, 3 }, 6, new int[] { 0,1 })]
    [TestCase(new int[] { 3, 3,1 }, 6, new int[] { 0,1 })]
    public void Tests_I(int[] input, int target, int[] output)
    {
        var sut = new Sums_Two_Sum();

        var result = sut.TwoSum(input, target);

        CollectionAssert.AreEqual(output, result);
    }


    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1,2})]
    [TestCase(new int[] { 2, 3, 4 }, 6, new int[] { 1,3})]
    [TestCase(new int[] { -1, 0 }, -1, new int[] { 1,2})]
    public void Tests_II(int[] input, int target, int[] output)
    {
        var sut = new Sums_Two_Sum_II();

        var result = sut.TwoSum(input, target);

        CollectionAssert.AreEqual(output, result);
    }
}