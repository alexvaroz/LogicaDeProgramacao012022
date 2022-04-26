using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    /*Uma rainha  requisitou os serviços de um monge e disse-lhe que pagaria qualquer  preço.O monge, 
    necessitando de alimentos, indagou à rainha  sobre o pagamento,  se poderia  ser feito  com grãos
    de trigo dispostos em  um tabuleiro de xadrez, de  tal forma que o primeiro quadro deveria conter
    apenas um  grão e os quadros subsequentes ,  o dobro do quadro anterior.
    A  rainha achou o trabalho barato e pediu que o serviço  fosse executado, sem se dar conta de 
    que  seria impossível  efetuar o pagamento.Elabore um  programa em C# para  calcular  o número 
    de grãos  que o  monge esperava  receber. 
    (P.S. um tabuleiro de xadrez possui 8 linhas e 8 colunas).*/

    class Program
    {
        static void Main(string[] args)
        {
            ulong qtdeGraosPorCasa, somaQtdeGraos, qtdeCasas, numeroCasa;
            qtdeCasas = 8 * 8;
            qtdeGraosPorCasa = 1;
            somaQtdeGraos = 1;
            numeroCasa = 1;

            for (numeroCasa = 2; numeroCasa <= qtdeCasas; numeroCasa++)
            {
                qtdeGraosPorCasa = qtdeGraosPorCasa * 2;
                somaQtdeGraos = somaQtdeGraos + qtdeGraosPorCasa;
            }

            Console.WriteLine($"A quantidade total de grãos é {somaQtdeGraos}");
            Console.ReadLine();

        }
    }
}
