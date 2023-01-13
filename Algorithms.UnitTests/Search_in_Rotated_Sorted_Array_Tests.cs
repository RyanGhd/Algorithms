using NUnit.Framework;
// ReSharper disable All

namespace Algorithms.UnitTests;

public class Search_in_Rotated_Sorted_Array_Tests
{
    [TestCase(4, 0, 4, 5, 6, 7, 0, 1, 2)]
    [TestCase(-1, 3, 4, 5, 6, 7, 0, 1, 2)]
    [TestCase(-1, 0, 1)]
    [TestCase(0, 1, 1)]
    [TestCase(1, 3, 1, 3, 5)]
    [TestCase(1, 3, 1, 3)]
    [TestCase(1, 1, 3,1)]
    [TestCase(0, 3, 3, 5, 1)]
    [TestCase(2, 3, 5, 1, 3)]
    public void Tests(int output, int target, params int[] inputs)
    {
        var sut = new Search_in_Rotated_Sorted_Array();

        var result = sut.Search(inputs, target);

        Assert.AreEqual(output, result);
    }
}