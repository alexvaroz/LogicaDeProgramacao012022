using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Bob Nelson";
            var sobrenome = "Testador";
            int idade = 57;
            float altura = 1.76f;

            // primeira forma de apresentar textos
            Console.WriteLine(nome + " " +sobrenome + " tem " + idade + 
                " anos e mede " + altura + "m de altura." );
            Console.ReadLine();

            // segunda forma de apresentar textos
            Console.WriteLine("{0} {1} tem {2} anos e mede {3}m de altura.", 
                nome, sobrenome, idade, altura);
            Console.ReadLine();

            // terceira forma de apresentar textos (a melhor!!! Na minha opinião...)
            Console.WriteLine($"{nome} {sobrenome} tem {idade} anos e mede {altura}m de altura.");
            Console.ReadLine();
        }
    }
}
