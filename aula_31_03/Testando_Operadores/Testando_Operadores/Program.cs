
using System;

namespace Testando_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar
            int numero;
            // inicializar
            numero = 5;
            // utilizar 
            numero += 6;

            numero++; // numero +=1  numero = numero + 1
            numero++;

            var nome = "Bob";
            var sobrenome = " Nelson";

            var nomeCompleto = nome + sobrenome;

            int idade = 17;

            if (idade>=16 && idade<=18)
            {
                Console.WriteLine("Você não é obrigado a votar!!!");
            } else if (idade<16)
            {
                Console.WriteLine("Você não pode votar!!");
            } else
            {
                Console.WriteLine("Você é obrigado a votar!!");
            }

            Console.WriteLine(idade > 16);
            Console.ReadLine();

        }
    }
}
