using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio0
{
    class Conversor
    {
        public double Cotação { get; set; }
        public double Dolar { get; set; }
        public double Reais { get; set; }

        public double ConversorDeMoeda()
        {
            Reais = ((Dolar * Cotação) * 0.06) + (Dolar * Cotação);
            return Reais;
        }

        public override string ToString()
        {
            return $"o valor a ser pago em reais: {ConversorDeMoeda():f2}";
        }
    }
}
