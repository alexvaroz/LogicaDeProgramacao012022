using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_6_ImprimirMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração
            int[,] primeiraMatriz;
            // Alocação e Inicialização
            primeiraMatriz = new int[3, 3] { { 1, 12, 65 }, { -11, 2, 6 }, { 21, 1, 70 } };

            // Imprimindo os valores
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"O elemento da linha {i} e coluna {j} é {primeiraMatriz[i,j]}");
                }
            }
            Console.ReadLine();

            // Imprimindo com o Foreach
            foreach (var item in primeiraMatriz)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
    }
    }
}
