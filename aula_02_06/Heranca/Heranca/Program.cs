using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante estudante = new Estudante("Bob", "Nelson" );
           
            Console.WriteLine(estudante.RetornarNomeCompleto());
            Console.ReadLine();
            
        }
    }
}
