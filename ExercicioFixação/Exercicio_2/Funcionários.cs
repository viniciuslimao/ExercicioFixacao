using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class Funcionários
    {
        public string Nome1 { get; set; }
        public double Salario1 { get; set; }
        public string Nome2 { get; set; }
        public double Salario2 { get; set; }

        public void Media(double media)
        {
            media = Salario1 + Salario2 / 2;

        }
    }
}
