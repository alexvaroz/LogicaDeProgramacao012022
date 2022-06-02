using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Nave
    {
        double velocidade;
        double energia;
        string nome;

        public Nave (double velocidade_, double energia_, string nome_)
        {
            velocidade = velocidade_;
            this.energia = energia_;
            nome = nome_;
        }
        public double Velocidade
        {
            get
            {
                return velocidade;
            }
        }

        public double Energia
        {
            get
            {
                return energia;
            }

         
        }

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public void Acelerar()
        {
            velocidade = velocidade + 30;
        }
    }
}
