using System;

namespace Exercicio1

{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p = new Pessoas();
            Console.WriteLine("Diga seu nome: (1º)");
            string n1 = Console.ReadLine();
            p.Nome1 = n1;
            Console.WriteLine("Diga sua idade: (1º)");
            int idade1 = int.Parse(Console.ReadLine());
            p.Idade1 = idade1;
            Console.WriteLine("Diga seu nome: (2º)");
            string n2 = Console.ReadLine();
            p.Nome2 = n2;
            Console.WriteLine("Diga sua idade: (2º)");
            int idade2 = int.Parse(Console.ReadLine());
            p.Idade2 = idade2;

            Console.WriteLine(p.Maior());
        }
    }
}
