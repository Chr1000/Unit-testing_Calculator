using System;
using NUnit.Framework;

namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [Test]
        public void Add_Add2And4_Returns6()
        { 
        var uut = new Calculator();
        Assert.That(uut.Add(2,4), Is.EqualTo(6));
        }
    }
}
