using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1_IdadeEleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia!!");
            Console.WriteLine("Digite o ano do seu nascimento:");
            var anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano da eleição a ser consultada:");
            var anoEleicao = int.Parse(Console.ReadLine());

            if (anoEleicao - anoNascimento >= 16)
            {
                Console.WriteLine("Você poderá votar!!!");
            } else
            {
                Console.WriteLine("Você não poderá votar!!!");
            }
            Console.ReadLine();
          }
    }
}
