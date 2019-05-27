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
            // initialisation du tableau contenant les mois de l'année
            string[] month = new string[] {"Décembre", "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre" };

            Console.WriteLine("Entrez le mois");
            string UserMonth = Console.ReadLine().ToLower(); // lecture et stockage du mois saisi par l'utilisateur

            // Si le mois saisi par l'utilisateur correspond à l'indice 0 ou 1 ou 2 du talbeau des mois de l'année, c'est l'hiver
            if (UserMonth == month[0] || UserMonth == month[1] || UserMonth == month[2])
            {
                Console.WriteLine("La saison du mois saisi est l'hiver");
            }
            // Sinon, si le mois saisi par l'utilisateur correspond à l'indice 3 ou 4 ou 5 du tableau, c'est le printemps
            else if (UserMonth == month[3] || UserMonth == month[4] || UserMonth == month[5])
            {
                Console.WriteLine("La saison du mois saisi est le printemps");
            }
            // Sinon, si le mois saisi par l'utilisateur correspond à l'indice 6 ou 7 ou 8 du tableau, c'est le l'été
            else if (UserMonth == month[6] || UserMonth == month[7] || UserMonth == month[8])
            {
                Console.WriteLine("La saison du mois saisi est l'été");
            }
            // Sinon, si le mois saisi par l'utilisateur correspond à l'indice 9 ou 10 ou 11 du tableau, c'est le l'automne
            else if (UserMonth == month[9] || UserMonth == month[10] ||UserMonth == month[11])
            {
                Console.WriteLine("La saison du mois saisi est l'automne");
            }
            // Sinon il y a erreur de saisie
            else
            {
                Console.WriteLine("Saisie non reconnue");
            }
        }

        // pour le switch on peut écrire plusieures conditions
        // case "décembre":
        // case "janvier":
        // case "février":
                // instruction
                //break;
    }
}
