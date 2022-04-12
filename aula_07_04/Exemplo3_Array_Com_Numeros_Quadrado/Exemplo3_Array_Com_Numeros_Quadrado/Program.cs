using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3_Array_Com_Numeros_Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i * i;
            }
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[5]);
            // Elemento 5 não é acessível pois extrapola o índice
            Console.ReadLine();
        }
    }
}
