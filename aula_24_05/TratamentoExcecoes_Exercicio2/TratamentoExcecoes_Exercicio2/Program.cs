using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes_Exercicio2
{
    /*
    Criar um método que efetue o cálculo da raiz quadrada de um número inteiro 
    fornecido pelo usuário. Caso seja digitado um número negativo, apresentar 
    a mensagem: ‘Número inválido’. Sempre o programa deve finalizar com uma 
    mensagem informando a finalização: ‘Execução finalizada!’.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número:");
            try {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"A raiz quadrada de {num} "
                    + $"é {CalcularRaizQuadradaNumero(num)}");
            } catch (NegativeNumberException)
            {
                Console.WriteLine("Não foi possível efetuar a operação");
            } finally
            {
                Console.WriteLine("Operação finalizada");
            }
            Console.ReadLine();

        }

        static double CalcularRaizQuadradaNumero(int num)
        {
            if(num < 0)
            {
                throw new NegativeNumberException();
            }
            return Math.Sqrt(num);
        }
    }
}
