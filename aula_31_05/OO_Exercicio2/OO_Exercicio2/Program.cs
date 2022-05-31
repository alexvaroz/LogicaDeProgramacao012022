using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro primeiroCachorro = new Cachorro();
            primeiroCachorro.nome = "Floquinho";
            primeiroCachorro.raca = "PitBull";
            primeiroCachorro.genero = "Macho";
            primeiroCachorro.idade = 10;

            primeiroCachorro.Latir();
            primeiroCachorro.AbanarRabinho();

            Console.ReadLine();
            Cachorro segundoCachorro = new Cachorro();
            segundoCachorro.nome = "Capitu";
            segundoCachorro.raca = "Fila";
            segundoCachorro.genero = "Fêmea";
            segundoCachorro.idade = 20;

            Cachorro terceiroCachorro = new Cachorro();
            terceiroCachorro.nome = "Boni";
            terceiroCachorro.raca = "Poddle";
            terceiroCachorro.genero = "Macho";
            terceiroCachorro.idade = 6;

            Cachorro[] canil = { primeiroCachorro,
                segundoCachorro, terceiroCachorro };

            Console.WriteLine("Os meus cachorros se chamam:");
            for (int i = 0; i < canil.Length; i++)
            {
                Console.WriteLine(canil[i].nome);
            }
            Console.ReadLine();
        }
    }

}
