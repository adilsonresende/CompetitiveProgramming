using NUnit.Framework;
using CodeWarsBusiness._6kyu;

namespace CodeWarsUnitTests
{
    public class SpinningWordsBusinessTests
    {
        private SpinningWordsBusiness _spinningWordsBusiness;
        [SetUp]
        public void Setup()
        {
            _spinningWordsBusiness = new SpinningWordsBusiness();
        }
        [TestCase("Hey fellow warriors", "Hey wollef sroirraw")]
        [TestCase("This is a test", "This is a test")]
        [TestCase("This is another test", "This is rehtona test")]
        public void SpinWords_WhenCalled_ReturnsReversedWordsLongerThanFiveChars(string imput, string expectedResult)
        {
            string result = _spinningWordsBusiness.SpinWords(imput);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
