using NUnit.Framework;

namespace Algorithms.UnitTests;

public class LongestCommonPrefixSolutionTests
{

    [TestCase("fl", "flower", "flow", "flight")]
    [TestCase("", "dog", "racecar", "car")]
    [TestCase("", "reflower", "flow", "flight")]
    public void Tests(string output, params string[] inputs)
    {
        var sut = new LongestCommonPrefixSolution();

        Assert.AreEqual(output, sut.LongestCommonPrefix(inputs));
    }
}