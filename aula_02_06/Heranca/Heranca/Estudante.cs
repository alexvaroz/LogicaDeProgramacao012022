using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Estudante : Humano
    {
        double nota;
        public Estudante(string primeiroNome, string ultimoNome) :
            base(primeiroNome, ultimoNome)
        {

        }

        public Estudante(string primeiroNome, string ultimoNome, double nota_) :
            base(primeiroNome, ultimoNome)
        {
            nota = nota_;
        }
        public double Nota
        {
            get
            {
                return nota;
            }
          
        }
    }
}
