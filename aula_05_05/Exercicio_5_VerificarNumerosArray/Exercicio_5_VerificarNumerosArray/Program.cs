using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5_VerificarNumerosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayPositivo = { 3, 4, 56, 70, 99 };
            int[] arrayComNegativo = { 3, -4, -56, 70, 99 };

            if (ChecarSeTodosNumerosArrayPositivos(arrayComNegativo))
            {
                Console.WriteLine("Todos os números do array são positivos!!");
            } else
            {
                Console.WriteLine("Nem todos os números do array são positivos!!");
            }
            Console.ReadLine();
        }

        static Boolean ChecarSeTodosNumerosArrayPositivos(int[] array)
        {
            Boolean todosPositivos = true;
            foreach (int elemento in array)
            {
                if (elemento < 0)
                {
                    todosPositivos = false;
                }
            }
            return todosPositivos;
        }
    }
}
