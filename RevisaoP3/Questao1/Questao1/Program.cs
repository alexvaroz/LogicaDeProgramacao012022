using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    /* 
      Elabore um método que receba duas notas bimestrais e retorne a informação se o aluno 
      foi aprovado ou não. Nota: Considere aprovado se a média aritmética entre as notas 
      for maior que 5.0.
      */
    class Program
    {
        static void Main(string[] args)
        {
            double notaPrimeiraProva = 6.7;
            double notaSegundaProva = 2.5;
            if (VerificarSeAlunoAprovado(notaPrimeiraProva, notaSegundaProva))
            {
                Console.WriteLine("O aluno foi aprovado!!!");
            } else
            {
                Console.WriteLine("O aluno foi reprovado!!");
            }
            Console.ReadLine();
        }

        static bool VerificarSeAlunoAprovado(double nota1, double nota2)
        {
            double media = (nota1 + nota2) / 2;
            if (media >= 5)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
