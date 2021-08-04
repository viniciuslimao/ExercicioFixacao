using System;

namespace Exercicio0
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor p = new Conversor();
            Console.WriteLine("Diga qual o valor da cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());
            p.Cotação = cotacao;
            Console.WriteLine("Quantos doláres você vai comprar?");
            double dolar = double.Parse(Console.ReadLine());
            p.Dolar = dolar;
            Console.WriteLine(p);

        }
    }
}
