using NUnit.Framework;
// ReSharper disable All

namespace Algorithms.UnitTests;

public class SubArrays_Minimum_Size_Subarray_Sum_Tests
{
    [TestCase(7,new int[]{ 2, 3, 1, 2, 4, 3 },2)]
    [TestCase(4,new int[]{ 1, 4, 4 },1)]
    [TestCase(11,new int[]{ 1, 1, 1, 1, 1, 1, 1, 1 },0)]
    public void Tests(int target,int[] nums,int output)
    {
        var sut = new SubArrays_Minimum_Size_Subarray_Sum();

        var result = sut.MinSubArrayLen(target, nums);

        Assert.AreEqual(output, result);
    }
}