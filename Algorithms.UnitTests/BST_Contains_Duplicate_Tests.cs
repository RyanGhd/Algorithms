// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class BST_Contains_Duplicate_Tests
{
    [TestCase(new int[]{ 1, 2, 3, 1 },true)]
    [TestCase(new int[]{ 1, 2, 3, 4 },false)]
    [TestCase(new int[]{ 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 },true)]
    public void Tests(int[] input, bool output)
    {
        var sut = new BST_Contains_Duplicate();

        var result = sut.ContainsDuplicate(input);

        Assert.AreEqual(output,result);
    }
}