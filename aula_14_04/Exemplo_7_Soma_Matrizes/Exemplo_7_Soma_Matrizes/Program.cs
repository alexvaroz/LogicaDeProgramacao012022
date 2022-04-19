using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_7_Soma_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[2, 5];
            int[,] matrizB = new int[2, 5];
            int[,] matrizC = new int[2, 5];

            Random rnd = new Random();

            // Popular as matrizes A e B
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = rnd.Next(50);
                    matrizB[i, j] = rnd.Next(50);
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            // Imprimir a matriz C
            foreach(int item in matrizC)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
