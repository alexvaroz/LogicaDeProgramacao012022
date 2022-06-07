using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3_Polimorfismo
{
    class Livro : Produto
    {
        string autor;
        string titulo;

        public Livro(string autor, string titulo, double preco):base(preco)
        {
            this.autor = autor;
            this.titulo = titulo;
        }

        public string Autor
        {
            get
            {
                return autor;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
        }

        
        public override string InformarDescricao()
        {
            return $"{titulo} de {autor}";
        }
    }
}
