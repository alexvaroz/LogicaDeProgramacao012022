using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4_ConverterCelsius_F
{
    class Program
    {
        // Declaração do método
        static float ConverterTemperaturaCelsiusFahrenheit(float tempCelsius)
        {
            float tempFahrenheit = (tempCelsius * 9 / 5) + 32;
            return tempFahrenheit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia!!!");
            Console.WriteLine("Digite a temperatura em graus Celsius:");
            float temperaturaCelsius = float.Parse(Console.ReadLine());
            Console.WriteLine($"A temperatura em F "+
                                $"é {ConverterTemperaturaCelsiusFahrenheit(temperaturaCelsius)}");
            Console.ReadLine();

        }

        
        

    }
}
