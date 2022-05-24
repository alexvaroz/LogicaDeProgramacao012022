using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamentoexcecoes_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            try
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = i;
                }
                for (int i = 0; i <= numeros.Length; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            catch (IndexOutOfRangeException) { }

            Console.ReadLine();
        }
    }
}
