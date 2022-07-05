namespace Questao1
{

    /* Implementar um método que receba uma matriz QUADRADA e retorne a soma da sua diagonal 
     * principal.Caso a matriz informada pelo usuário não seja quadrada, o método deve lançar 
     * uma exceção criada especificamente para esse caso.
     * P.S.A classe da exceção solicitada também deverá constar na resposta.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizTeste = GerarMatrizTesteLinhasColunas(8,7);
            try
            {
                Console.WriteLine($"A soma da diagonal da matriz é {SomarDiagonalMatrizQuadrada(matrizTeste)}");
            } catch (NotSquareMatrizException nsme)
            {
                Console.WriteLine("A matriz utilizada não é quadrada");
            }
            Console.ReadLine();

        }

        

        static int SomarDiagonalMatrizQuadrada(int[,] matriz)
        {
            int somaDiagonal = 0;
            if (matriz.GetLength(0) != matriz.GetLength(1))
            {
                throw new NotSquareMatrizException();
            }
            else
            {
                for(int i = 0; i < matriz.GetLength(0); i++)
                {
                    somaDiagonal = somaDiagonal + matriz[i, i];
                }
            }
            return somaDiagonal;
        }

        static int[,] GerarMatrizTesteLinhasColunas(int numLinhas, int numColunas)
        {
            Random rnd = new Random();
            int[,] matrizTeste = new int[numLinhas, numColunas];
            for (int i = 0; i < matrizTeste.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTeste.GetLength(1); j++)
                {
                    matrizTeste[i, j] = rnd.Next(0, 200);
                }
            }
            return matrizTeste;
        }
    }

    public class NotSquareMatrizException : ApplicationException
    {
        public NotSquareMatrizException(): base(){}
    }
}