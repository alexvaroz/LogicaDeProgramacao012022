using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Humano
    {
        protected string primeiroNome;
        protected string ultimoNome;

        public Humano(string primeiroNome_, string ultimoNome_)
        {
            primeiroNome = primeiroNome_;
            ultimoNome = ultimoNome_;
        }

        public string PrimeiroNome
        {
            get
            {
                return primeiroNome;
            }
       
        }

        public string UltimoNome
        {
            get
            {
                return ultimoNome;
            }
        }

        public string RetornarNomeCompleto()
        {
            return primeiroNome + " " + ultimoNome;
        }
    }
}
