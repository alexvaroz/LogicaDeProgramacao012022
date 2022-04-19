using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_10_Limpar_Lista_Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gerar lista de 50 números inteiros aleatórios entre -100 e 100
            Random rnd = new Random();
            List<int> numerosAleatorios = new List<int>();
            List<int> numerosPositivos = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                numerosAleatorios.Add(rnd.Next(-100, 100));
            }

            // Imprimindo a lista criada
            foreach (var item in numerosAleatorios)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // Limpar a lista dos números negativos
            for (int i = 0; i < numerosAleatorios.Count; i++)
            {
                if (numerosAleatorios[i] >= 0)
                {
                    numerosPositivos.Add(numerosAleatorios[i]);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Lista de números positivos");
            foreach (var item in numerosPositivos)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
