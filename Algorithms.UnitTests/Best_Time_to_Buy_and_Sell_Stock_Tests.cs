// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Best_Time_to_Buy_and_Sell_Stock_Tests
{
    [TestCase(new int[]{ 7, 1, 5, 3, 6, 4 },5)]
    [TestCase(new int[]{ 7, 6, 4, 3, 1 },0)]
    //[TestCase(new int[]{},)]
    public void Tests(int[] input,int output)
    {
        var sut = new Best_Time_to_Buy_and_Sell_Stock();

        var result = sut.MaxProfit(input);

        Assert.AreEqual(output, result);
    }
}