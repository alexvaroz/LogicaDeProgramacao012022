using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Cubo
    {
        int aresta;
        public Cubo(int aresta)
        {
            this.aresta = aresta;
        }

        public int Aresta
        {
            get
            {
                return aresta;
            }
        }

        public int RetornarVolume()
        {
            return aresta * aresta * aresta;
        }
    }
}
