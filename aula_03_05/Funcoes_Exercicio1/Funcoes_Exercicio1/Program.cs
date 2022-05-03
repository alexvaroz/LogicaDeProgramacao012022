using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes_Exercicio1
{
    class Program
    {
        static void ImprimirNomeCurso()
        {
            Console.WriteLine("Jogos Digitais");
        }

        static String InformarNomeCurso()
        {
            return "Jogos Digitais";
        }
        static void Main(string[] args)
        {
            ImprimirNomeCurso();
            Console.WriteLine(InformarNomeCurso());
            Console.ReadLine();
        }
    }
}
