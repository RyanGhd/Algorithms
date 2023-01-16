using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Algorithms.UnitTests;

public class Three_Sum_Tests
{
    //[TestCase(new int[] { -1, 0, 1, 2, -1, -4 }, 0)]
    public void Tests(int[] input, int outputIndex)
    {
        var sut = new Three_Sum();

        var result = sut.ThreeSum(input);

        var output = TestData.Data[outputIndex];

        if(output.Count==0) Assert.That(result.Count==0);
        else
        {
            for (int i = 0; i < output.Count; i++)
            {
                CollectionAssert.AreEqual(output[i], result[i].ToArray());
            }
        }
        
    }

    public static class TestData
    {
        public static List<List<List<int>>> Data { get; }

        static TestData()
        {
            Data = new List<List<List<int>>>();
            //scenario1 
            Data.Add(new List<List<int>> { new List<int>() { -1, -1, 2 }, new List<int>() { -1, 0, 1 } });
        }
    }
}