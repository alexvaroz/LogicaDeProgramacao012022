using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7_ObterMaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 3 números:");
            int num1, num2, num3, maiorValor;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num3 > ObterMaiorValor(num1, num2))
            {
                maiorValor = num3;
            } else
            {
                maiorValor = ObterMaiorValor(num1, num2);
            }

            // Forma mais enxuta
            int maiorValor2 = ObterMaiorValor(num3, ObterMaiorValor(num1, num2));

            Console.WriteLine($"O maior valor digitado é {maiorValor}");
            Console.WriteLine($"O maior valor digitado é {maiorValor2}");
            Console.ReadLine();
        }

        static int ObterMaiorValor(int numero1, int numero2)
        {
            if (numero1 >= numero2)
            {
                return numero1;
            } else
            {
                return numero2;
            }
        }
    }
}
