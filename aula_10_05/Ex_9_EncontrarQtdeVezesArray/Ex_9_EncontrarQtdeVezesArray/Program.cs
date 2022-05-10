using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9_EncontrarQtdeVezesArray
{
    class Program
    {
        /* 
        Criar um método que retorne a quantidade de vezes que determinado 
        número é encontrado em um array fornecido. Escreva um programa para testar.
        */
        static void Main(string[] args)
        {
            int[] arrayTeste = new int[1000];

            Random rnd = new Random();

            for (int i = 0; i < arrayTeste.Length; i++)
            {
                arrayTeste[i] = rnd.Next(0, 100);
            }

            Console.WriteLine("Consulte quantas vezes o número aparece no array:");
            int numeroConsultado = int.Parse(Console.ReadLine());
            Console.WriteLine($"O número {numeroConsultado} aparece " +
                $"{RetornarQtdeVezesValorArray(numeroConsultado, arrayTeste)} vez(es)");
            Console.ReadLine();
        }

        static int RetornarQtdeVezesValorArray(int valor, int[] array)
        {
            int qtdeVezes = 0;
            foreach (var item in array)
            {
                if (item == valor)
                {
                    qtdeVezes++;
                }
            }
            return qtdeVezes;
        }
    }
}
