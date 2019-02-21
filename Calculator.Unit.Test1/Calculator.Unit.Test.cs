using System;
using NUnit.Framework;
using Calculator;

namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTest
    {

        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }


        [TestCase(3, 7, 10)]
        [TestCase(-3, -5, -8)]
        [TestCase(-3, 4, 1)]
        [TestCase(-3, 3, 0)]
        [TestCase(-3, 6, 3)]
        [TestCase(-9, 3, -6)]
        [TestCase(9, 6, 15)]
        public void Add_aAndb_ReturnsResult(int a, int b, int result)
        {
            //var uut = new Calculator();
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(-3, 3, -6)]
        public void Subtract_aAndb_ReturnsResult(int a, int b, int result)
        {
            //var uut = new Calculator();
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(-3, -3, 9)]
        public void Multiply_aAndb_ReturnsResult(int a, int b, int result)
        {
            //var uut = new Calculator();
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(4, 2, 16)]
        public void Power_aAndb_ReturnsResult(int a, int b, int result)
        {
            //var uut = new Calculator();
            Assert.That(uut.Power(a,b), Is.EqualTo(result));
        }


//exercise 1.4 Exercise 4
        [TestCase(-2, 0.5)]
        [TestCase(-2, (1.0 / 3.0))]
        [TestCase(0, -1)]
        public void Power_IncorrectParameters_ThrowsException(double b, double exp)
        {
            Assert.That(() => uut.Power(b, exp), Throws.TypeOf<ArgumentOutOfRangeException>());
        }


//exercise 1.4 Exercise 4
        [TestCase(9, 3, 3)]
        [TestCase(7, 7, 1)]
        [TestCase(144, 12, 12)]
        public void divisor_aAndb_dividend(int a, int b, int result)
        {
            //var uut = new Calculator();
            Assert.That(uut.Divide(a,b), Is.EqualTo(result));
        }

        //exercise 1.4 Exercise 4
        [TestCase(144, 0, 0)]
        [TestCase(142, 0, 0)]
        [TestCase(143, 0, 0)]
        [TestCase(100, 0, 10)]
        [TestCase(0, 0, 1)]
        public void DivideByZero_ThrowsException(int a, int b, int result)
        {
            //var uut = new Calculator();
            Assert.That(() => uut.Divide(a,b), Throws.TypeOf<DivideByZeroException>());
        }

//exercise 1.4 Exercise 4
        [Test]
        public void Ctor_NoOperations_AccumulatorIszero()
        {
            //var uut = new Calculator();
            Assert.That(uut.Accumulator, Is.EqualTo(0.0));
        }

//exercise 1.4 Exercise 4
        [Test]
        public void Add2Parameter_Using_AccumulatorEqualsResult_Add()
        {
            uut.Add(3, 4);

            Assert.That(uut.Accumulator, Is.EqualTo(7));
        }

            [Test]
        public void Add2Parameter_Using_AccumulatorEqualsResult_Subtract()
        {
            uut.Subtract(3, 4);

            Assert.That(uut.Accumulator, Is.EqualTo(-1));
        }

        [Test]
        public void Add2Parameter_Using_AccumulatorEqualsResult_Multiply()
        {
            uut.Multiply(2, 9);
            Assert.That(uut.Accumulator, Is.EqualTo(18));
        }

        [Test]
        public void Add2Parameter_Using_AccumulatorEqualsResult_Exponent()
        {
            uut.Power(2, 9);
            Assert.That(uut.Accumulator, Is.EqualTo(512));
        }

        [Test]
        public void PowerExponent_Using_AccumulatorEqualsResult()
        {
            uut.Power(2, 0.5);
            Assert.That(uut.Accumulator, Is.EqualTo(1.41).Within(0.005));
        }
        //////////////////////////////////
        [Test]
        public void Subtract_BuildsOnPreviousResult()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            Assert.That(uut.Subtract(4), Is.EqualTo(1));
        }

        [Test]
        public void Multiply_BuildsOnPreviousResult()
        {
            uut.Multiply(2, 3);  // Accumulator is now 5, should be used in next calculation
            Assert.That(uut.Multiply(4), Is.EqualTo(24));
        }

        [Test]
        public void Divide_BuildsOnPreviousResult()
        {
            uut.Divide(3, 3);  // Accumulator is now 5, should be used in next calculation
            Assert.That(uut.Divide(2), Is.EqualTo(0.5));
        }

        [Test]
        public void Power_BuildsOnPreviousResult()
        {
            uut.Power(2, 3);  // Accumulator is now 5, should be used in next calculation
            Assert.That(uut.Power(2), Is.EqualTo(64));
        }

        [Test]
        public void Add_AndAddAgain_OnAccumulatorCorrect()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            uut.Add(4);
            Assert.That(uut.Accumulator, Is.EqualTo(9));
        }

        [Test]
        public void Add_AndSubtract_OnAccumulatorCorrect()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            uut.Subtract(4);
            Assert.That(uut.Accumulator, Is.EqualTo(1));
        }

        [Test]
        public void Add_AndMultiply_OnAccumulatorCorrect()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            uut.Multiply(4);
            Assert.That(uut.Accumulator, Is.EqualTo(20));
        }

        [Test]
        public void Add_AndDivide_OnAccumulatorCorrect()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            uut.Divide(2);
            Assert.That(uut.Accumulator, Is.EqualTo(2.5));
        }

        [Test]
        public void Add_AndPowerExponent_OnAccumulatorCorrect()
        {
            uut.Add(2, 3);  // Accumulator is now 5, should be used in next calculation
            uut.Power(2);
            Assert.That(uut.Accumulator, Is.EqualTo(25));
        }

        [Test]
        public void Divide_DivideByZero_ThrowsException()
        {
            uut.Add(2, 3);
            Assert.That(() => uut.Divide(0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(-2, 0.5)]
        [TestCase(-2, (1.0 / 3.0))]
        [TestCase(0, -1)]
        public void Power_1ParameterIncorrectParameters_ThrowsException(double b, double exp)
        {
            uut.Add(b, 0);
            Assert.That(() => uut.Power(exp), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
