using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // initialisation d'un compteur pour vérifier la condition de sortie de la boucle
            // jusqu'a ce que i atteigne 9, afficher le message
            while (i < 10)
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                i++; // incrémentation du compteur pour pouvoir sortir de la boucle
            }

            // seconde syntaxe de while (effectue un tour de boucle dans tous les cas)
            i = 0;
            do
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                i++; // incrémentation du compteur pour pouvoir sortir de la boucle
            }
            while (i < 10);
        }
    }
}
