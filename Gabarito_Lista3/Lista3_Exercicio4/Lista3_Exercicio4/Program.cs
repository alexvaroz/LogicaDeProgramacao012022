using System;

namespace Lista3_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, somaDoisMaiores;

            Console.WriteLine("Insira 3 números inteiros:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    somaDoisMaiores = num1 + num2;
                }
                else
                {
                    somaDoisMaiores = num1 + num3;
                }
            }
            else
            {
                if (num1 > num3)
                {
                    somaDoisMaiores = num1 + num2;
                }
                else
                {
                    somaDoisMaiores = num2 + num3;
                }
            }
            Console.WriteLine("A soma dos dois maiores números é {0}", somaDoisMaiores);
        }
    }
}
