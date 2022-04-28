using System;

namespace Lista4_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 201; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();          
        }
    }
}
