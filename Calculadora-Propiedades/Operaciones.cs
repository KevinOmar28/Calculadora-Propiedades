using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Propiedades
{
    internal class Operaciones
    {
        private double num1;
        private double num2;

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }


        public double suma()
        {
            return Num1 + Num2;
        }

        public double resta()
        {
            return Num1 - Num2;
        }

        public double multiplicacion()
        {
            return Num1 * Num2;
        }

        public double division()
        {
            return Num1 / Num2;
        }
    }
}
