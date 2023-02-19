// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class BFS_Race_Car_Tests
{
    [TestCase(2, 4)]
    [TestCase(3, 2)]
    [TestCase(6, 5)]
    [TestCase(13, 9)]
    [TestCase(11, 10)]
    [TestCase(330, 24)]
    [TestCase(12, 7)]
    [TestCase(24, 9)]
    [TestCase(14, 6)]
    [TestCase(20, 12)]
    [TestCase(27, 11)]
    public void Tests(int target, int output)
    {
        var sut = new BFS_Race_Car();
        var result = sut.Racecar(target);

        Assert.AreEqual(output, result);
    }
}