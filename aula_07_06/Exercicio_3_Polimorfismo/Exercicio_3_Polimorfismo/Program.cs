using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto bolaDeFutebol = new Produto(5);
            Console.WriteLine("Descrição da Bola");
            Console.WriteLine(bolaDeFutebol.InformarDescricao());
            Livro livroDoBob = new Livro("Machado de Assis", "Iracema", 30);
            Console.WriteLine("Descrição do Livro");
            Console.WriteLine(livroDoBob.InformarDescricao());
            JogoDigital jogoDoBob = new JogoDigital("XBox", "Aventuras de Bob Nelson", 125.99);
            Console.WriteLine("Descrição do Jogo");
            Console.WriteLine(jogoDoBob.InformarDescricao());
            Console.ReadLine();
        }
    }
}
