using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    /* Criar um programa em C# que retorne o maior número par encontrado em uma matriz 8x8 criada 
    por números inteiros aleatórios entre 0 e 500. */

    class Program
    {
        static void Main(string[] args) 
        {
            Random rnd = new Random();
            int[,] numeros = new int[8, 8];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] = rnd.Next(0, 501);
                    Console.Write($"{numeros[i, j]}\t");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

            int maiorValor = numeros[0, 0];

            foreach(int item in numeros)
            {
                if (item % 2 == 0)
                {
                    if (item >= maiorValor)
                    {
                        maiorValor = item;
                    }
                }
            }
            Console.WriteLine($"O maior valor par da matriz é {maiorValor}");
            Console.ReadLine();
        }
    }
}
