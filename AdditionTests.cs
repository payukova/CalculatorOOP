using calculator_practica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator_practica.Tests
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void calculateTest()
        {
            var calculator = new Addition();
            Assert.AreEqual(10, calculator.calculate(6,4));
            Assert.AreEqual(36, calculator.calculate(16, 20));
        }
    }
}