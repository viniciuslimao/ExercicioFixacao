using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Pessoas
    {
        public string Nome1 { get; set; }
        public int Idade1 { get; set; }
        public string Nome2 { get; set; }
        public int Idade2 { get; set; }

        public int Maior()
        {
            if (Idade1 > Idade2)
            {
                Console.WriteLine("A mais velha é " + Nome1);
            }else
            {
                if (Idade2 > Idade1)
                {
                    Console.WriteLine("A mais velha é " + Nome2);
                }
            }
            return Maior();
        }
    }
}
