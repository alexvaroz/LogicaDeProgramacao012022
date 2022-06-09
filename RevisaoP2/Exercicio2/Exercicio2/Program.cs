using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        /*
        Criar um método que receba um array de inteiros e um número inteiro, e retorne 
        a quantidade de vezes que o número é encontrado dentro do array fornecido.
        */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arrayTeste = { 2, 3, 6, 70, 4, 9, 4 };
            int[] arrayTesteAleatorio = new int[2000];

            for (int i = 0; i < arrayTesteAleatorio.Length; i++)
            {
                arrayTesteAleatorio[i] = rnd.Next(0, 1000);
            }
            
            Console.WriteLine(RetornarQuantasVezesNumeroArray(52, arrayTesteAleatorio));
            Console.ReadLine();
        }

        static int RetornarQuantasVezesNumeroArray(int numero, int[] array)
        {
            int quantidadeVezes = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numero) {
                    quantidadeVezes++;
                }
            }
            return quantidadeVezes;
        }
    }
}
