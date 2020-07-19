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
    public class SineTests
    {
        [Test]
        public void calculateTest()
        {
            var calculator = new Sine();
            Assert.AreEqual(0.5, calculator.calculate(30));
        }
    }
}