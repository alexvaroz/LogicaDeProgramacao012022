using System;

namespace Lista4_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i%3 == 0)
                {
                    Console.WriteLine("Múltiplo de 3");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
