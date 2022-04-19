using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8_SomaDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrizQuadrada = new int[4, 4];

            // Popular a matriz
            for (int i = 0; i < matrizQuadrada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizQuadrada.GetLength(1); j++)
                {
                    matrizQuadrada[i, j] = rnd.Next(100);
                }
            }

            // Imprimir a matriz gerada
            for (int i = 0; i < matrizQuadrada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizQuadrada.GetLength(1); j++)
                {
                    Console.Write($"{matrizQuadrada[i,j]}   ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

            // Somar diagonal principal
            int soma = 0;
            for (int i = 0; i < matrizQuadrada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizQuadrada.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        soma += matrizQuadrada[i, j];
                    }
                }
            }

            // Somar diagonal principal outra forma
            soma = 0;
            for (int i = 0; i < matrizQuadrada.GetLength(0); i++)
            {
                soma += matrizQuadrada[i, i];
            }
            Console.WriteLine($"O valor da soma da diagonal principal é {soma}");
            Console.ReadLine();
        }
        }
    }
