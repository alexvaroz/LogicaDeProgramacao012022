using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    /*
    Escreva um programa em C# que leia uma temperatura em graus Celsius e apresente-a convertida 
    em graus Fahrenheit. A fórmula de conversão é: F = (9 * C + 160) / 5, na qual F é a temperatura 
    em Fahrenheit e C é a temperatura em Celsius.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma temperatura em graus Celsius:");
            double grausCelsius = double.Parse(Console.ReadLine());
            double grausFahrenheit = (9 * grausCelsius + 160) / 5;
            double retornoEmCelsius = (grausFahrenheit - 32) * 5 / 9;
            Console.WriteLine($"A temperatura {grausCelsius} em Celsius é {grausFahrenheit}ºF ");
            Console.WriteLine($"A temperatura {grausFahrenheit} em Fahrenheit é {retornoEmCelsius}ºC ");
            Console.ReadLine();
        }
    }
}
