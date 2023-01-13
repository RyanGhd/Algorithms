using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Find_Peak_Element_Tests
{
    [TestCase(new int[]{2},new int[]{ 1, 2, 3, 1 })]
    [TestCase(new int[]{1,5},new int[]{ 1, 2, 1, 3, 5, 6, 4 })]
    [TestCase(new int[]{0},new int[]{ 1})]
    public void Tests(int[] outputs, int[] inputs)
    {
        var sut = new Find_Peak_Element();

        var result = sut.FindPeakElement(inputs);

        CollectionAssert.Contains(outputs, result);
    }
}