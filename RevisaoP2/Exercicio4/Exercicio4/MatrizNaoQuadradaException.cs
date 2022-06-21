using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class MatrizNaoQuadradaException : ApplicationException
    {
        public string mensagem = "Violação. A matriz não é quadrada.";
        public MatrizNaoQuadradaException()
        {
            
        }
    }
}
