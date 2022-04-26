using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    /* Escreva um programa em C# que leia 5 valores (considere que não serão informados valores 
    iguais) e escrever a soma dos 2 maiores.*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int maiorValor, segundoMaiorValor;

            Console.WriteLine("Insira 5 números no array:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }
            maiorValor = numeros[0];
            foreach(int numero in numeros)
            {
                if (numero >= maiorValor)
                {
                    maiorValor = numero;
                }
            }
            segundoMaiorValor = numeros[0];
            foreach (int numero in numeros)
            {
                if ((numero >= segundoMaiorValor) && (numero< maiorValor))
                {
                    segundoMaiorValor = numero;
                }
            }

            Console.WriteLine($"A soma dos maiores números digitados ({maiorValor} e "+
                               $"{segundoMaiorValor}) é {maiorValor + segundoMaiorValor}");
            Console.ReadLine();
        }
    }
}
