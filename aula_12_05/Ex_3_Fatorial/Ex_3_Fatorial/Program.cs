using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularFatorial(5));
            Console.WriteLine(CalcularFatorialComRecursao(5));
            Console.ReadLine();
        }

        static int CalcularFatorial(int numero)
        {
            int resultado = 1;
            for (int i = numero; i > 0 ; i--)
            {
                resultado *= i;
            }
            return resultado;
        }

        static int CalcularFatorialComRecursao(int numero)
        {
            int resultado = 1;
            if (numero == 0)
            {
                return 1;
            } else
            {
                resultado = numero * CalcularFatorialComRecursao(numero - 1);
                return resultado;
            }
        }
    }
}
