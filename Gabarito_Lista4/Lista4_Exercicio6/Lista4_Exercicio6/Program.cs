using System;

namespace Lista4_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numerosRecebidos = new int[5];
            int somaNumeros = 0;

            Console.WriteLine("Informe 5 números inteiros:");
            for (int i = 0; i < numerosRecebidos.Length; i++)
            {
                numerosRecebidos[i] = int.Parse(Console.ReadLine());
                somaNumeros += numerosRecebidos[i];
            }

            Console.WriteLine($"A soma dos 5 números digitados é {somaNumeros}");
            Console.ReadLine();
        }
    }
}
