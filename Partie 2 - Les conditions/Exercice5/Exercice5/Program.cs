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
            // initialisation du tableau des dégats
            string[] fujita = new string[] { "Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres.",
                "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés.",
            "Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées.",
            "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts",
            "Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances",
            "Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu »."};


            Console.WriteLine("Entrez le type de tornade");
            string stormType = Console.ReadLine();// lecture et stockage de la saisie utilisateur sur le type de tornade

            // affichage du message stocké dans le talbeau en fonction de l'entrée utilisateur
            switch (stormType)
            {
                // si utilisateur saisi "F0", affichage du message stocké à l'indice 0 du talbeau...
                case "F0":
                    Console.WriteLine(fujita[0]);
                    break;
                case "F1":
                    Console.WriteLine(fujita[1]);
                    break;
                case "F2":
                    Console.WriteLine(fujita[2]);
                    break;
                case "F3":
                    Console.WriteLine(fujita[3]);
                    break;
                case "F4":
                    Console.WriteLine(fujita[4]);
                    break;
                case "F5":
                    Console.WriteLine(fujita[5]);
                    break;
                // ajout d'un message si la saisie n'est pas reconnu par la fonction switch
                default:
                    Console.WriteLine("Saisie non reconnue");
                    break;
            }
        }
    }
}
