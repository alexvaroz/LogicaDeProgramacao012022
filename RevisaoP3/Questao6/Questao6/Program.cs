using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    /*
    Criar uma função em C# que retorne a soma dos números encontrados em uma matriz de inteiros.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizTeste = GerarMatrizNumerosInteiros(10, 10);
            Console.WriteLine($"A soma dos elementos é {SomarValoresMatriz(matrizTeste)}");
            Console.ReadLine();
        }

        // Método para gerar uma matriz de números aleatórios
        static int[,] GerarMatrizNumerosInteiros(int numLinhas, int numColunas)
        {
            int[,] matriz = new int[numLinhas, numColunas];
            Random rnd = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(0, 100000);
                }
            }
            return matriz;
        }

        // Método para somar os valores de uma matriz
        static int SomarValoresMatriz(int[,] matriz)
        {
            int soma = 0;
            foreach (var item in matriz)
            {
                soma = soma + item;
            }
            return soma;
        }
    }
}
