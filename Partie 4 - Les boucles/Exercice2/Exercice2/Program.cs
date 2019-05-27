using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; // initialisation d'un compteur 
            // jusqu'a ce que i atteigne 10, afficher le message contenant la valeur de i
            while (i < 11)
            {
                Console.WriteLine($"Bonjour, je suis le message n° {i}"); 
                i++; // incrémentation de i pour pouvoir sortir de la boucle
            }
        }
    }
}
