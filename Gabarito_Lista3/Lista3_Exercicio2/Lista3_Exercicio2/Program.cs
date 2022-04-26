using System;

namespace Lista3_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float temperaturaEmCelsius, temperaturaEmFahrenheit;
            Console.WriteLine("Informe a temperatura em graus Celsius a ser convertida:");
            temperaturaEmCelsius = float.Parse(Console.ReadLine());
            temperaturaEmFahrenheit = (9 * temperaturaEmCelsius + 160) / 5;
            Console.WriteLine($"Essa temperatura em Fahrenheit é {temperaturaEmFahrenheit} graus F");
            Console.ReadLine();
        }
    }
}
