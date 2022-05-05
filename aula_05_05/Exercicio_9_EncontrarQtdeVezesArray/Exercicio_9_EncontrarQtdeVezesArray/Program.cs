using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9_EncontrarQtdeVezesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arrayTeste = new int[1000]; 
            for (int i = 0; i < 1000; i++)
            {
                arrayTeste[i] = rnd.Next(0, 100);
            }

            Console.WriteLine($"Quantas vezes o número 25 aparece no array:");
            Console.WriteLine(RetonarQtdeNumeroArray(25, arrayTeste));
            Console.ReadLine();
        }

        static int RetonarQtdeNumeroArray(int numero, int[] array)
        {
            int qtdeVezes = 0;

            foreach(int item in array)
            {
                if (item == numero)
                {
                    qtdeVezes++;
                }
            }
            return qtdeVezes;
        }
    }
}
