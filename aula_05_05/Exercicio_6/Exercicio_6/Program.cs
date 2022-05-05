using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            ImprimirSaudacao(Console.ReadLine());
            Console.ReadLine();
        }

        static void ImprimirSaudacao(string nome)
        {
            Console.WriteLine($"Bom dia {nome}!!!!");
        }
    }
}
