using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Nave naveBob = new Nave(30, 50, "Nave do Bob Nelson");
           

            Console.WriteLine($"A nave {naveBob.Nome} está com velocidade {naveBob.Velocidade} e energia {naveBob.Energia}");
            naveBob.Acelerar();
   
            Console.ReadLine();
            
        }
    }
}
