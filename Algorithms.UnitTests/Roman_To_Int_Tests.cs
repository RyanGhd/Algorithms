using NUnit.Framework;
// ReSharper disable All

namespace Algorithms.UnitTests
{
    public class Roman_To_Int_Tests
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
            var s = new Roman_To_Int();

            var result = s.RomanToInt(input);

            Assert.AreEqual(output, result);
        }
    }
}