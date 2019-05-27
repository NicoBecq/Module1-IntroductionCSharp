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
            // création d'un tableau week contenant tous les jours de la semaine
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            // effectuer un tour de boucle jusqu'a ce que le compteur atteigne la meme valeur que la longeur du tableau
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]); // affichage d'un élement du tableau correspondant à l'indice qui vaut i
            }
        }
    }
}
