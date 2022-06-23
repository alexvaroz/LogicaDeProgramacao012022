using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    /*
    Criar um programa em C# que retorne o maior número encontrado em uma matriz de inteiros.
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Primeiro passo, construir a matriz
            int[,] matriz = new int[10, 4];

            Random rnd = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(0, 2000);
                }
            }

            int maiorNumero = matriz[0, 0];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] >= maiorNumero) {
                        maiorNumero = matriz[i, j];
                    }
                }
            }
            Console.WriteLine($"O maior número da matriz é {maiorNumero}");
            Console.ReadLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
