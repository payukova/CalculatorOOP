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
    public class DivisionTests
    {
        [TestCase(0, 10, 0)]
        [TestCase(5, 2, 2.5)]
        [TestCase(60, 2, 30)]
        public void calculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}