using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_02_Array_DiasDaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] diasDaSemana = { "Domingo", "Segunda", "Terça", "Quarta",
                "Quinta", "Sexta", "Sábado"};

            Console.WriteLine("Os dias da semana são:");
            foreach (var dia in diasDaSemana)
            {
                Console.WriteLine(dia);
            }
            Console.ReadLine();
        }
    }
}
