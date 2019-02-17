using System;
using NUnit.Framework;

namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [TestCase(3, 7, 10)]
        [TestCase(-3, -5, -8)]
        [TestCase(-3, 4, 1)]
        [TestCase(-3, 3, 0)]
        [TestCase(-3, 6, 3)]
        public void Add_aAndb_ReturnsResult(int a, int b, int result)
        {
        var uut = new Calculator();
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(-3, 3, -6)]
        public void Subtract_aAndb_ReturnsResult(int a, int b, int result)
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(-3, -3, 9)]
        public void Multiply_aAndb_ReturnsResult(int a, int b, int result)
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(4, 2, 16)]
        public void Power_aAndb_ReturnsResult(int a, int b, int result)
        {
            var uut = new Calculator();
            Assert.That(uut.Power(a,b), Is.EqualTo(result));
        }
    }
}
