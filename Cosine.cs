using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace calculator_practica
{
    internal class Cosine : IOneArgumentCalculator
    {
        public double calculate(double firstValue)
        {
            return Math.Cos((firstValue / 180) * Math.PI);
        }
    }
}
