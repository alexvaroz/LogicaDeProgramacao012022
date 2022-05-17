using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6_ImprimirListaStrings_Recursao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cidades = { "Brasília", "São Paulo", "Fortaleza", "Salvador", "Goiânia" };
            ImprimirListaCidades(cidades);
            ImprimirListaCidadesComRecursao(cidades, cidades.Length);
            Console.ReadLine();
        }

        static void ImprimirListaCidades(string[] cidades)
        {
            foreach (var item in cidades)
            {
                Console.WriteLine(item);
            }
        }

        static void ImprimirListaCidadesComRecursao(string[] cidades, int qtdeCidades)
        {
            if (qtdeCidades > 0)
            {
                Console.WriteLine(cidades[qtdeCidades - 1]);
                ImprimirListaCidadesComRecursao(cidades, qtdeCidades - 1);
                qtdeCidades--;
            }
        }
    }
}
