using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercicio2
{
    class Cachorro
    {
        public string raca;
        public int idade;
        public string genero;
        public string nome;

        public void Latir()
        {
            Console.WriteLine($"{nome} latindo: Au Au Au Au");
        }

        public void AbanarRabinho()
        {
            Console.WriteLine($"{nome} está abanando o rabinho: Flap flap flap");
        }
    }
}
