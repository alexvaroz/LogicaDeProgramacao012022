using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFatorial_Recursao
{
    /* 
    Desenvolva um método que realize o cálculo do fatorial de um número.
            Primeiro faça de forma iterativa
            Em seguida de forma recursiva
    */

    class Program
    {
        static void Main(string[] args)
        {
            int teste = 10;
            Console.WriteLine(CalcularFatorial(teste));
            Console.WriteLine(CalcularFatorialComRecursao(teste));
            Console.ReadLine();
        }

        static int CalcularFatorial(int num)
        {
            int resultado = 1;
            for (int i = num; i > 0; i--)
            {
                resultado = resultado * i;
            }
            return resultado;
        }

        static int CalcularFatorialComRecursao(int num)
        {
            if (num == 0)
            {
                return 1;
            } else
            {
                return num * CalcularFatorialComRecursao(num - 1);
            }
        }
    }
}
