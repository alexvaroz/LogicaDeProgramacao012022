using System;

namespace Lista3_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2;
            Console.WriteLine("Informe as duas notas bimestrais do aluno:");
            nota1 = float.Parse(Console.ReadLine());
            nota2 = float.Parse(Console.ReadLine());
            if ((nota1 + nota2) / 2 >= 5)
            {
                Console.WriteLine("O aluno foi aprovado!!!");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado!!!");
            }
            Console.ReadLine();
        }
    }
}
