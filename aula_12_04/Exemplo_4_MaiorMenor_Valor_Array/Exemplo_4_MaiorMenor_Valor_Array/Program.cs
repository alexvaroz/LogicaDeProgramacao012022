using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_4_MaiorMenor_Valor_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração, Alocação e Inicialização
            int[] arrayTeste = { 12, 2, 3, 18, 40, 5, 1, 72, 8, 9 };
            int maiorValor, menorValor;
            maiorValor = arrayTeste[0];
            menorValor = arrayTeste[0];
            for (int i = 0; i < arrayTeste.Length; i++)
            {
                if (arrayTeste[i] > maiorValor)
                {
                    maiorValor = arrayTeste[i];
                }
                if (arrayTeste[i] < menorValor)
                {
                    menorValor = arrayTeste[i];
                }
            }
            Console.WriteLine($"O maior valor do array é {maiorValor}");
            Console.WriteLine($"O menor valor do array é {menorValor}");
            Console.ReadLine();
        }
    }
}
