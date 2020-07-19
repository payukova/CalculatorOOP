using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_practica
{
    class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Add": return new Addition();
                case "Subtract": return new Subtraction();
                case "Multiply": return new Multiplication();
                case "Divide": return new Division();

                default: throw new Exception("Операция отсутствует!");
            }
        }
    }
}
