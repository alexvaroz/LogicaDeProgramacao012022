using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    /* Elabore um  programa em C# que  imprima os números de 1 a 200 e a  cada  múltiplo de 3 ou 5 
    emita a  mensagem: "Número oculto”. */

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 201; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("Número oculto!!");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
