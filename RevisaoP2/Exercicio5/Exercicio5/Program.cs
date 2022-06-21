using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        /*
            Desenvolva um método que receba uma matriz e retorne a soma dos números 
            múltiplos de 3 que existirem.
        */

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrizTeste = new int[10,10];

            for (int i = 0; i < matrizTeste.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTeste.GetLength(1); j++)
                {
                    matrizTeste[i, j] = rnd.Next(0, 1000);
                }
            }
            Console.WriteLine(RetornarSomaMultiplosTres(matrizTeste));
            Console.ReadLine();
        }

        static int RetornarSomaMultiplosTres(int[,] matriz)
        {
            int somaValores = 0;
            foreach(int item in matriz)
            {
                if (item%3 == 0)
                {
                    somaValores = somaValores + item;
                }
            }
            return somaValores;
        }
    }
}
