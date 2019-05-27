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
            Console.WriteLine("Entrez votre nom:");
            string Nom = Console.ReadLine(); //récupération de l'entrée utilisiateur dans la variable nom
            Console.WriteLine("Entrez votre prénom:");
            string Prenom = Console.ReadLine();//récupération de l'entrée utilisiateur dans la variable prenom
            Console.WriteLine($"Bonjour, {Nom} {Prenom}, nous sommes le {DateTime.Now.DayOfWeek} {DateTime.Now.Day}/{DateTime.Now.Month}, comment allez vous?" );
            //DateTime.Today.ToLongDateString (affichage des infos du jour)
            /* DateTime dateFormate = DateTime.Now;
             * Console.WriteLine(dateFormat.ToString("dd-MM-yyyy"));
             */
        }
    }
}
