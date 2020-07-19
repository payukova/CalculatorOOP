using NUnit.Framework;
using calculator_practica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_practica.Tests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(2, 4, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(1.75, 5.45, 9.5375)]
        public void calculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}