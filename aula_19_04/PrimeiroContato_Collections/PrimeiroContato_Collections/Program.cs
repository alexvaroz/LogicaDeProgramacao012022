using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroContato_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            // Declaração
            List<int> numeros;

            // inicialização
            numeros = new List<int>();

            // Tamanho
            Console.WriteLine(numeros.Count);
            Console.ReadLine();

            // Adicionar elemento
            numeros.Add(4);
            numeros.Add(15);
            numeros.Add(20);
            numeros.Add(3);
            Console.WriteLine(numeros.Count);
            Console.ReadLine();

            Console.WriteLine(numeros.IndexOf(20));
            Console.ReadLine();

            // Inserir elemento em posição
            numeros.Insert(1, 50);
            Console.WriteLine(numeros.Count);
            Console.ReadLine();

            Console.WriteLine(numeros.IndexOf(40));
            Console.ReadLine();



        }
    }
}
