// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Longest_Substring_Without_Repeating_Characters_Tests
{
    [TestCase("abcabcbb",3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    [TestCase("", 0)]
    [TestCase("b", 1)]
    [TestCase("au", 2)]
    [TestCase("aab", 2)]
    [TestCase("dvdf", 3)]
    public void Tests(string input,int output)
    {
        var sut = new Longest_Substring_Without_Repeating_Characters();

        var result = sut.LengthOfLongestSubstring(input);

        Assert.AreEqual(output, result);
    }
}