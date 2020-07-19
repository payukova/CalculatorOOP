using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_practica
{
    public class Addition : ITwoArgumentsCalculator
    {
        public double calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
