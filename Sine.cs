using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_practica
{
    internal class Sine : IOneArgumentCalculator
    {
        public double calculate(double firstValue)
        {
            return Math.Sin((firstValue / 180) * Math.PI);
        }
    }
}
