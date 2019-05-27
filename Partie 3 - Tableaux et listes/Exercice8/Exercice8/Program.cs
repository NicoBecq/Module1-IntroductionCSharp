using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8
{
    class Program
    {
        enum week
        {
            // Récupération de l'énumération
            Lundi=1, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche
        }
        static void Main(string[] args)
        {
            // Chercher le nom de l'index 4 dans l'enum, puis la stocker
            string value4 = Enum.GetName(typeof(week), 4);
            // afficher le résultat
            Console.WriteLine(value4);
        }
    }
}
