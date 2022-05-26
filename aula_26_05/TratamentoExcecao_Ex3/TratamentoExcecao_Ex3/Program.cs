using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecao_Ex3
{
    /*
    Escreva um método LerNumeroIntervalo(int inicio, int fim) que receba um 
    número inserido pelo usuário. Caso o número informado não seja válido  ou 
    não esteja dentro do intervalo, o método deve lançar uma exceção apropriada.
    */
    class Program
    {
        static void Main(string[] args)
        {
            LerNumeroIntervalo(1, 100);
            Console.ReadLine();
        }

        static void LerNumeroIntervalo(int limiteInferior, int limiteSuperior)
        {
            try
            {
                Console.WriteLine("Digite um número:");
                int numeroInserido = int.Parse(Console.ReadLine());
                if (numeroInserido > limiteInferior && numeroInserido < limiteSuperior)
                {
                    Console.WriteLine("Número correto!!");
                } else
                {
                    throw new OutofRangeException("Número fora do intervalo");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Usuário não digitou um número");
            }
            catch (OutofRangeException ore)
            {
                Console.WriteLine(ore.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        }
    }

