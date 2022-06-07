using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3_Polimorfismo
{
    class Produto
    {
        double preco;

        public Produto(double preco_)
        {
            this.preco = preco_;
        }

        public Produto() { }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public virtual String InformarDescricao()
        {
            return "Item da loja";
        }

        public double InformarPreco()
        {
            return 0;
        }
    }
}
