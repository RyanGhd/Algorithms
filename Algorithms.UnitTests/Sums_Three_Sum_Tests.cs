using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Api;

// ReSharper disable All

namespace Algorithms.UnitTests;

public class Sums_Three_Sum_Tests
{
    [TestCase(new int[] { -1, 0, 1, 2, -1, -4 }, 0)]
    [TestCase(new int[] { 0, 1, 1 }, 1)]
    [TestCase(new int[] { 0, 0, 0 }, 2)]
    [TestCase(new int[] { 0, 0, 0, 0 }, 3)]
    public void Tests(int[] input, int outputIndex)
    {
        var sut = new Sums_Three_Sum();

        var result = sut.ThreeSum(input);

        var output = TestData.Data[outputIndex];

        if (output.Count == 0) Assert.That(result.Count == 0);
        else
        {
            Assert.That(output.Count == result.Count);

            var matched = false;
            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (output[i].Except(result[j]).Count() == 0 &&
                        result[j].Except(output[i]).Count() == 0)
                    {
                        matched = true;
                        break;
                    }
                }

            }

            Assert.IsTrue(matched);
        }

    }

    public static class TestData
    {
        public static List<List<List<int>>> Data { get; }

        static TestData()
        {
            Data = new List<List<List<int>>>();
            //scenario 0 
            Data.Add(new List<List<int>> { new List<int>() { -1, -1, 2 }, new List<int>() { -1, 0, 1 } });

            //scenario 1
            Data.Add(new List<List<int>> { });

            //scenario 2
            Data.Add(new List<List<int>> { new List<int>() { 0, 0, 0 } });

            //scenario 3
            Data.Add(new List<List<int>> { new List<int>() { 0, 0, 0 } });
            
        }
    }
}