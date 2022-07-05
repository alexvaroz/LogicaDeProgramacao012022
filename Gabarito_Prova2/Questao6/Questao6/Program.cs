namespace Questao6
{
    /*
     * Para a resolução da questão, siga as seguintes intruções:  
     * (i) Crie uma classe de nome "Retangulo" com os seguintes atributos privados: base(int) e altura(int) 
     * (ii)	Crie propriedades para o acesso a esses atributo. 
     * (iii) Crie um método que retorne a área do retângulo. 
     * (obs. A área do retângulo é o produto da base pela altura) 
     * (iv) Na classe Program, crie um objeto do tipo "Retangulo” que tenha a base valendo 8 e a altura valendo 
     * 4 e imprima a área do retângulo executando o método da classe.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            Retangulo retanguloTeste = new Retangulo(8, 4);
            Console.WriteLine($"O retângulo criado apresenta área igual a {retanguloTeste.AreaRetangulo()}");
        }
    }

    public class Retangulo
    {
        int baseRetangulo;
        int alturaRetangulo;

        public Retangulo(int baseRetangulo, int alturaRetangulo)
        {
            this.baseRetangulo = baseRetangulo;
            this.alturaRetangulo = alturaRetangulo;
        }

        public int BaseRetangulo
        {
            get { return baseRetangulo; }
        }
        public int AlturaRetangulo
        {
            get { return alturaRetangulo; }
        }

        public int AreaRetangulo()
        {
            return baseRetangulo * alturaRetangulo;
        }

    }
}