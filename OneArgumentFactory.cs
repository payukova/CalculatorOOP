using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_practica
{
    class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Sin": return new Sine();
                case "Cos": return new Cosine();
                default: throw new Exception("Неизвестная операция!");
            }
        }
    }
}
