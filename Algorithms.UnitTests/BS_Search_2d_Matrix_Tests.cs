using System.Collections.Generic;
using NUnit.Framework;

namespace Algorithms.UnitTests;

public class BS_Search_2d_Matrix_Tests
{
    [TestCase(0, 3, true)]
    [TestCase(1, 1, true)]
    [TestCase(2, 1, true)]
    [TestCase(3, 3, true)]
    [TestCase(4, 3, true)]
    public void Tests(int dataIndex, int target, bool output)
    {
        var data = TestCaseData.Data[dataIndex];

        var sut = new BS_Search_2d_Matrix();

        var result = sut.SearchMatrix(data, target);

        Assert.AreEqual(output, result);
    }

}

public class TestCaseData
{
    public static List<int[][]> Data = new List<int[][]>
    {
        new int[][]
        {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        } ,
        new int[][]
        {
            new int[] { 1},
        },
        new int[][]
        {
            new int[] { 1,1},
        },
        new int[][]
        {
            new int[] { 1,3},
        },
        new int[][]
        {
            new int[] { 1},
            new int[] { 3},
        },
    };
}