using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Funcoes
{
    /* Criar um método que receba dois números inteiros como argumento 
    e imprima o maior deles. */

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;
            ImprimirMaiorNumero(num1, num2);
            Console.WriteLine($"O maior número entre {num1} e {num2} é "+
                $"{RetornarMaiorNumero(num1, num2)}");
            Console.ReadLine(); 
        }

        static void ImprimirMaiorNumero(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1);
            } else
            {
                Console.WriteLine(numero2);
            }
        }

        static int RetornarMaiorNumero(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            } else
            {
                return num2;
            }
        } 
    }
}
