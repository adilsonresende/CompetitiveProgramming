using NUnit.Framework;
using CodeWarsBusiness._6kyu;

namespace CodeWarsUnitTests
{
    public class MultipleOf3And5BusinessTests
    {
        private MultipleOf3And5Business _multipleOf3And5Business;

        [SetUp]
        public void Setup()
        {
            _multipleOf3And5Business = new MultipleOf3And5Business();
        }

        [TestCase(10, 23)]
        public void Solution_WhenCalled_ReturnsSumOfMultiplesOfThreeAndFive(int imput, int expectedResult)
        {
            int result = _multipleOf3And5Business.Solution(imput);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
