using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes_Exercicio1
{
    /* 
    Em um programa que receba números inteiros, faça a sua validação através do 
    tratamento de uma exceção. Caso não seja inteiro continuar pedindo a 
    introdução do valor inteiro.
    */
    class Program
    {
        static void Main(string[] args)
        {
            ReceberDoisNumeros();
            Console.ReadLine();
        }

        static void ReceberDoisNumeros()
        {
            int num1, num2;
            Console.WriteLine("Informe 2 números inteiros:");
            try
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Os números informados foram {num1} e {num2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Não foram informados números inteiros");
                Console.WriteLine("Por favor repita a operação...");
                ReceberDoisNumeros();
            }
        }
    }
}
