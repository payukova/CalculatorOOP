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
    public class SubtractionTests
    {
        [Test]
        public void calculateTest()
        {
            var calculator = new Subtraction();
            Assert.AreEqual(40, calculator.calculate(60, 20));
            Assert.AreEqual(68, calculator.calculate(100, 32));
            Assert.AreEqual(-15, calculator.calculate(5, 20));
        }
    }
}