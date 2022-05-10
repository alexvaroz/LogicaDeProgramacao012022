using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_CriarImprimirMatriz
{
    /* 
    Criar um função em C# que receba os números de linhas e colunas, e gere 
    uma matriz de números inteiros aleatórios entre 0 e 100. Em seguida, crie 
    uma outra função que imprima os valores da matriz respeitando um formato:
    */

    class Program
    {   static void Main(string[] args)
        {
            int[,] matrizGerada = GerarMatrizComLinhasColunas(500, 12);
            ImprimirMatriz(matrizGerada);
            Console.ReadLine();
        }

        static int[,] GerarMatrizComLinhasColunas(int qtdeLinhas, int qtdeColunas)
        {
            int[,] matrizGerada = new int[qtdeLinhas, qtdeColunas];
            Random rnd = new Random();
            for (int i = 0; i < matrizGerada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizGerada.GetLength(1); j++)
                {
                    matrizGerada[i, j] = rnd.Next(0, 101);
                }
            }
            return matrizGerada;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} \t");
                }
                Console.WriteLine("");
            }
        }
    }
}
