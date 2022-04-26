using System;

namespace Lista3_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Um posto está vendendo combustíveis com a seguinte tabela de descontos:
                Álcool      até 20 litros, desconto de 3 % por litro
                            acima de 20 litros, desconto de 5 % por litro
                Gasolina    até 20 litros, desconto de 4 % por litro
                            acima de 20 litros, desconto de 6 % por litro
                Escreva um programa em C# que leia o número de litros vendidos e o tipo de 
                combustível (codificado da seguinte forma: A-álcool, G-gasolina), calcule e 
                imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina 
                é R$ 3,30 e o preço do litro do álcool é R$ 2,90.*/

            double qtdeCombustivel, valorPago;
            char tipoCombustivel;
            double valorGasolina = 3.30;
            double valorAlcool = 2.90;
            valorPago = 0;

            Console.WriteLine("Informe as quantidade de combustível abastecida:");
            qtdeCombustivel = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 'A' para Álcool ou 'G' para Gasolina:");
            tipoCombustivel = char.Parse(Console.ReadLine());


            switch (tipoCombustivel)
            {
                case 'A':
                    if (qtdeCombustivel > 20)
                    {
                        valorPago = qtdeCombustivel * valorGasolina * 0.95;
                    }
                    else
                    {
                        valorPago = qtdeCombustivel * valorGasolina * 0.97;
                    }
                    break;
                case 'B':
                    if (qtdeCombustivel > 20)
                    {
                        valorPago = qtdeCombustivel * valorAlcool * 0.94;
                    }
                    else
                    {
                        valorPago = qtdeCombustivel * valorAlcool * 0.96;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo de combustível não identificado.");
                    break;
            }

            Console.WriteLine($"O valor a ser pago é de {valorPago.ToString("c")}");
            Console.ReadLine();
        }
    }
}
