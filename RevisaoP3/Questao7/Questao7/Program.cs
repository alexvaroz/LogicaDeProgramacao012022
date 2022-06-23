using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    /*
    Criar classe “Cachorro”.
    Incluir os atributos: raça, idade, gênero, nome.
    Criar uma classe de teste para instanciar um objeto e definir os atributos.
    Criar o método “Latir” e “Abanar o rabo”.
    
    */

    class Program
    {
        static void Main(string[] args)
        {
            Cachorro primeiroCachorro = new Cachorro("Lulu", "poddle", "fêmea" , 6);
            Console.WriteLine($"Meu cachorro se chama {primeiroCachorro.Nome} " +
                $"é da raça {primeiroCachorro.Raca} e possui {primeiroCachorro.Idade} meses. ");
            Console.ReadLine();
            primeiroCachorro.AbanarRabo();
            Console.ReadLine();

        }
    }
}
