using Algorithms;
using NUnit.Framework;

namespace CodingTest.UnitTests
{
    public class RomanToIntTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [TestCase("III",3)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void RomanNumberTests(string input,int output)
        {
            var s = new RomanToIntSolution();

            var result = s.RomanToInt(input);

            Assert.AreEqual(output, result);
        }
    }
}