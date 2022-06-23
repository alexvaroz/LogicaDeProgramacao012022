using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    /*
        Escreva um programa em C# que receba 5 números inteiros, armazene-os em um array e 
        imprima na tela a soma de todos os elementos.
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de um array
            int[] numeros;
            // Alocação
            numeros = new int[5];

            Random rnd = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(0, 80);
            }

            int soma = 0;

            foreach (var item in numeros)
            {
                soma += item;
            }

            Console.WriteLine(soma);
            Console.ReadLine();
            Console.WriteLine("Números do array:");
            foreach (var item in numeros)
            {
                Console.Write($"{item}\t");
            }
            Console.ReadLine();

        }
    }
}
