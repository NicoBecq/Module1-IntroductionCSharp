using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            // création d'un tableau months contenant tous les moins de l'année
            string[] months = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
            // pour tous les mois dans months, afficher le mois
            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
        }
    }
}
