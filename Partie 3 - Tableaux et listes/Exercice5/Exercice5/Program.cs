using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            // création d'une liste numbers contenant des chiffres
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6 };
            // affichage des élements de la liste
            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]}");
            numbers.Insert(0, 1); // insertion d'un chiffre à l'indice 0 de la liste
            numbers.Add(7); // ajout d'un chiffre dans le talbeau à la suite des autres
            // affichage des élements de la liste
            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]}, {numbers[5]}, {numbers[6]}");
        }
    }
}
