using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma_Alterado
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome;
            int idade;
            float altura;

            Console.WriteLine("Bom dia!!");
            Console.WriteLine("Digite seu primeiro nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura:");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine($"{nome} {sobrenome} tem {idade} anos e mede {altura}m de altura.");
            Console.ReadLine();
        }
    }
}
