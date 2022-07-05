namespace Questao8
{
    /*
     * Desenvolva um método que, utilizando RECURSÃO, conte o número de algarismos de um número inteiro.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            int numeroTeste = 100;
            Console.WriteLine($"A quantidade de algarismos do número {numeroTeste} é " +
                $"{RetornarQuantidadeAlgarismosNumero(numeroTeste)} ");
            Console.ReadLine();
        }

        static int RetornarQuantidadeAlgarismosNumero(int numero)
        {
            if ((numero / 10) == 0)
            {
                return 1;
            }

            return 1 + RetornarQuantidadeAlgarismosNumero(numero / 10);
        }
    }
}