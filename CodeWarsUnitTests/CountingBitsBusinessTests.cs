using CodeWarsBusiness;
using CodeWarsBusiness._8kyu;
using NUnit.Framework;

namespace CodeWarsUnitTests
{
    public class CountingBitsBusinessTests
    {
        private CountingBitsBusiness _countingBitsBusiness;
        [SetUp]
        public void Setup()
        {
            _countingBitsBusiness = new CountingBitsBusiness();
        }

        [TestCase(1234, 5)]
        public void CountingBits_WhenCalled_ReturnsNumberOf1sOnBitString(int imput, int expectedResult)
        {
            int result = _countingBitsBusiness.CountBits(imput);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}