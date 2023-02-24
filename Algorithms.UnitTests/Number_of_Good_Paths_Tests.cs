// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Number_of_Good_Paths_Tests
{
    private TestDataHelper _dataHelper = new TestDataHelper();

    [TestCase("[1,3,2,1,3]", "[[0,1],[0,2],[2,3],[2,4]]", 6)]
    [TestCase("[1,1,2,2,3]", "[[0,1],[1,2],[2,3],[2,4]]", 7)]
    [TestCase("[2,2,5,5]", "[[1,0],[0,2],[3,2]]", 6)]
    [TestCase("[2,4,3,1,5]", "[[0,1],[0,2],[0,3],[2,4]]", 5)]
    [TestCase("[2,4,1,2,2,5,3,4,4]", "[[0,1],[2,1],[0,3],[4,1],[4,5],[3,6],[7,5],[2,8]]", 11)]
    [TestCase("[1,4,5,2,4,4,1]", "[[0,1],[1,2],[1,3],[4,2],[5,1],[5,6]]", 8)]
    public void Tests(string vals, string edgesContent, int output)
    {
        var values = _dataHelper.Deserialize<int[]>(vals);
        var edges = _dataHelper.Deserialize<int[][]>(edgesContent);

        var sut = new Number_of_Good_Paths();

        var result = sut.NumberOfGoodPaths(values, edges);

        Assert.AreEqual(output, result);
    }
}