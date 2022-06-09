using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        /*
        Criar um função em C# que receba os números de linhas e colunas, e gere uma matriz 
        de números inteiros aleatórios entre 0 e 100. Em seguida, crie uma outra função que 
        imprima os valores da matriz respeitando o seguinte formato
        */

        static void Main(string[] args)
        {
            int[,] matrizTeste = GerarMatrizNumerosInteiros(10, 15);
            ImprimirMatriz(matrizTeste);
            Console.ReadLine();
        }

        static int[,] GerarMatrizNumerosInteiros(int numLinhas, int numColunas)
        {
            Random rnd = new Random();
            int[,] matriz = new int[numLinhas, numColunas];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(0, 101);
                }
            }
            return matriz;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
