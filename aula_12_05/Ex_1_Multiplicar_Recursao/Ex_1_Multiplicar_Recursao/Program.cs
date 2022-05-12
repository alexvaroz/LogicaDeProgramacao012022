using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_Multiplicar_Recursao
{
    class Program
    {
        /*
        Desenvolva um método que efetue a multiplicação de dois números m e n, 
        por meio da adição de m, n vezes.
        */
        static void Main(string[] args)
        {
            Console.WriteLine(MultiplicarDoisNumeros(5, 0));
            Console.WriteLine(MultiplicarDoisNumerosRecursao(4, 3));
            Console.ReadLine();
        }

        static int MultiplicarDoisNumeros(int numero1, int numero2)
        {
            int resultado = 0;
            for (int i = 0; i < numero2; i++)
            {
                resultado = resultado + numero1;
            }
            return resultado;
        }

        static int MultiplicarDoisNumerosRecursao(int numero1, int numero2)
        {
            int resultado = 0;
            if (numero2 > 0)
            {
                return numero1 + MultiplicarDoisNumerosRecursao(numero1, numero2 - 1);
            } else
            {
                return resultado;
            }
        }
    }
}
