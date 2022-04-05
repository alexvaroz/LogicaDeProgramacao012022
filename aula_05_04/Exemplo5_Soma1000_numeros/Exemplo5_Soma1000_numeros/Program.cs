using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5_Soma1000_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
