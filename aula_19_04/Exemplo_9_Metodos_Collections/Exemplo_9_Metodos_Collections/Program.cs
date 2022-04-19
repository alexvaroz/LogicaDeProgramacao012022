using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_9_Metodos_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> herois = new List<string> { "Homem-Aranha", "Batman", "Homem de Ferro",
                "Thor", "Hulk", "Capitão América" };

            foreach (var heroi in herois)
            {
                Console.WriteLine(heroi);
            }
            Console.Write("\n");


            Console.WriteLine("Método Count (Quantidade de elementos na lista):");
            Console.WriteLine(herois.Count() + "\n");

            Console.WriteLine("Método Add (Doutor Estranho):");
            herois.Add("Doutor Estranho");

            foreach (var heroi in herois)
            {
                Console.WriteLine(heroi);
            }
            Console.Write("\n");


            Console.WriteLine("Método Insert(posição 0: 'Thanos'):");
            herois.Insert(0, "Thanos");
            foreach (var heroi in herois)
            {
                Console.WriteLine(heroi);
            }
            Console.Write("\n");

            Console.WriteLine("Método Remove('Hulk'):");
            herois.Remove("Hulk");
            foreach (var heroi in herois)
            {
                Console.WriteLine(heroi);
            }
            Console.Write("\n");

            Console.WriteLine("Método RemoveAt(posição 0: 'Thanos'):");
            herois.RemoveAt(0);
            foreach (var heroi in herois)
            {
                Console.WriteLine(heroi);
            }
            Console.Write("\n");

            //    //Console.WriteLine("Método Clear(remove todos os elementos da lista):");
            //    //herois.Clear();
            //    //imprimirLista(herois);

            Console.WriteLine("Método IndexOF 'Thanos':");
            Console.WriteLine(herois.IndexOf("Thanos"));

            Console.WriteLine("\nMétodo IndexOF 'Homem de Ferro':");
            Console.WriteLine(herois.IndexOf("Homem de Ferro"));

            Console.WriteLine("Método Reverse:");
            herois.Reverse();
            foreach (var heroi in herois)
            {
                Console.WriteLine(heroi);
            }
            Console.Write("\n");

            Console.WriteLine("\nMétodo Sort:");
            herois.Sort();
            foreach (var heroi in herois)
            {
                Console.WriteLine(heroi);
            }
            Console.Write("\n");


            Console.WriteLine("Método Clear(remove todos os elementos da lista):");
            herois.Clear();
            foreach (var heroi in herois)
            {
                Console.WriteLine(heroi);
            }
            Console.Write("\n");

            Console.ReadLine();
     
        }
    }
}
