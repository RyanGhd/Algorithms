using NUnit.Framework;
// ReSharper disable All

namespace Algorithms.UnitTests;

public class Strings_Backspace_String_Compare_Tests
{
    [TestCase("ab#c", "ad#c",true)]
    [TestCase("ab##", "c#d#", true)]
    [TestCase("a#c", "b", false)]
    public void Tests(string s, string t, bool output)
    {

        var sut = new Strings_Backspace_String_Compare();

        var result = sut.BackspaceCompare(s, t);

        Assert.AreEqual(output, result);
    }
}