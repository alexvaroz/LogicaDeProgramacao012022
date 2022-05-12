using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_Recursao
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase = "Tenho que estudar programação!!!";
            ImprimirFraseQtdeVezesRecursao(frase, 4);
            Console.ReadLine();
        }

        static void ImprimirFraseQtdeVezes(String frase, int qtdeVezes)
        {
            for (int i = 0; i < qtdeVezes; i++)
            {
                Console.WriteLine(frase);
            }
        }
        
        static void ImprimirFraseQtdeVezesRecursao(String frase, int qtdeVezes)
        {
            if (qtdeVezes > 0)
            {
                Console.WriteLine(frase);
                ImprimirFraseQtdeVezesRecursao(frase, qtdeVezes - 1);
            }
        }
    }
}
