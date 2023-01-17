using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
// ReSharper disable All

namespace Algorithms.UnitTests;

public class Intersections_Interval_List_Intersections_Tests
{
    private TestDataHelper _dataHelper = new TestDataHelper();

    [TestCase("[[0,2],[5,10],[13,23],[24,25]]", "[[1,5],[8,12],[15,24],[25,26]]", "[[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]")]
    [TestCase("[[1,3],[5,9]]", "[]", "[]")]
    [TestCase("[[1,3],[5,6]]", "[[2,5],[7,10]]", "[[2,3],[5,5]]")]
    [TestCase("[[5,10]]", "[[3,10]]", "[[5,10]]")]
    //[TestCase("", "", "")]
    public void Tests(string input1, string input2, string output)
    {
        var firstList = _dataHelper.Deserialize<int[][]>(input1);
        var secondList = _dataHelper.Deserialize<int[][]>(input2);
        var outputList = _dataHelper.Deserialize<int[][]>(output);

        var sut = new Intersections_Interval_List_Intersections();

        var result = sut.IntervalIntersection(firstList, secondList);

        Assert.AreEqual(output, _dataHelper.Serialize(result));
    }


}