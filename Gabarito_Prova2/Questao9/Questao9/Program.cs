namespace Questao9
{
    /*
     * Uma string é considerada um array de caracteres. Desse modo, todas as operações e manipulações possíveis 
     * em um array são aplicáveis em uma string. Dito isso, desenvolva um método que receba uma palavra(string) 
     * e retorne a quantidade de vogais encontradas.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            string palavra = "inconstitucionalmente";
            Console.WriteLine($"A palavra {palavra} possui {RetornarQuantidadeVogaisEmPalavra(palavra)} vogais");
            Console.ReadLine();
        }

        static int RetornarQuantidadeVogaisEmPalavra(string palavra)
        {
            int quantidadeVogais = 0;
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < palavra.Length; i++)
            {
                // if (vogais.Contains(palavra[i]))
                if (palavra[i] == vogais[0] ||
                    palavra[i] == vogais[1] ||
                    palavra[i] == vogais[2] ||
                    palavra[i] == vogais[3] ||
                    palavra[i] == vogais[4])
                {
                    quantidadeVogais++;
                }
            }
            return quantidadeVogais;
        }
    }
}