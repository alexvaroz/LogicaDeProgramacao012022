using System;

namespace Lista3_Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeTotalDias, quantidadeAnos, quantidadeMeses, quantidadeDias;
            Console.WriteLine("Digite sua idade em dias:");

            quantidadeTotalDias = int.Parse(Console.ReadLine());

            quantidadeAnos = quantidadeTotalDias / 365;
            int quantidadeRestante = quantidadeTotalDias % 365;
            quantidadeMeses = quantidadeRestante / 30;
            quantidadeDias = quantidadeRestante % 30;

            Console.WriteLine($"{quantidadeAnos} anos, {quantidadeMeses} meses e {quantidadeDias} dias.");
            Console.ReadLine();

        }
    }
}
