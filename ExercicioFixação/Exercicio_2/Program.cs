using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionários p = new Funcionários();
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Digite seu nome: ");
            string nome1 = Console.ReadLine();
            p.Nome1 = nome1;
            Console.WriteLine("Digite seu salário: ");
            double salario1 = double.Parse(Console.ReadLine());
            p.Salario1 = salario1;
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Digite seu nome: ");
            string nome2 = Console.ReadLine();
            p.Nome2 = nome2;
            Console.WriteLine("Digite seu salário: ");
            double salario2 = double.Parse(Console.ReadLine());
            p.Salario2 = salario2;

            Console.WriteLine(p);

        }
    }
}
