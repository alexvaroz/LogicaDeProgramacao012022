using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_7_Quantidade_Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorSacado, valorRestante;
            int qtde_cedula_100, qtde_cedula_50, qtde_cedula_20,
                qtde_cedula_10, qtde_cedula_5, qtde_cedula_2,
                qtde_cedula_1;
            Console.WriteLine("Bom dia!!!");
            Console.WriteLine("Digite o valor a ser sacado:");
            valorSacado = int.Parse(Console.ReadLine());
            qtde_cedula_100 = valorSacado / 100;
            valorRestante = valorSacado % 100;
            qtde_cedula_50 = (valorRestante) / 50;
            valorRestante = valorRestante % 50;
            qtde_cedula_20 = (valorRestante) / 20;
            valorRestante = valorRestante % 20;
            qtde_cedula_10 = (valorRestante) / 10;
            valorRestante = valorRestante % 10;
            qtde_cedula_5 = (valorRestante) / 5;
            valorRestante = valorRestante % 5;
            qtde_cedula_2 = (valorRestante) / 2;
            valorRestante = valorRestante % 2;
            qtde_cedula_1 = valorRestante;
            Console.WriteLine("Serão entregues:");
            Console.WriteLine($"{qtde_cedula_100} nota(s) de R$100");
            Console.WriteLine($"{qtde_cedula_50} nota(s) de R$50");
            Console.WriteLine($"{qtde_cedula_20} nota(s) de R$20");
            Console.WriteLine($"{qtde_cedula_10} nota(s) de R$10");
            Console.WriteLine($"{qtde_cedula_5} nota(s) de R$5");
            Console.WriteLine($"{qtde_cedula_2} nota(s) de R$2");
            Console.WriteLine($"{qtde_cedula_1} nota(s) de R$1");
            Console.ReadLine();
        }
    }
}
