using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class TesteCubo
    {
        static void Main()
        {
            Cubo cuboMagico = new Cubo(7);
            Console.WriteLine($"O volume do cubo de aresta {cuboMagico.Aresta} é {cuboMagico.RetornarVolume()}");
            Console.ReadLine();
        }
    }
}
