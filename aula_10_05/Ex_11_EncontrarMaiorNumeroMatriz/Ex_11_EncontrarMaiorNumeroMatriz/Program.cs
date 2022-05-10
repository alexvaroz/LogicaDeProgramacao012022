using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_EncontrarMaiorNumeroMatriz
{
    /*
    Criar uma função em C# que retorne o maior número encontrado em uma 
    matriz de inteiros.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrizTeste = new int[10, 15];

            for (int i = 0; i < matrizTeste.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTeste.GetLength(1); j++)
                {
                    matrizTeste[i, j] = rnd.Next(0, 1000);
                }
            }

            Console.WriteLine($"O maior número encontrado na matriz " +
                $"foi {RetornarMaiorNumeroMatriz(matrizTeste)}");
            Console.ReadLine();
        }

        static int RetornarMaiorNumeroMatriz(int[,] matriz)
        {
            int maiorValor = matriz[0, 0];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j]> maiorValor) {
                        maiorValor = matriz[i, j];
                    }
                }
            }
            return maiorValor;
        }
    }
}
