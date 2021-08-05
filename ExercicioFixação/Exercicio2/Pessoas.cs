namespace Exercicio1
{
    class Pessoas
    {
        public string Nome1 { get; set; }
        public int Idade1 { get; set; }
        public string Nome2 { get; set; }
        public int Idade2 { get; set; }

        public string Maior()
        {
            if (Idade1 > Idade2)
            {
                return Nome1;
            }
            else
            {
                return Nome2;
            }

        }

    }
}
