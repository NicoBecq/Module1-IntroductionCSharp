using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        // création d'une enumeration week contenant les jours de la semaine
        enum Week
        {
            Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche
        }
        static void Main(string[] args)
        {
            // affichage de chaque élement de l'enum
            Console.WriteLine($"{Week.Lundi}, {Week.Mardi}, {Week.Mercredi}, {Week.Jeudi}, {Week.Vendredi}, {Week.Samedi}, {Week.Dimanche}");
        }
    }
}
