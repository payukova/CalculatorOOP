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
    public class CosineTests
    {
        [Test]
        public void calculateTest()
        {
            var calculator = new Cosine();
            Assert.AreEqual(0.5, calculator.calculate(60));
        }
    }
}