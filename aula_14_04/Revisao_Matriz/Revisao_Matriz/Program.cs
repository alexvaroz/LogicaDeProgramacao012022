using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mesesDoAno = new string[12];
            mesesDoAno[3] = "Abril";
            mesesDoAno[0] = "Janeiro";
            mesesDoAno[11] = "Dezembro";
            for (int i = 0; i < mesesDoAno.Length; i++)
            {
                // Console.WriteLine(mesesDoAno[i]);
            }

            foreach(string item in mesesDoAno)
            {
                // Console.WriteLine(item);
            }

            //Declaração de Matriz
            int[,] numeros = new int[2, 3];
            numeros[0, 0] = 8;
            numeros[0, 1] = 40;
            numeros[0, 2] = 0;
            numeros[1, 0] = 2;
            numeros[1, 1] = 7;
            numeros[1, 2] = 1;
            Console.WriteLine("Usando foreach");
            foreach(int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadLine();
            Console.WriteLine("Imprimir usando o For");
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine(numeros[i, j]);
                }
            }

            Random rnd = new Random();

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] = rnd.Next(50);
                }
            }

            Console.ReadLine();
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine(numeros[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
