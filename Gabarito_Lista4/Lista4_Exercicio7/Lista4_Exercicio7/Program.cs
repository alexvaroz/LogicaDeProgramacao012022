using System;

namespace Lista4_Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Supondo uma matriz de inteiros 5x8 entre 0 e 1000
            int maiorNumero;
            // Preencher a matriz
            int[,] numeros = new int[5, 8];
            Random rnd = new Random();

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] = rnd.Next(0, 1001);
                }
            }

            // Encontrar o maior elemento
            maiorNumero = numeros[0, 0];
            foreach (int item in numeros)
            {
                if (item >= maiorNumero)
                {
                    maiorNumero = item;
                }
            }
            Console.WriteLine($"O maior número da matriz é {maiorNumero}.");
            Console.ReadLine();
        }
    }
}
