using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3_Polimorfismo
{
    class JogoDigital:Produto
    {
        string console;
        string titulo;

        public JogoDigital(string console, string titulo, double preco):base(preco)
        {
            this.console = console;
            this.titulo = titulo;
        }

        public string Console { get; }
        public string Titulo { get; }

        public override string InformarDescricao()
        {
            return $"{titulo} para {console}";
        }
    }
}
