using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_5_CalcularMediaNotas_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            double somaNotas = 0;
            Console.WriteLine("Bom dia!!!");
            Console.WriteLine("Insira as 5 notas da disciplina:");
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pressione qualquer tecla para continuas...");
            Console.ReadLine();
            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
                somaNotas = somaNotas + nota;
            }
            Console.WriteLine($"A média das notas é {somaNotas / 5}");
            Console.ReadLine();
        }
    }
}
