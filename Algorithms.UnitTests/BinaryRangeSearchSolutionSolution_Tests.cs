using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
// ReSharper disable All

namespace Algorithms.UnitTests;

public class BinaryRangeSearchSolutionSolution_Tests
{
    [TestCase(new int[] { 3, 4 }, new int[] { 5, 7, 7, 8, 8, 10 }, 8)]
    [TestCase(new int[] { 3, 6 }, new int[] { 5, 7, 7, 8,8,8, 8, 10 }, 8)]
    [TestCase(new int[] { 0,0 }, new int[] { 1 }, 1)]

    public void Tests(int[] output, int[] input, int target)
    {
        var sut = new BinaryRangeSearchSolution();

        var result = sut.SearchRange(input, target);

        CollectionAssert.AreEqual(output, result);
    }
}