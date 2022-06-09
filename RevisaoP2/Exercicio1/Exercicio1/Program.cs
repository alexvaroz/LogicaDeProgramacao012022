using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        /*
        Desenvolva um método que ao receber um valor inteiro, informe ao usuário se o 
        número é ou não múltiplo de 3.
        */

        static void Main(string[] args)
        {
            int numeroTeste = -6745321;
            if (SeNumeroMultiploTres(numeroTeste))
            {
                Console.WriteLine($"{numeroTeste} é múltiplo de 3");
            } else
            {
                Console.WriteLine($"{numeroTeste} não é múltiplo de 3");
            }
            Console.ReadLine();
        }

        static bool SeNumeroMultiploTres(int numero)
        {
            if (numero%3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
