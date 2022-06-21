using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_DiagonalMatriz_Prova
{
    class Program
    {
        /*
        Implementar um método que receba uma matriz QUADRADA e retorne a soma da sua diagonal 
        principal. Caso a matriz informada pelo usuário não seja quadrada, o método deve lançar 
        uma exceção criada especificamente para esse caso. P.S. A classe da exceção solicitada 
        também deverá constar na resposta.
        */

        static void Main(string[] args)
        {
            int[,] matrizQuadradaTeste = { { 3, 4, 5 }, { -1, 9, 2 }, { 12, 5, 19 } };
            int[,] matrizNaoQuadradaTeste = { { 3, 4, 5 }, { -1, 9, 2 }, { 12, 5, 19 }, { 12, 6, 7 } };
            try {
                Console.WriteLine(SomarDiagonalPrincipal(matrizNaoQuadradaTeste));
            } catch (MatrizQuadradaException mqe)
            {
                Console.WriteLine("Matriz não é quadrada");
            }
            Console.ReadLine();
        }

        static int SomarDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;

            if (matriz.GetLength(0) != matriz.GetLength(1))
            {
                throw new MatrizQuadradaException();
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
               soma = soma + matriz[i, i];
            }
            return soma;
        }
    }
}
