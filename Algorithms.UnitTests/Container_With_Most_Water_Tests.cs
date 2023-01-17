// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Container_With_Most_Water_Tests
{
    [TestCase(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    public void Tests(int[] input, int output)
    {
        var sut = new Container_With_Most_Water();

        var result = sut.MaxArea(input);

        Assert.AreEqual(output, result);
    }
}