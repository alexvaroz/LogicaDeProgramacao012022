using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    /* Escreva um programa que o usuário insira 5 números inteiros em um array e em seguida sejam 
    retornados o maior número digitado e a soma de todos os elementos do array.*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int somaNumeros, maiorNumero;
            somaNumeros = 0;

            Console.WriteLine("Digite 5 números inteiros:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            maiorNumero = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] >= maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
                somaNumeros += numeros[i];
            }

            Console.WriteLine($"O maior número é {maiorNumero}");
            Console.WriteLine($"A soma dos números é {somaNumeros}");
            Console.ReadLine();
        }
    }
}
