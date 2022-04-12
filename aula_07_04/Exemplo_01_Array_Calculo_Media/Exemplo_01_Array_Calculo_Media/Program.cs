using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01_Array_Calculo_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeira versão: sem utilizar array
            int numero1, numero2, numero3, numero4, numero5;
            float media;

            Console.WriteLine("Bom dia!!!");
            Console.WriteLine("Informe 5 números:");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());
            numero4 = int.Parse(Console.ReadLine());
            numero5 = int.Parse(Console.ReadLine());
            media = (float) (numero1 + numero2 + numero3 + numero4 + numero5) / 5;
            Console.WriteLine($"A média entre os números informados é: {media}");
            Console.ReadLine();

            // Usando Array
            //Declaração
            int[] numeros;
            //Alocação
            numeros = new int[5];
            //Incialização
            Console.WriteLine("Informe mais 5 números:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            foreach (int elemento in numeros)
            {
                soma += elemento;
            }
            media = (float) soma / 5;
            Console.WriteLine($"A média entre os números informados é: {media}");
            Console.ReadLine();

        }
    }
}
