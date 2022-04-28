using System;

namespace Lista4_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float notaPrimeiroBimestre, notaSegundoBimestre;
            const float mediaParaAprovacao = 5.0f;

            Console.WriteLine("Informe a nota do primeiro bimestre:");
            notaPrimeiroBimestre = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota do segundo bimestre:");
            notaSegundoBimestre = float.Parse(Console.ReadLine());
            if ((notaPrimeiroBimestre + notaSegundoBimestre)/2 >= mediaParaAprovacao)
            {
                Console.WriteLine("O Aluno está aprovado!!!");
            } else
            {
                Console.WriteLine("O Aluno está reprovado...");
            }
            Console.ReadLine();
        }
    }
}
