using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_InverterNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RetornarNumeroInvertido(2222));
            Console.ReadLine();
        }

        static int RetornarNumeroInvertido(int numero)
        {
            int digito = 0;
            int quociente = 0;
            int numeroInvertido = 0;           
            do
            {
                digito = numero % 10;
                quociente = numero / 10;
                numeroInvertido = numeroInvertido * 10 + digito;
                numero = quociente;        
            } while (quociente > 0);
            return numeroInvertido;
        }
    }
}
