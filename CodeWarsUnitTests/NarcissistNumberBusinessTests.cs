using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeWarsBusiness._6kyu;

namespace CodeWarsUnitTests
{
    public class NarcissistNumberBusinessTests
    {
        private NarcissisticNumberBusiness _narcissisticNumberBusiness;

        [SetUp]
        public void Setup()
        {
            _narcissisticNumberBusiness = new NarcissisticNumberBusiness();
        }

        [TestCase(1, true)]
        [TestCase(1652, false)]
        public void Narcissistic_WhenCalled_ReturnsIfNumberIsNarcissistic(int value, bool expectedResult)
        {
            bool result = _narcissisticNumberBusiness.Narcissistic(value);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}