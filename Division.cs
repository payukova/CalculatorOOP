using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_practica
{
    public class Division : ITwoArgumentsCalculator
    {
        public double calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Невозможно выполнить!");
            }
            return firstValue / secondValue;
        }
    }
}
