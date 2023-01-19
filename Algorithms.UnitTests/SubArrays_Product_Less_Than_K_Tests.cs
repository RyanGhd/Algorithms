// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class SubArrays_Product_Less_Than_K_Tests
{
    [TestCase(new int[] { 10, 5, 2, 6 }, 100, 8)]
    public void Tests(int[] input, int k, int output)
    {
        var sut = new SubArrays_Product_Less_Than_K();

        var result = sut.NumSubarrayProductLessThanK(input, k);

        Assert.AreEqual(output, result);
    }
}