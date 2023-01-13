using NUnit.Framework;
// ReSharper disable All

namespace Algorithms.UnitTests;

public class Longest_Common_Prefix_Tests
{

    [TestCase("fl", "flower", "flow", "flight")]
    [TestCase("", "dog", "racecar", "car")]
    [TestCase("", "reflower", "flow", "flight")]
    public void Tests(string output, params string[] inputs)
    {
        var sut = new Longest_Common_Prefix();

        Assert.AreEqual(output, sut.LongestCommonPrefix(inputs));
    }
}