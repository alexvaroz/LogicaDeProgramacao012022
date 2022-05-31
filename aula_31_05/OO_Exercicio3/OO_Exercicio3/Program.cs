using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Prata",2010,"Fox", 160);
            meuCarro.Desligar();
            meuCarro.Ligar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Acelerar();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Frear();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Frear();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Frear();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Frear();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Frear();
            Console.WriteLine(meuCarro.velocidadaAtual);
            meuCarro.Frear();
            Console.WriteLine(meuCarro.velocidadaAtual);
            Console.ReadLine();
            
        }
    }
}
