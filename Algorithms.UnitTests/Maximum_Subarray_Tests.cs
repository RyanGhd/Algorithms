using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Maximum_Subarray_Tests
{
    [TestCase(new int[]{ -2, 1, -3, 4, -1, 2, 1, -5, 4 },6)]
    [TestCase(new int[]{ -100,-1},-1)]
    public void Tests(int[] inputs, int sum)
    {
        var sut = new Maximum_Subarray();

        var result = sut.MaxSubArray(inputs);

        Assert.AreEqual(sum, result);

    }
}