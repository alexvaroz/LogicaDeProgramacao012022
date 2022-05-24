using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroTratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 36;
            int num2 = 0;

            Console.WriteLine(DividirDoisNumeros(num1, num2));
            Console.ReadLine();
        }

        static double DividirDoisNumeros(int dividendo, int divisor)
        {
            try {
                return dividendo / divisor;
            } catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Não foi possível efetuar a operação");
                return 0;
            }
        }
    }
}
