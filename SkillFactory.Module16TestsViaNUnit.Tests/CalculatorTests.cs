using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillFactory.Module16TestsViaNUnit;

namespace SkillFactory.Module16TestsViaNUnit.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(1, -2, -1)]
        [TestCase(-1, 2, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 5, 5)]
        [TestCase(10, 0, 10)]
        [TestCase(-5, 5, 0)]
        [TestCase(5, -5, 0)]
        [TestCase(int.MaxValue, 1, int.MinValue)]
        [TestCase(int.MinValue, -1, int.MaxValue)]
        [TestCase(int.MaxValue, int.MinValue, -1)]
        [TestCase(int.MinValue, int.MinValue, 0)]
        [TestCase(10, 10, 20)]
        [TestCase(-10, -10, -20)]
        [TestCase(0, int.MaxValue, int.MaxValue)]
        [TestCase(0, int.MinValue, int.MinValue)]
        [TestCase(int.MaxValue, -1, int.MaxValue - 1)]
        [TestCase(int.MinValue, 1, int.MinValue + 1)]
        public void AdditionalMustReturnCorrectValue(int a, int b, int expected)
        {
            Calculator testCalculator = new Calculator();
            int actual = testCalculator.Additional(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(2, 1, 1)]
        [TestCase(1, 2, -1)]
        [TestCase(0, 0, 0)]
        [TestCase(5, 0, 5)]
        [TestCase(10, 5, 5)]
        [TestCase(0, 5, -5)]
        [TestCase(5, -5, 10)]
        [TestCase(int.MaxValue, 1, int.MaxValue - 1)]
        [TestCase(int.MinValue, -1, int.MinValue + 1)]
        [TestCase(int.MaxValue, int.MinValue, -1)]
        [TestCase(int.MinValue, int.MinValue, 0)]
        [TestCase(20, 10, 10)]
        [TestCase(-10, -10, 0)]
        [TestCase(int.MaxValue, int.MaxValue, 0)]
        public void SubtractionMustReturnCorrectValue(int a, int b, int expected)
        {
            Calculator testCalculator = new Calculator();
            int actual = testCalculator.Subtraction(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
