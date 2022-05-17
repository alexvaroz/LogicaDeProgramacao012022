using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7_ContarAlgarismosNumero_Recursao
{
    class Program
    {
        /*
        Desenvolva um método que conte o número de algarismos de um número inteiro.
            Primeiro faça de forma iterativa
            Em seguida de forma recursiva
        */
        static void Main(string[] args)
        {
            int teste = 10;
            Console.WriteLine(ContarQuantidadeAlgarismosEmNumero(teste));
            Console.WriteLine(ContarQuantidadeAlgarismosEmNumeroRecursao(teste));
            Console.ReadLine();
        }

        static int ContarQuantidadeAlgarismosEmNumero(int numero)
        {
            int quantidadeAlgarismos = 1;
            while (numero/10 > 0)
            {
                quantidadeAlgarismos++;
                numero = numero / 10;
            }
            return quantidadeAlgarismos;
        }

        static int ContarQuantidadeAlgarismosEmNumeroRecursao(int numero)
        {
            // Caso base ou trivial
            if (numero/10 == 0)
            {
                return 1;
            } else
            {
                return 1 + ContarQuantidadeAlgarismosEmNumeroRecursao(numero / 10);
            }
        }
    }
}
