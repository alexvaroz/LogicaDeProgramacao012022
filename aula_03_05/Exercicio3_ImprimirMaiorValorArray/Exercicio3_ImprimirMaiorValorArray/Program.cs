using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_ImprimirMaiorValorArray
{
    class Program
    {
        static void ImprimirMaiorValorArray(int[] numeros)
        {
            int maiorValor = numeros[0];
            foreach (int item in numeros)
            {
                if (item >= maiorValor)
                {
                    maiorValor = item;
                }
            }
            Console.WriteLine($"O maior valor do array é {maiorValor}");
        }

        static void Main(string[] args)
        {
            int[] array = { 23, 45, 98, 102, 2, -4, 9 };
            ImprimirMaiorValorArray(array);
            Console.ReadLine();
        }
    }
}
