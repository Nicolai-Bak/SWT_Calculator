using NUnit.Framework;
using System;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void AddTwoPositive()
        {
            double a = 4;
            double b = 6;
            Assert.AreEqual(uut.Add(a, b), a + b);
            Assert.AreEqual(uut.Accumulator, a+b);

        }

        [Test]
        public void AddTwoNegative()
        {
            double a = -7;
            double b = -5;
            Assert.AreEqual(uut.Add(a, b), a + b);
            Assert.AreEqual(uut.Accumulator, a+b);

        }

        [Test]
        public void AddOnePositiveOneNegative()
        {
            double a = 4;
            double b = -5;
            Assert.AreEqual(uut.Add(a, b), a + b);
            Assert.AreEqual(uut.Accumulator, a+b);

        }

        [Test]
        public void SubtractTwoPositive()
        {
            double a = 4;
            double b = 5;
            Assert.AreEqual(uut.Subtract(a, b), a - b);
            Assert.AreEqual(uut.Accumulator, a-b);

        }

        [Test]
        public void SubtractTwoNegative()
        {
            double a = -4;
            double b = -5;
            Assert.AreEqual(uut.Subtract(a, b), a - b);
            Assert.AreEqual(uut.Accumulator, a - b);

        }

        [Test]
        public void SubtractOnePositiveOneNegative()
        {
            double a = 4;
            double b = -5;
            Assert.AreEqual(uut.Subtract(a, b), a - b);
            Assert.AreEqual(uut.Accumulator, a - b);

        }

        [Test]
        public void SubtractOneNegativeOnePositive()
        {
            double a = -4;
            double b = 5;
            Assert.AreEqual(uut.Subtract(a, b), a - b);
            Assert.AreEqual(uut.Accumulator, a - b);

        }


        [Test]
        public void MultiplyTwoPositive()
        {
            double a = 4;
            double b = 5;
            Assert.AreEqual(uut.Multiply(a, b), a * b);
            Assert.AreEqual(uut.Accumulator, a * b);

        }

        [Test]
        public void MultiplyTwoNegative()
        {
            double a = -4;
            double b = -5;
            Assert.AreEqual(uut.Multiply(a, b), a * b);
            Assert.AreEqual(uut.Accumulator, a * b);

        }

        [Test]
        public void MultiplyOnePositiveOneNegative()
        {
            double a = 4;
            double b = -5;
            Assert.AreEqual(uut.Multiply(a, b), a * b);
            Assert.AreEqual(uut.Accumulator, a * b);

        }

        [Test]
        public void MultiplyOneNegativeOnePositive()
        {
            double a = -4;
            double b = 5;
            Assert.AreEqual(uut.Multiply(a, b), a * b);
            Assert.AreEqual(uut.Accumulator, a * b);

        }

        [Test]
        public void MultiplyOnePositiveOneZero()
        {
            double a = 4;
            double b =0;
            Assert.AreEqual(uut.Multiply(a, b), a * b);
            Assert.AreEqual(uut.Accumulator, a * b);

        }

        [Test]
        public void PowerTwoPositive()
        {
            double a = 4;
            double b = 5;
            Assert.AreEqual(uut.Power(a, b), Math.Pow(a, b));
            Assert.AreEqual(uut.Accumulator, Math.Pow(a, b));

        }

        [Test]
        public void PowerTwoNegative()
        {
            double a = -4;
            double b = -5;
            Assert.AreEqual(uut.Power(a, b), Math.Pow(a, b));
            Assert.AreEqual(uut.Accumulator, Math.Pow(a, b));

        }

        [Test]
        public void PowerOnePositiveOneNegative()
        {
            double a = 4;
            double b = -5;
            Assert.AreEqual(uut.Power(a, b), Math.Pow(a, b));
            Assert.AreEqual(uut.Accumulator, Math.Pow(a, b));

        }

        [Test]
        public void PowerOneNegativeOnePositive()
        {
            double a = -4;
            double b = 5;
            Assert.AreEqual(uut.Power(a, b), Math.Pow(a, b));
            Assert.AreEqual(uut.Accumulator, Math.Pow(a, b));

        }

        [Test]
        public void PowerOnePositiveOneZero()
        {
            double a = 4;
            double b = 0;
            Assert.AreEqual(uut.Power(a, b), Math.Pow(a, b));
            Assert.AreEqual(uut.Accumulator, Math.Pow(a, b));

        }

        [Test]
        public void PowerOneZeroOnePositive()
        {
            double a = 0;
            double b = 5;
            Assert.AreEqual(uut.Power(a, b), Math.Pow(a,b));
            Assert.AreEqual(uut.Accumulator, Math.Pow(a, b));

        }

        [Test]
        public void DivideOneZeroOnePositive()
        {
            double a = 0;
            double b = 5;
            Assert.AreEqual(uut.Divide(a, b), a/b);
            Assert.AreEqual(uut.Accumulator, a/b);

        }

        [Test]
        public void DivideOnePositiveOneZero()
        {
            double a = 4;
            double b = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => uut.Divide(a,b));
            Assert.AreEqual(uut.Accumulator, 0);
        }

        [Test]
        public void DivideTwoPositive()
        {
            double a = 4;
            double b = 5;
            Assert.AreEqual(uut.Divide(a, b), a/b);
            Assert.AreEqual(uut.Accumulator, a / b);

        }

        [Test]
        public void ClearAdd()
        {
            double a = 4;
            double b = 5;
            uut.Add(a, b);
            uut.Clear();
            Assert.AreEqual(uut.Accumulator, 0);
        }

        [Test]
        public void ClearMultiply()
        {
            double a = 4;
            double b = 5;
            uut.Multiply(a, b);
            uut.Clear();
            Assert.AreEqual(uut.Accumulator, 0);
        }
        [Test]
        public void ClearDivide()
        {
            double a = 4;
            double b = 5;
            uut.Subtract(a, b);
            uut.Clear();
            Assert.AreEqual(uut.Accumulator, 0);
        }

    }
}