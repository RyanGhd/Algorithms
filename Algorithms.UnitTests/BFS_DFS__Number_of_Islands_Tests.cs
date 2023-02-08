// ReSharper disable All

using NUnit.Framework;

namespace Algorithms.UnitTests;


public class BFS_DFS__Number_of_Islands_Tests
{
    private TestDataHelper _dataHelper = new TestDataHelper();

    [TestCase(@"[['1', '1', '1', '1', '0'],
                      ['1', '1', '0', '1', '0'],
                      ['1', '1', '0', '0', '0'],
                      ['0', '0', '0', '0', '0']]", 1)]
    
    [TestCase(@"[['1','1','0','0','0'],
                      ['1','1','0','0','0'],
                      ['0','0','1','0','0'],
                      ['0','0','0','1','1']]", 3)]    
    [TestCase(@"[['1','1','1'],
                       ['0','1','0'],
                       ['1','1','1']]", 1)]
    
    [TestCase(@"[
                      ['1','1','1','1','1','0','1','1','1','1'],
                      ['1','0','1','0','1','1','1','1','1','1'],
                      ['0','1','1','1','0','1','1','1','1','1'],
                      ['1','1','0','1','1','0','0','0','0','1'],
                      ['1','0','1','0','1','0','0','1','0','1'],
                      ['1','0','0','1','1','1','0','1','0','0'],
                      ['0','0','1','0','0','1','1','1','1','0'],
                      ['1','0','1','1','1','0','0','1','1','1'],
                      ['1','1','1','1','1','1','1','1','0','1'],
                      ['1','0','1','1','1','1','1','1','1','0']]", 2)]
    public void Tests(string grid, int output)
    {
        var data = _dataHelper.Deserialize<char[][]>(grid);

        var sut = new BFS_DFS__Number_of_Islands();

        var result = sut.NumIslands(data);

        Assert.AreEqual(output, result);
    }    
}