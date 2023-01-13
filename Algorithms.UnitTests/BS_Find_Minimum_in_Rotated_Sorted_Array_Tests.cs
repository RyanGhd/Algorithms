// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class BS_Find_Minimum_in_Rotated_Sorted_Array_Tests
{
    [TestCase(1,new int[]{ 3, 4, 5, 1, 2 })]
    [TestCase(0,new int[]{ 4, 5, 6, 7, 0, 1, 2 })]
    [TestCase(11,new int[]{ 11, 13, 15, 17 })]
    [TestCase(1,new int[]{ 2, 1 })]
    [TestCase(1,new int[]{  1 })]
    [TestCase(1,new int[]{ 4, 5, 1, 2, 3 })]
    public void Tests(int output, int[] inputs)
    {
        var sut = new BS_Find_Minimum_in_Rotated_Sorted_Array();

        var result = sut.FindMin(inputs);

        Assert.AreEqual(output, result);
    }
}