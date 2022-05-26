using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro primeiroCachorro = new Cachorro();
            primeiroCachorro.raca = "PitBull";
            primeiroCachorro.idade = 10;
            primeiroCachorro.nome = "Docinho";

            Cachorro segundoCachorro = new Cachorro();
            segundoCachorro.raca = "Pastor Alemão";
            segundoCachorro.idade = 36;
            segundoCachorro.nome = "RinTinTin";

            Console.WriteLine($"O cachorro {primeiroCachorro.nome} é da raça " +
            $"{primeiroCachorro.raca} e possui {primeiroCachorro.idade} meses. ");
            Console.ReadLine();
            primeiroCachorro.Latir();
            Console.ReadLine();
        }
    }
}
