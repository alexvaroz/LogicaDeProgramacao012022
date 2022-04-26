using System;

namespace Lista4_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, maiorNumero, menorNumero, somaNumeros;

            Random rnd = new Random();

            numero = rnd.Next(0, 1001);
            maiorNumero = numero;
            menorNumero = numero;
            somaNumeros = 0;
            for (int i = 0; i < 500; i++)
            {
                if (numero >= maiorNumero)
                {
                    maiorNumero = numero;
                }
                if (numero <= menorNumero)
                {
                    menorNumero = numero;
                }
                somaNumeros += numero;
                numero = rnd.Next(0, 1001);
                Console.WriteLine(i);
            }
            
            Console.WriteLine($"Maior número é {maiorNumero}");
            Console.WriteLine($"Menor número é {menorNumero}");
            Console.WriteLine($"Média dos 500 números é {somaNumeros/500}");
            Console.ReadLine();
        }
    }
}
