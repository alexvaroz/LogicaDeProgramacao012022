using System;

namespace Lista3_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroCarrosVendidos;
            float salarioFixo, comissaoPorCarro, valorVendas, salarioFinal;
            const float taxaGanhoVendas = 0.05f;

            Console.WriteLine("Informe o salário fixo do funcionario:");
            salarioFixo = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de carros vendidos:");
            numeroCarrosVendidos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor total das vendas:");
            valorVendas = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da comissao por carro vendido:");
            comissaoPorCarro = float.Parse(Console.ReadLine());
            salarioFinal = 
                salarioFixo + numeroCarrosVendidos * comissaoPorCarro + 
                taxaGanhoVendas * valorVendas;
            Console.WriteLine($"O salário final do mês é {salarioFinal.ToString("c")}");
            Console.ReadLine();
        }
    }
}
