// ReSharper disable All

using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Strings_Find_All_Anagrams_in_a_String_Tests
{
    [TestCase("cbaebabacd", "abc", new int[] { 0, 6 })]
    [TestCase("abab", "ab", new int[] { 0, 1, 2 })]
    [TestCase("aa", "bb", new int[] {})]
    [TestCase("aaaaaaaaaa", "aaaaaaaaaaaaa", new int[] {})]
    public void Tests(string s, string p, int[] output)
    {
        var sut = new Strings_Find_All_Anagrams_in_a_String();

        var result = sut.FindAnagrams(s, p);

        CollectionAssert.AreEqual(output, result);
    }
}