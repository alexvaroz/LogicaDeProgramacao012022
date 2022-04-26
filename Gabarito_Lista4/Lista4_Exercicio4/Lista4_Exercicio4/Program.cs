using System;

namespace Lista4_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numCasas, casa, qtdeCasaGraos, somaGraos;

            numCasas = 8 * 8;
            qtdeCasaGraos = 1;
            somaGraos = 1;
            casa = 1;
            for (casa = 2; casa <= numCasas; casa++)
            {
                qtdeCasaGraos = qtdeCasaGraos * 2;
                somaGraos += qtdeCasaGraos;
            }
            Console.WriteLine($"O monge deve receber {somaGraos} grãos");
            Console.ReadLine();
        }
    }
}
