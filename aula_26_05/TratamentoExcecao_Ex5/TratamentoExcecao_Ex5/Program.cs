using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecao_Ex5
{
    /*
    Escreva um programa para preencher valores de um vetor de inteiros com 
    10 posições. O usuário irá informar os valores a serem inseridos e suas 
    respectivas posições no array. O programa deve tratar as exceções 
    ArrayIndexOutOfBoundsException quando for informada uma posição inexistente 
    do vetor e NumberFormatException quando o valor informado não for número.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Boolean continuar = true;
            while (continuar)
            {
                PreencherArray(array);
                Console.ReadLine();
                Console.WriteLine("Deseja continuar? S ou N");
                string opcao = Console.ReadLine();
                if (opcao != "S")
                {
                    continuar = false;
                }
            }
        }

        static void PreencherArray(int[] array)
        {
            try {
                Console.WriteLine("Informe o número a ser inserido no array");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a posição do número no array");
                int posicao = int.Parse(Console.ReadLine());
                array[posicao] = numero;
            } catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            } catch (IndexOutOfRangeException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        } 
    }
}
