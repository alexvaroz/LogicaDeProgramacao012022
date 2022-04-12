using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_4_MaiorMenor_ValorArrayRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração e Alocação
            int[] numeros = new int[10];

            int maiorValor, menorValor;

            Random rnd = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(100);
                Console.WriteLine(numeros[i]);
            }
            maiorValor = numeros[0];
            menorValor = numeros[0];

            foreach (var numero in numeros)
            {
                if (numero > maiorValor) {
                    maiorValor = numero;
                }
                if (numero < menorValor)
                {
                    menorValor = numero;
                }
            }
            Console.WriteLine($"O maior valor é {maiorValor}");
            Console.WriteLine($"O menor valor é {menorValor}");
            Console.ReadLine();
        }
    }
}
