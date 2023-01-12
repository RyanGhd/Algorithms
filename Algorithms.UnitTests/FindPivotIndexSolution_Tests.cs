﻿using NUnit.Framework;
// ReSharper disable All

namespace Algorithms.UnitTests;

public class FindPivotIndexSolution_Tests
{
    [TestCase(3, 1, 7, 3, 6, 5, 6)]
    [TestCase(-1, -1, -1, -1, -1, -1, -1)]
    [TestCase(1, -1, -1, -1, -1, 0, 1)]
    [TestCase(3, -1, -1, 0, -1, -1, -1)]
    public void Tests(int outputIndex, params int[] inputs)
    {
        var sut = new FindPivotIndexSolution();

        var result = sut.PivotIndex(inputs);

        Assert.AreEqual(outputIndex, result);
    }
}