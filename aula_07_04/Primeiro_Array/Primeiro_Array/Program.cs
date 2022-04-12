using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Etapas para criação de um Array: Declaração, Alocação e Inicialização
            // Declaração
            String[] jogosFavoritos;

            // Alocação
            jogosFavoritos = new String[4];

            // Inicialização
            jogosFavoritos[0] = "Hades";
            jogosFavoritos[1] = "Unsighted";
            jogosFavoritos[2] = "Mineirinho";
            jogosFavoritos[3] = "Halo";

            Console.WriteLine("Meus jogos favoritos são:");
            Console.WriteLine(jogosFavoritos[0]);
            Console.WriteLine(jogosFavoritos[1]);
            Console.WriteLine(jogosFavoritos[2]);
            Console.WriteLine(jogosFavoritos[3]);
            Console.ReadLine();

            // Outra forma de ler os dados do array
            Console.WriteLine("(outra forma) Meus jogos favoritos são:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(jogosFavoritos[i]);
            }
            Console.ReadLine();

            // Mais uma forma de ler os dados do array
            Console.WriteLine("(mais outra forma) Meus jogos favoritos são:");
            for (int i = 0; i < jogosFavoritos.Length; i++)
            {
                Console.WriteLine(jogosFavoritos[i]);
            }
            Console.ReadLine();

            // Mais uma forma (agora vai...) de ler os dados do array
            Console.WriteLine("(mais outra forma... a que eu prefiro...) Meus jogos favoritos são:");
            foreach (String item in jogosFavoritos)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
