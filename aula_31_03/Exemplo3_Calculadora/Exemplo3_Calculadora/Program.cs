using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            String operacao;
            const string operadorSoma = "+";
            const string operadorSubtracao = "-";
            const string operadorProduto = "*";
            const string operadorDivisao = "/";

            Console.WriteLine("Digite o primeiro número:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o símbolo da operação que deseja realizar:");
            operacao = Console.ReadLine();
            switch (operacao)
            {
                case operadorSoma:
                    Console.WriteLine($"A soma entre {numero1} e {numero2} é {numero1 + numero2}");
                    break;
                case operadorSubtracao:
                    Console.WriteLine($"A subtração entre {numero1} e {numero2} é {numero1 - numero2}");
                    break;
                case operadorProduto:
                    Console.WriteLine($"O produto entre {numero1} e {numero2} é {numero1 * numero2}");
                    break;
                case operadorDivisao:
                    Console.WriteLine($"A divisão entre {numero1} e {numero2} é {numero1 / numero2}");
                    break;
                default:
                    Console.WriteLine("A operação não foi identificada");
                    break;
            }
            Console.ReadLine();


        }
    }
}
