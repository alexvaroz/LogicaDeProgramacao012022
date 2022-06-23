using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    class Cachorro
    {
        string nome;
        string raca;
        string genero;
        int idade;

        // Construtor Default
        public Cachorro() { }

        public Cachorro(string nome, string raca, string genero, int idade)
        {
            this.nome = nome;
            this.raca = raca;
            this.genero = genero;
            this.idade = idade;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public string Raca
        {
            get
            {
                return raca;
            }

        }

        public string Genero
        {
            get
            {
                return genero;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
        }

        public void AbanarRabo()
        {
            Console.WriteLine($"{nome} está abanando o rabo!!!");
        }
    }
}
