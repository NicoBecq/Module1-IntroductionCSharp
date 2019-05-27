using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // création d'un tableau week contenant les jours de la semaine
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
            // affichage de chaque élement du tableau week
            Console.WriteLine($"{week[0]}, {week[1]}, {week[2]}, {week[3]}, {week[4]}, {week[5]}, {week[6]}");
            week[4] = "Vendredi"; // remplacement de la valeur de l'indice 4 du talbeau par "vendredi"
            // affichage de chaque élement du tableau week
            Console.WriteLine($"{week[0]}, {week[1]}, {week[2]}, {week[3]}, {week[4]}, {week[5]}, {week[6]}");
            //corrigé
        }
    }
}
