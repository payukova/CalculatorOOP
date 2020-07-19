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
    public class TwoArgumentsFactoryTests
    {
        [Test]
        [TestCase("summary", typeof(Addition))]
        [TestCase("subtraction", typeof(Subtraction))]
        [TestCase("multiplication", typeof(Multiplication))]
        [TestCase("divisiont", typeof(Division))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}