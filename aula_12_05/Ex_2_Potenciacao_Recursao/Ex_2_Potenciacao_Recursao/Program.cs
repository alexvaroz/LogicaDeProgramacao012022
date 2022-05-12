using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_Potenciacao_Recursao
{
    class Program
    {
        /*
        Desenvolva um método que efetue a operação de potenciação entre dois 
        números sem utilizar funções específicas.
        */
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularPotencia(5, 3));
            Console.WriteLine(CalcularPotenciaComRecursao(5, 3));
            Console.ReadLine();
        }

        static int CalcularPotencia(int numBase, int expoente)
        {
            int resultado = 1;
            for (int i = 0; i < expoente; i++)
            {
                resultado *= numBase;
            }
            return resultado;
        }

        static int CalcularPotenciaComRecursao(int numBase, int expoente)
        {
            int resultado = 1;
            if (expoente > 0)
            {
                return numBase * CalcularPotenciaComRecursao(numBase, expoente - 1);
            } else
            {
                return resultado;
            }
        }
    }
}
