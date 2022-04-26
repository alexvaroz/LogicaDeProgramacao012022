using System;

namespace Lista3_Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeAtleta, categoria;
            int idadeAtleta;
            Console.WriteLine("Digite o nome e a idade do atleta a ser classificado.");
            categoria = "não identificada";
            nomeAtleta = Console.ReadLine();
            idadeAtleta = int.Parse(Console.ReadLine());
            if (idadeAtleta >= 5 && idadeAtleta <= 10)
                categoria = "Infantil";
            if (idadeAtleta >= 11 && idadeAtleta <= 15)
                categoria = "Juvenil";
            if (idadeAtleta >= 16 && idadeAtleta <= 20)
                categoria = "Junior";
            if (idadeAtleta >= 21 && idadeAtleta <= 25)
                categoria = "Profissional";
            Console.WriteLine($"O atleta {nomeAtleta} foi classificado na categoria {categoria}.");
            Console.ReadLine();
        }
    }
}
