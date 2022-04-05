using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2_CalculaBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoEmpresa;
            float salario, bonus;
            var bonificacaoParaMais5anos = 0.2f;
            var bonificacaoParaMenos5anos = 0.1f;

            Console.WriteLine("Informe quantos anos você está na empresa:");
            tempoEmpresa = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o seu salário atual:");
            salario = float.Parse(Console.ReadLine());
            if (tempoEmpresa >= 5)
            {
                bonus = salario * bonificacaoParaMais5anos;
            } else
            {
                bonus = salario * bonificacaoParaMenos5anos;
            }
            Console.WriteLine($"Você recebrá um bônus de R$ {bonus}");
            Console.ReadLine();
        }
    }
}
