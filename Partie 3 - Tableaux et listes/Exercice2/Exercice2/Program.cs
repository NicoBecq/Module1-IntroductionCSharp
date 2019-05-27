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
            // création d'un tableau week contenant les jours de la semaine
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Console.WriteLine(week[1]); //affichage de la valeur correspondant à l'indice 1 du tableau week
            Console.WriteLine(week[4]); //affichage de la valeur correspondant à l'indice 4 du tableau week
        }
    }
}
