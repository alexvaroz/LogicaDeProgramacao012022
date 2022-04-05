using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo4_ImprimirIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando o "for"
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            // Usando o "while"
            int numero = 1; 
            while (numero <= 10)
            {
                Console.WriteLine(numero);
                numero++;
            }
            Console.ReadLine();

            // Usando o "do while"
            numero = 1;
            do
            {
                Console.WriteLine(numero);
                numero++;
            } while (numero<=10);
            Console.ReadLine();
        }
    }
}
