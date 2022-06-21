using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        /*
        Desenvolva um método que receba uma matriz e retorne se ela é quadrada ou não. 
        Se não for quadrada, deve ser lançada uma exceção específica criada para isso.
        */

        static void Main(string[] args)
        {
            string[,] timesFutebol = { { "Flamengo", "Vasco", "Botafogo" },
                { "São Paulo", "Santos", "Palmeiras" } };
            try
            {
                Console.WriteLine(VerificarSeMatrizQuadrada(timesFutebol));
            }
            catch (MatrizNaoQuadradaException e)
            {
                Console.WriteLine(e.mensagem);
            }
            Console.ReadLine();
        }

        static bool VerificarSeMatrizQuadrada(object[,] matriz)
        {
            if (matriz.GetLength(0) == matriz.GetLength(1))
            {
                return true;
            }
            else
            {
                throw new MatrizNaoQuadradaException();               
            }
        }
    }
}
