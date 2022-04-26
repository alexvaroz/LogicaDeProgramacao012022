using System;

namespace Lista3_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBase, numPotencia, resultado;
            Console.WriteLine("Informe o valor da base e da potência: ");
            numBase = int.Parse(Console.ReadLine());
            numPotencia = int.Parse(Console.ReadLine());

            resultado = 1;

            if (numPotencia == 0)
            {
                resultado = 1;
            }
            else
            {
                for (int i = 1; i <= numPotencia; i++)
                {
                    resultado = resultado * numBase;
                }
            }
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
