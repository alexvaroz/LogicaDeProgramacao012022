using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Exercicio3
{
    class Carro
    {
        public string cor;
        public int anoFabricacao;
        public string modelo;
        public float velocidadaAtual;
        public float velocidadeMaxima;
        public Boolean estahLigado;

        public Carro(string cor_, int anoFabricacao_, string modelo_, 
            float velocidadeMaxima_)
        {
            cor = cor_;
            anoFabricacao = anoFabricacao_;
            modelo = modelo_;
            velocidadaAtual = 0;
            velocidadeMaxima = velocidadeMaxima_;
            estahLigado = false;
        }
        public Carro() { }

        public void Ligar()
        {
            if (estahLigado)
            {
                Console.WriteLine("O carro já está ligado...");
            } else
            {
                estahLigado = true;
                Console.WriteLine("Carro foi ligado...");
            }
        }

        public void Desligar()
        {
            if (estahLigado)
            {
                estahLigado = false;
                Console.WriteLine("Carro foi desligado...");
            } else
            {
                Console.WriteLine("O carro já está desligado...");
            }
        }

        public void Acelerar()
        {
            if (estahLigado)
            {
                if (velocidadaAtual + 30 > velocidadeMaxima)
                {
                    velocidadaAtual = velocidadeMaxima;
                } else
                {
                    velocidadaAtual += 30;
                }                
            } else
            {
                Console.WriteLine("O carro está desligado... Não é possível acelerar...");
            }
        }

        public void Frear()
        {
            if (estahLigado)
            {
                if (velocidadaAtual == 0)
                {
                    Console.WriteLine("O carro já está parado");
                }
                else
                {
                    if (velocidadaAtual - 30 < 0)
                    {
                        velocidadaAtual = 0;
                    }
                    else
                    {
                        velocidadaAtual -= 30;
                    }
                }
            }
            else
            {
                Console.WriteLine("O carro está deligado...");
            }
            }
        }
    }

