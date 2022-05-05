using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8_UltimoAlgarismoExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RetornarUltimoAlgarismoVersao2(5478968));
            Console.ReadLine();
        }

        static string RetornarUltimoAlgarismoVersao2(int numero)
        {
            int ultimoAlgarismo = numero % 10;
            string[] numerosPorExtenso = { "zero", "um","dois","três",
                "quatro", "cinco", "seis", "sete", "oito", "nove" };

            return numerosPorExtenso[ultimoAlgarismo];

        }
        static string RetornarUltimoAlgarismo(int numero)
        {
           int ultimoAlgarismo = numero % 10;
           string algarismoExtenso = "";
           switch (ultimoAlgarismo)
            {
                case (0):
                    algarismoExtenso = "zero";
                    break;
                case (1):
                    algarismoExtenso = "um";
                    break;
                case (2):
                    algarismoExtenso = "dois";
                    break;
                case (3):
                    algarismoExtenso = "três";
                    break;
                case (4):
                    algarismoExtenso = "quatro";
                    break;
                case (5):
                    algarismoExtenso = "cinco";
                    break;
                case (6):
                    algarismoExtenso = "seis";
                    break;
                case (7):
                    algarismoExtenso = "sete";
                    break;
                case (8):
                    algarismoExtenso = "oito";
                    break;
                case (9):
                    algarismoExtenso = "nove";
                    break;
            }
            return algarismoExtenso;
        }
    }
}
