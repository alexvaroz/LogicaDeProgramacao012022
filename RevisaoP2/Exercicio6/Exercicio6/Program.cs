using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    //Desenvolva dois métodos que efetuem a mesma coisa, mas de forma diferente.
    //Eles devem receber um array de inteiros e retornar o maior valor.
    //Um dos métodos deve ser implementado de forma iterativa, enquanto o outro deve 
    //ser implementado utilizando recursão.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTeste = { 40, 67, 90, 14, 45, 345, 12, 2 };
            Console.WriteLine(RetornarMaiorValor(arrayTeste));
            Console.WriteLine(RetornarMaiorValor_Recursao(arrayTeste, arrayTeste.Length));
            Console.ReadLine();
        }

        static int RetornarMaiorValor(int[] array)
        {
            int maiorValor = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maiorValor) {
                    maiorValor = array[i];
                }
            }
            return maiorValor;
        }

        static int RetornarMaiorValor_Recursao(int[] array, int comprimentoArray)
        {
            // caso base
            if (comprimentoArray == 1)
            {
                return array[0];
            } else
            {
                if (array[comprimentoArray-1] > 
                    RetornarMaiorValor_Recursao(array, comprimentoArray - 1))
                {
                    return array[comprimentoArray - 1];
                } else
                {
                    return RetornarMaiorValor_Recursao(array, comprimentoArray - 1);
                }
            }

        }
    }
}
