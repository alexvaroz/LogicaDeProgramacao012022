using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4_SomarValoresEmArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTeste = { 10, 20, 30, 40, 50, 100, 100 };
            Console.WriteLine(SomarValoresArray(arrayTeste));
            Console.WriteLine(SomarValoresArrayComRecursao(arrayTeste, arrayTeste.Length));
            Console.ReadLine();
        }

        static int SomarValoresArray(int[] array)
        {
            int resultado = 0;
            for (int i = 0; i < array.Length; i++)
            {
                resultado = resultado + array[i];
            }
            return resultado;
        }

        // Com recursão
        static int SomarValoresArrayComRecursao(int[] array, int tamanhoArray)
        {
            int soma = 0;
            if (tamanhoArray == 1)
            {
                soma = array[0];
                return soma;
            } else
            {
                soma = array[tamanhoArray - 1] + SomarValoresArrayComRecursao(array, tamanhoArray-1);
                return soma;
            }
        }
    }
}
