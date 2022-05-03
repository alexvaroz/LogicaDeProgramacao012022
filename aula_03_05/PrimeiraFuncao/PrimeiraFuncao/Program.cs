using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraFuncao
{
    class Program
    {
        static int SomarDoisNumeros(int num1, int num2)
        {
            return num1 + num2;
        }

        static double SomarDoisNumeros(double num1, double num2)
        {
            return num1 + num2;
        }

        static int MultiplicarDoisNumeros(int num1, int num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois números:");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            int produto = MultiplicarDoisNumeros(numero1, numero2);

            Console.WriteLine($"A multiplicação entre os números {numero1} e {numero2} é {produto}");
            Console.ReadLine(); 
        }

     


    }
}
